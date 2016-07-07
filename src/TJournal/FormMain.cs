using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using Gma.UserActivityMonitor;
using System.Data.SqlClient;
using MovablePython;
using System.Data.SQLite;

namespace TJournal
{
   

    // Kanta backup
    // BACKUP DATABASE [TJournal] TO  DISK = N'H:\Backup\Tjournal_SQLS_Backup' WITH NOFORMAT, NOINIT,  NAME = N'TJournal-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
    // GO

    
    public partial class FormMain : Form
    {

        [ DllImport("user32.dll") ]
        static extern int GetForegroundWindow();

        [ DllImport("user32.dll") ]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);


        /*[DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers,int vk);
        */

        private DateTime dtLastWindowChange = DateTime.Now;
        private String sLastWindow = "";
        private String sLastNonTJournal = "";

        // Mouse movement detection
        private int lastX = 0;
        private int lastY = 0;
        private DateTime lastMouseMove = DateTime.Now;

        private DateTime lastKeyboard = DateTime.Now;
        private int keyCount = 0;
        private int totalKeyCount = 0;

        private int lastIdle = 0;
        private int currentIdle = 0;
        private bool isIdling = false;
        
        private long totalMouseDistance = 0;

        //ArrayList alPrograms = new ArrayList();

        Hashtable htPrograms = new Hashtable();
        Hashtable htGroups = new Hashtable();

        //OracleConnection _con;
        
        //SQLiteConnection _con;

        private Hotkey hk = new Hotkey();
        public tjournalEntities journalentities = null;

        public tj_blog blogentity = null;

        #region BuildTime/Date
        public static string BuildNumber
        {
            get
            {
                string build = Helper.GetResourceContent("TJournal.ver");
                //build = build.Substring(6, build.Length - 7);
                build = build.Replace("\n", "");
                build = build.Replace("\r", "");
                return build;
            }
        }


        public static string BuildDate
        {
            get
            {
                string build = Helper.GetResourceContent("TJournal.buildtime");
                //build = build.Substring(6, build.Length - 7);
                build = build.Replace("\n", "");
                build = build.Replace("\r", "");
                return build;
            }
        }
        #endregion



        public FormMain()
        {

            //System.Diagnostics.Debug.WriteLine(Helper.GetLocalUserName());

            
            InitializeComponent();
            timer1.Start();
            HookManager.KeyPress += new KeyPressEventHandler(HookManager_KeyPress);

            hk.KeyCode = Keys.J;
            hk.Windows = true;
            hk.Control = true;
            hk.Pressed += new HandledEventHandler(hk_Pressed);
            if (!hk.GetCanRegister(this))
            { 
                Console.WriteLine("Whoops, looks like attempts to register will fail or throw an exception, show an error/visual user feedback"); 
            }
            else
            { 
                hk.Register(this); 
            }
            openMainWindowToolStripMenuItem.Text += string.Format(" ({0}{1}{2})", hk.Windows?"WIN+":"", hk.Control?"CTRL+":"" , hk.KeyCode.ToString().ToUpper() );
            btnSetOccuredDate.Size = oCCUREDDateTimePicker.Size;
            btnSetOccuredDate.Location = oCCUREDDateTimePicker.Location;

            
            lblKeycount.Text = totalKeyCount.ToString();


            journalentities = new TJournal.tjournalEntities();

            try
            {
                long total = (long)journalentities.tj_programs.Count();
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exception: {0}", e.Message);
                //journalentities.Database.CreateIfNotExists();
                journalentities.Database.ExecuteSqlCommand("CREATE TABLE tj_blog(    \"ID\" INTEGER PRIMARY KEY AUTOINCREMENT,   \"CONTENTS\" TEXT, \"LOGGED\" TEXT, \"LINK_TO\" TEXT, \"CLASS\" TEXT, \"OCCURED\" TEXT, \"MOOD\" TEXT, \"USERNAME\" TEXT);  " );
                journalentities.Database.ExecuteSqlCommand("CREATE TABLE \"tj_mouse\" ( \"id\" INTEGER PRIMARY KEY AUTOINCREMENT,\"logged\" TEXT,    \"pixels_moved\" INTEGER );");
                journalentities.Database.ExecuteSqlCommand("CREATE TABLE \"tj_programs\" (    \"id\" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,    \"title\" TEXT,    \"time\" INTEGER,    \"idle\" INTEGER,    \"keys\" INTEGER,    \"starttime\" TEXT,    \"savetime\" TEXT);");
                
            }
            cONTENTSTextBox.ReadOnly = true;
            //panelProgramData.Visible = false;

            //programs = journalentities.tj_programs.Local;
        }





        private void Form1_Load(object sender, EventArgs e)
        {

            //blogentity = journalentities.tj_blog;
            journalentities.Database.Initialize(false);
            // tJ_BLOGBindingSource.DataSource = journalentities.tj_blog.Local;
            //journalentities.tj_blog.Local.lo
            tJ_BLOGBindingSource.DataSource = journalentities.tj_blog.ToList<tj_blog>();
            //tJ_BLOGBindingSource.DataMember = journalentities.tj_blog.Local;
            // Pistetään countterit loppuun.

            tJ_BLOGBindingSource.Position = tJ_BLOGBindingSource.Count - 1;

            

            //_con = new SqlConnection("");// Properties.Settings.Default.TJournalConnectionString);
            //_con.Open();
            oCCUREDDateTimePicker.DataBindings.Clear();
            oCCUREDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("VALUE", tJ_BLOGBindingSource, "OCCURED", true));
            oCCUREDDateTimePicker.DataBindings[0].Format += new ConvertEventHandler(b_Format);
            SetupComputerMenu();
        
            
        
            //this.Text += "  " + BuildNumber + " (" + BuildDate + ")";
            long total = 0;
            try
            {
                total = (long)journalentities.tj_programs.Sum<tj_programs>(p => p.keys);
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Error on fetching totals. Empty table?");

            }

            /*
            string s = "Select sum(keys) from tronkko.tj_programs";
            SQLiteCommand   cmd = new SQLiteCommand  (s, _con);
            object o = cmd.ExecuteScalar();
            int total = Convert.ToInt32(o);
            */


            totalKeyCount = (int)total;// Properties.Settings.Default.TotalKeyCount; // Tämä ladataan kannasta...
            UpdateLabels();
        }





      



        private void SetupComputerMenu()
        {
            ToolStripItem tsi = contextSysTray.Items[0];
            ToolStripMenuItem tsmi = (ToolStripMenuItem)tsi;
            ToolStripDropDownItem t3 = (ToolStripDropDownItem)tsmi;
            List<ToolStripItem> lItems = new List<ToolStripItem>();
            foreach  (ToolStripItem tsir in t3.DropDown.Items)
            {
                lItems.Add(tsir);
            }

            foreach (ToolStripItem tsir2 in lItems)
            {
                t3.DropDown.Items.Remove(tsir2);
            }
            

            //string s = "Select computerid, address from tj_computers";
            // Computers - disabled
            /*
            string s = "Select computerid, address, description, separator from tronkko.tj_computers order by ordernum";
            SQLiteCommand   cmd = new SQLiteCommand  (s, _con);
            SqlDataReader rdr = cmd.ExecuteReader();
            

            while (rdr.Read())
            {
                string nimi = rdr["computerid"].ToString();
                string osoite = rdr["address"].ToString();
                string kuvaus = rdr["description"].ToString();
                string sep = rdr["separator"].ToString();
                ToolStripMenuItem tmp = new ToolStripMenuItem(nimi);
                tmp.Tag = osoite;
                tmp.ToolTipText = kuvaus;
                tmp.Click += new EventHandler(bonbonToolStripMenuItem_Click);
                
                t3.DropDown.Items.Add(tmp);
                if (sep == "True")
                {
                    t3.DropDown.Items.Add(new ToolStripSeparator());
                }

            }

            rdr.Close();
            
            cmd.Dispose();            
            */
        }



        // TODO: Move this to Corelib if extra time
        private void Inform(string str)
        {
            Namu.FormSplashInformer fi = new Namu.FormSplashInformer("", str, 300);
            fi.Top = this.Top + (this.Height / 2) - (fi.Height / 2);
            fi.Left = this.Left + (this.Width / 2) - (fi.Width / 2);
            fi.Show();
        }




        void hk_Pressed(object sender, HandledEventArgs e)        
        {
            this.Show();
            this.Focus();

            //
            //System.Diagnostics.Debug.WriteLine("Oooohlalaaaalalala");

        }

        void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            lastKeyboard = DateTime.Now;
            keyCount++;
            totalKeyCount++;
            UpdateLabels();
            if (keyCount % 1000 == 0)
            {
                SaveKeycount();
            }

            //System.Diagnostics.Debug.WriteLine(e.KeyChar.ToString());
        }

        private void UpdateLabels()
        {
            //lblKeycount.Text = totalKeyCount.ToString();
            tslblKeyCount.Text = totalKeyCount.ToString();
        }

        
        //
		// GetForegroundWindow API 
		//
		private string GetActiveWindow()
		{
			
			const int nChars = 256;
			int handle = 0;
			StringBuilder Buff = new StringBuilder(nChars);
   			
			handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            else
            {
                return "";
            }
            

		}


        private string GroupId(string windowtitle)
        {
            string tmp = windowtitle;

            string[] abr = new string[] { "Google Chrome", "Visual studio", "Mozilla firefox", "SecureCRT", "Microsoft Outlook", "Message (HTML)", "Message (Plain text)"};
            
            foreach (string a in abr)
            {
                if (windowtitle.IndexOf(a,StringComparison.OrdinalIgnoreCase) > -1)
                {
                    tmp = a;
                    break;
                }
            }

            return tmp;
        }


        private void CheckForWindowChange()
        {

            string currentwindow = GetActiveWindow();
            if (currentwindow != sLastWindow)
            {
                TimeSpan ts = new TimeSpan(DateTime.Now.Ticks - dtLastWindowChange.Ticks);
                int usageTime = ((int)ts.TotalSeconds);
                    
                //System.Diagnostics.Debug.WriteLine(ts.ToString() + " - " + sLastWindow + " " + keyCount.ToString() + "/" + totalKeyCount.ToString() + " idle for " + lastIdle.ToString() + "s" );

                string g = GroupId(sLastWindow);

                if (!htGroups.Contains(g))
                {
                    ArrayList alKamat = new ArrayList();
                    alKamat.Add(htGroups.Count);
                    alKamat.Add(ts.ToString());
                    alKamat.Add(keyCount);
                    alKamat.Add(lastIdle);
                    htGroups.Add(g, alKamat);
                    lvGroups.Items.Add(new ListViewItem(new string[] { g, alKamat[1].ToString(), alKamat[2].ToString(), alKamat[3].ToString() })); 
                }
                else
                {
                    ArrayList alKamat = htGroups[g] as ArrayList;
                    //0 alKamat.Add(htGroups.Count);
                    TimeSpan tstmp = TimeSpan.Parse( alKamat[1] as string) + ts ;
                    //System.Diagnostics.Debug.WriteLine(tstmp.ToString());
                    alKamat[1] = tstmp.ToString(); //1
                    int tmpkeycount = Convert.ToInt32 (alKamat[2] );
                    alKamat[2] = tmpkeycount + keyCount;  //2
                    int tmpIdle = Convert.ToInt32(alKamat[3]);

                    alKamat[3] = lastIdle + lastIdle ; // 3
                    htGroups[g] = alKamat;

                    int listix = Convert.ToInt32( alKamat[0]);
                    lvGroups.Items[listix].SubItems[1].Text = alKamat[1].ToString();
                    lvGroups.Items[listix].SubItems[2].Text =  alKamat[2].ToString();
                    lvGroups.Items[listix].SubItems[3].Text = alKamat[3].ToString() ; 

                }

                if (!htPrograms.Contains(sLastWindow))
                {
                    ArrayList alKamat = new ArrayList();
                    alKamat.Add(htPrograms.Count);
                    alKamat.Add(ts.ToString());
                    alKamat.Add(keyCount);
                    alKamat.Add(lastIdle);
                    htPrograms.Add(sLastWindow, alKamat);
                    lvPrograms.Items.Add(new ListViewItem(new string[] { sLastWindow, alKamat[1].ToString(), alKamat[2].ToString(), alKamat[3].ToString() }));
                }
                else
                {
                    ArrayList alKamat = htPrograms[sLastWindow] as ArrayList;
                    //0 alKamat.Add(htGroups.Count);
                    TimeSpan tstmp = TimeSpan.Parse(alKamat[1] as string) + ts;
                    //System.Diagnostics.Debug.WriteLine(tstmp.ToString());
                    alKamat[1] = tstmp.ToString(); //1
                    int tmpkeycount = Convert.ToInt32(alKamat[2]);
                    alKamat[2] = tmpkeycount + keyCount;  //2
                    int tmpIdle = Convert.ToInt32(alKamat[3]);

                    alKamat[3] = lastIdle + lastIdle; // 3
                    htPrograms[sLastWindow] = alKamat;

                    int listix = Convert.ToInt32(alKamat[0]);
                    lvPrograms.Items[listix].SubItems[1].Text = alKamat[1].ToString();
                    lvPrograms.Items[listix].SubItems[2].Text = alKamat[2].ToString();
                    lvPrograms.Items[listix].SubItems[3].Text = alKamat[3].ToString();

                }


                

                lastIdle = 0;
                keyCount = 0;
                dtLastWindowChange = DateTime.Now;
                if (!sLastWindow.Contains("TJournal"))
                {
                    sLastNonTJournal = sLastWindow;
                }
                sLastWindow = currentwindow;

            }
            
        }



        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }




        private void ExitApplication()
        {
            if (notifyIcon1 != null)
            {
                notifyIcon1.Dispose();
                SaveAll();                         
                DumpData();
                //_con.Close();
            }
            SaveKeycount();
            Application.Exit();
        }



        private void DumpData()
        {
            DumpProgramData();
            DumpMouseData();
        }



        private void SaveKeycount()
        {
            Properties.Settings.Default.TotalKeyCount = totalKeyCount;
            Properties.Settings.Default.Save();
            System.Diagnostics.Debug.WriteLine("Saved.");

        }

        

       



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
            else
            {
                if (hk.Registered)
                { 
                    hk.Unregister(); 
                }

                notifyIcon1.Dispose();
            }
            this.Hide();
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //Idle check...
            int X = MousePosition.X;
            int Y = MousePosition.Y;
            if (X != lastX || Y != lastY)
            {
                int dX = X - lastX;
                int dY = Y - lastY;
                double distance = Math.Sqrt (dX * dX + dY * dY);

                totalMouseDistance += (long)distance;
                lastY = Y;
                lastX = X;
                lastMouseMove = DateTime.Now;
                double matka = ((double)(totalMouseDistance / 37.5) / 100);
                matka = Math.Round( matka,2);
                // TODO: Fix this
                lblTotalCursorMove.Text = matka.ToString() + "m";
                tslblCursor.Text = lblTotalCursorMove.Text;
                double hiirimatka = Math.Round(matka * 100 / Properties.Settings.Default.MouseToCursorMultiplier, 2);
                lblMouseMove.Text = hiirimatka.ToString() + "cm" ;

            }

            int t = CheckIdleTime();

            if (t > 3600)
            {
                // Tallennetaan kokonaismäärä kerran tuntiin jos idlaillaan?
                System.Diagnostics.Debug.WriteLine("Idle one hour, saving data...");
                DumpData();
            }

            if (t > 0 && !isIdling)
            {
                currentIdle = t;
                isIdling = true;
            }
            else if (t == 0 && isIdling)
            {
                lastIdle += currentIdle;
                currentIdle = 0;
                isIdling = false;
            }
            else if (isIdling)
            {
                currentIdle = t;
                //System.Diagnostics.Debug.WriteLine(currentIdle.ToString());
            }

            CheckForWindowChange();
            
            //System.Diagnostics.Debug.WriteLine(new TimeSpan(DateTime.Now.Ticks - lastMouseMove.Ticks ).ToString() );                    
        }





        private int CheckIdleTime()
        {
            int MINIDLE = 30; // 60 sec is idle
            int t = 0;
            DateTime lastEvent = DateTime.Now;
            if (lastKeyboard > lastMouseMove)
            {
            lastEvent = lastKeyboard;
            }
            else lastEvent = lastMouseMove;

            TimeSpan tspan = new TimeSpan(DateTime.Now.Ticks - lastEvent.Ticks);

            if (tspan.TotalSeconds > MINIDLE)
            {
                t = (int)tspan.TotalSeconds;
                
            }
            return t;
        }



        private void openMainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMainWindow();
        }



        private void OpenMainWindow()
        {
            this.Show();
        }



        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenMainWindow();   
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();   
        }



        private void tJ_BLOGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAll();

        }



        private void SaveAll()
        {
            this.Validate();
            cONTENTSTextBox.ReadOnly = true;
            Application.DoEvents();
            tJ_BLOGBindingSource.EndEdit();
            foreach ( tj_blog t in journalentities.tj_blog.Local.ToList())
            {
                System.Diagnostics.Debug.WriteLine("{0} {1} {2}", t.ID,t.USERNAME, t.CONTENTS);
            }

            int i = this.journalentities.SaveChanges();
            System.Diagnostics.Debug.WriteLine("Saving {0} items",i);
            
            //this.tableAdapterManager.UpdateAll(this.tJournalDataSet);
            Inform("Saved...");
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }




        private void AddNewItem()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                //OracleCommand cmd = new OracleCommand("select tj_blog_sequence.nextval from dual", _con);
                //object o = cmd.ExecuteOracleScalar();
                //int i = Convert.ToInt32(o);
                //iDTextBox.Text = o.ToString();
                lINK_TOTextBox.Text = sLastNonTJournal;
                lOGGEDDateTimePicker.Value = DateTime.Now;
                
                uSERNAMETextBox.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                
                // Zero classbox.
                foreach (var product in journalentities.tj_blog.Local.ToList())
                {
                    System.Diagnostics.Debug.WriteLine("hep: {0}", product.ID);
                }

                if (tJ_BLOGBindingSource.Current != null)
                {
                    tj_blog blog = journalentities.tj_blog.Add((tj_blog) tJ_BLOGBindingSource.Current);
                    blog.USERNAME = uSERNAMETextBox.Text;
                    //blog.OCCURED = oCCUREDDateTimePicker.ToString();
                    blog.MOOD = mOODComboBox.SelectedText.ToString();
                    blog.LOGGED = lOGGEDDateTimePicker.ToString();
                    blog.LINK_TO = lINK_TOTextBox.Text;

                }

                foreach (var product in journalentities.tj_blog.Local.ToList())
                {
                    System.Diagnostics.Debug.WriteLine("hep: {0}", product.ID);
                }
                //tj_blog t = new tj_blog() = journalentities.tj_blog.Add(t);
                //UpdateClassListFromText();
                cONTENTSTextBox.ReadOnly = false;
                cONTENTSTextBox.Focus();
            }
                //TTrack
        }





        private void Form1_Shown(object sender, EventArgs e)
        {
            SaveKeycount();
            ValidateUI();
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAll();
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tJ_BLOGBindingSource.AddNew();
            }
            AddNewItem();
        }


        private void DumpMouseData()
        {
            // Oracleversion
            //string s = "insert into tj_mouse (id, logged, pixels_moved) values (tj_mouse_sequence.nextval, :logged, :pixels)"; 

            string s = "insert into tronkko.tj_mouse (logged, pixels_moved) values (@logged, @pixels)";
            tj_mouse mouse = new tj_mouse();
            mouse.logged = DateTime.Now.ToString();
            mouse.pixels_moved = totalMouseDistance;
            /*
            SQLiteCommand cmd = new SQLiteCommand(s,_con);
            cmd.Parameters.Add(new SqlParameter("logged", DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("pixels", totalMouseDistance));
            totalMouseDistance = 0;
            
            int i = cmd.ExecuteNonQuery();
            */
            journalentities.tj_mouse.Add(mouse);
            int i = journalentities.SaveChanges();
            System.Diagnostics.Debug.WriteLine("Hiiren liikkeitä tallennetiin: {0}", i);




        }


        
        private void DumpProgramData()
        {
            CheckForWindowChange();
            // Tähä ois hyvä tehdä joku semmonen nollaus tolle htprogramsille
            //string s = "insert into tj_programs (id, title, time, idle, keys, starttime, savetime) values (tj_programs_sequence.nextval, :title, :time, :idle, :keys, :starttime, :savetime)";
            string s = "insert into tronkko.tj_programs (title, time, idle, keys, starttime, savetime) values (@title, @time, @idle, @keys, @starttime, @savetime)";
            
            

            string[] keys = new string[htPrograms.Count];
            htPrograms.Keys.CopyTo(keys, 0);
            
            foreach (string key in keys)
            {

                ArrayList alKamat = htPrograms[key] as ArrayList;
                if (key == "")
                {
                    continue;
                }

                TimeSpan ts = TimeSpan.Parse(alKamat[1] as string);
                int tmpkeycount = Convert.ToInt32(alKamat[2]);
                int tmpIdle = Convert.ToInt32(alKamat[3]);

                tj_programs t = new tj_programs();
                t.idle = tmpIdle;
                t.keys = tmpkeycount;
                t.savetime = DateTime.Now.ToString();
                t.time = Convert.ToInt64 (ts.TotalSeconds);
                t.title = key;
                journalentities.tj_programs.Add(t);

                /*SQLiteCommand  cmd = new SQLiteCommand  (s, _con);
                cmd.Parameters.Add(new SqlParameter("title", key));
                cmd.Parameters.Add(new SqlParameter("time", ts.TotalSeconds));
                cmd.Parameters.Add(new SqlParameter("idle", tmpIdle));
                cmd.Parameters.Add(new SqlParameter("keys", tmpkeycount));
                cmd.Parameters.Add(new SqlParameter("starttime", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("savetime", DateTime.Now));
                
                int i = cmd.ExecuteNonQuery();
                */

                
            }
            int i = journalentities.SaveChanges();
            System.Diagnostics.Debug.WriteLine("Saved {0} lines of programs.", i);

            htPrograms.Clear();
            lvPrograms.Items.Clear();
            CheckForWindowChange();
            //System.Diagnostics.Debug.WriteLine("Kirjoitettiin: " + total.ToString());
            
        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            DumpProgramData();
        }



        private void showProgramHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProgramHistory fph = new FormProgramHistory(journalentities);
            fph.Show();
        }



        private void btnSetOccuredDate_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == btnSetOccuredDate)
            {
                oCCUREDDateTimePicker.Value = DateTime.Now;
                btnSetOccuredDate.Visible = false;
                oCCUREDDateTimePicker.Visible = true;
            }
            
        }

        
        
        private void tJ_BLOGBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
 
        }

       


        void b_Format(object sender, ConvertEventArgs e)
        {
            Binding b = sender as Binding;
            if (e.Value == null)
            {
                if (b.Control == oCCUREDDateTimePicker)
                {
                    btnSetOccuredDate.Visible = true;
                    oCCUREDDateTimePicker.Visible = false;
                }
                return;
            }
            if (e.Value.ToString().Length < 1)
            {
                e.Value = null;
                if (b.Control == oCCUREDDateTimePicker)
                {
                    btnSetOccuredDate.Visible = true;
                    oCCUREDDateTimePicker.Visible = false;
                }
            }
            else
            {
                if (b.Control == oCCUREDDateTimePicker)
                {
                    btnSetOccuredDate.Visible = false;
                    oCCUREDDateTimePicker.Visible = true;
                }
            }
        }



        private void cONTENTSTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        private void cONTENTSTextBox_DoubleClick(object sender, EventArgs e)
        {
            cONTENTSTextBox.ReadOnly = !cONTENTSTextBox.ReadOnly;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            DumpData();
        }



        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    s += i.ToString();
                }
            }
            cLASSTextBox.Text = s;
        }




        private void cLASSTextBox_TextChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.Focused)
            {
                return;
            }
            else
            {
                UpdateClassListFromText();
            }
        }


        /// <summary>
        /// Updates classlist from the appropriatetextbox
        /// </summary>
        private void UpdateClassListFromText()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, cLASSTextBox.Text.Contains(i.ToString()));
            }
        }



        // nää sais olla sit tulevaisuudessa enemmän dynaamisiä 
        private void bonbonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            if (tsmi != null)
            {
                string osoite = tsmi.Tag.ToString();
                System.Diagnostics.Process.Start("mstsc.exe", "/admin /v:"+ osoite);

            }
        }

        private void computerEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComputerManagement fcm = new FormComputerManagement();
            fcm.ShowDialog();
            SetupComputerMenu();
            
        }

        private void SetMoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsi = sender as ToolStripMenuItem;
            mOODComboBox.Text = tsi.Text;
        }

        private void previousItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tJ_BLOGBindingSource.MovePrevious();
            }
            PostMove();
        }

        private void moveNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tJ_BLOGBindingSource.MoveNext();                
            }
            PostMove();
        }



        private void PostMove()
        {
            UpdateClassListFromText();
        }

        private void browseItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBrowseItems fbi = new FormBrowseItems();
            fbi.Show();
        }



        private void tJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void tTuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void tTrackMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
 


        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void tT_TRACKDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateUI();
        }



        private void ValidateUI()
        {
            insertTagsToolStripMenuItem.Enabled = (tabControl1.SelectedIndex == 1);
            UpdateTagLabel();
        }

        private void tT_TRACKDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage2_TextChanged(object sender, EventArgs e)
        {
            UpdateTagLabel();
        }

        private void UpdateTagLabel()
        {
            string t = "";// ((DataRowView)tT_TRACKBindingSource.Current).Row["Tags"].ToString();
            string[] tagit = t.Split(new char[] { '#' });
        }

        private void tT_TRACKBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateTagLabel();
        }

        private void mOODComboBox_TextChanged(object sender, EventArgs e)
        {
            if (mOODComboBox.Text == "XD")
            {
                mOODComboBox.BackColor = Properties.Settings.Default.ColorPerfect;
            }
            else if (mOODComboBox.Text == ":)")
            {
                mOODComboBox.BackColor = Properties.Settings.Default.ColorAlmostPerfect;
            }
            else if (mOODComboBox.Text == ":|")
            {
                mOODComboBox.BackColor = Properties.Settings.Default.ColorNeutral;
            }
            else if (mOODComboBox.Text == ":(")
            {
                mOODComboBox.BackColor = Properties.Settings.Default.ColorAlmostBad;
            }
            else if (mOODComboBox.Text == "XO")
            {
                mOODComboBox.BackColor = Properties.Settings.Default.ColorBad;
            }



            else mOODComboBox.BackColor = Color.White;

            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            journalentities.tj_blog.Local.Remove((tj_blog)tJ_BLOGBindingSource.Current);
            tJ_BLOGBindingSource.Remove(tJ_BLOGBindingSource.Current);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mnuAboutHelp_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }
    }
}

 

