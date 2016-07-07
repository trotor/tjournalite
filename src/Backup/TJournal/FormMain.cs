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
using System.Data.OracleClient;
using MovablePython;


namespace TJournal
{
   

    
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

        OracleConnection _con;

        private Hotkey hk = new Hotkey();



        public FormMain()
        {
            InitializeComponent();
            timer1.Start();
            HookManager.KeyPress += new KeyPressEventHandler(HookManager_KeyPress);

            hk.KeyCode = Keys.J;
            hk.Windows = true;

            hk.Pressed += new HandledEventHandler(hk_Pressed);
            if (!hk.GetCanRegister(this))
            { 
                Console.WriteLine("Whoops, looks like attempts to register will fail or throw an exception, show an error/visual user feedback"); 
            }
            else
            { 
                hk.Register(this); 
            }

            btnSetOccuredDate.Size = oCCUREDDateTimePicker.Size;
            btnSetOccuredDate.Location = oCCUREDDateTimePicker.Location;
            
            lblKeycount.Text = totalKeyCount.ToString();

            cONTENTSTextBox.ReadOnly = true;
            panelProgramData.Visible = false;

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
            lblKeycount.Text = totalKeyCount.ToString();            
            //System.Diagnostics.Debug.WriteLine(e.KeyChar.ToString());
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

            string[] abr = new string[] { "Visual studio", "Mozilla firefox", "SecureCRT", "Microsoft Outlook", "Message (HTML)", "Message (Plain text)"};
            
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
                    
                System.Diagnostics.Debug.WriteLine(ts.ToString() + " - " + sLastWindow + " " + keyCount.ToString() + "/" + totalKeyCount.ToString() + " idle for " + lastIdle.ToString() + "s" );

                string g = GroupId(sLastWindow);

                if (!htGroups.Contains(g))
                {
                    ArrayList alKamat = new ArrayList();
                    alKamat.Add(htGroups.Count);
                    alKamat.Add(ts.ToString());
                    alKamat.Add(keyCount);
                    alKamat.Add(lastIdle);
                    htGroups.Add(g, alKamat);
                    listView2.Items.Add(new ListViewItem(new string[] { g, alKamat[1].ToString(), alKamat[2].ToString(), alKamat[3].ToString() })); 
                }
                else
                {
                    ArrayList alKamat = htGroups[g] as ArrayList;
                    //0 alKamat.Add(htGroups.Count);
                    TimeSpan tstmp = TimeSpan.Parse( alKamat[1] as string) + ts ;
                    System.Diagnostics.Debug.WriteLine(tstmp.ToString());
                    alKamat[1] = tstmp.ToString(); //1
                    int tmpkeycount = Convert.ToInt32 (alKamat[2] );
                    alKamat[2] = tmpkeycount + keyCount;  //2
                    int tmpIdle = Convert.ToInt32(alKamat[3]);

                    alKamat[3] = lastIdle + lastIdle ; // 3
                    htGroups[g] = alKamat;

                    int listix = Convert.ToInt32( alKamat[0]);
                    listView2.Items[listix].SubItems[1].Text = alKamat[1].ToString();
                    listView2.Items[listix].SubItems[2].Text =  alKamat[2].ToString();
                    listView2.Items[listix].SubItems[3].Text = alKamat[3].ToString() ; 

                }

                if (!htPrograms.Contains(sLastWindow))
                {
                    ArrayList alKamat = new ArrayList();
                    alKamat.Add(htPrograms.Count);
                    alKamat.Add(ts.ToString());
                    alKamat.Add(keyCount);
                    alKamat.Add(lastIdle);
                    htPrograms.Add(sLastWindow, alKamat);
                    listView1.Items.Add(new ListViewItem(new string[] { sLastWindow, alKamat[1].ToString(), alKamat[2].ToString(), alKamat[3].ToString() }));
                }
                else
                {
                    ArrayList alKamat = htPrograms[sLastWindow] as ArrayList;
                    //0 alKamat.Add(htGroups.Count);
                    TimeSpan tstmp = TimeSpan.Parse(alKamat[1] as string) + ts;
                    System.Diagnostics.Debug.WriteLine(tstmp.ToString());
                    alKamat[1] = tstmp.ToString(); //1
                    int tmpkeycount = Convert.ToInt32(alKamat[2]);
                    alKamat[2] = tmpkeycount + keyCount;  //2
                    int tmpIdle = Convert.ToInt32(alKamat[3]);

                    alKamat[3] = lastIdle + lastIdle; // 3
                    htPrograms[sLastWindow] = alKamat;

                    int listix = Convert.ToInt32(alKamat[0]);
                    listView1.Items[listix].SubItems[1].Text = alKamat[1].ToString();
                    listView1.Items[listix].SubItems[2].Text = alKamat[2].ToString();
                    listView1.Items[listix].SubItems[3].Text = alKamat[3].ToString();

                }



                //if (!alPrograms.Contains(sLastWindow))
                //{
                //    listView1.Items.Add(new ListViewItem(new string[] { usageTime.ToString() , sLastWindow, keyCount.ToString(), lastIdle.ToString() }));
                //    alPrograms.Add(sLastWindow);
                //}
                //else
                //{
                //    int ix = alPrograms.IndexOf(sLastWindow);
                //    int origTotalS = Convert.ToInt32(listView1.Items[ix].SubItems[0].Text) ;
                //    usageTime += origTotalS;
                //    listView1.Items[ix].SubItems[0].Text = usageTime.ToString();
                //}

                //listView1.sele

                // Tulostetaan myös group...


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
            notifyIcon1.Dispose();
            DumpProgramData();
            DumpMouseData();
            _con.Close();            
            Application.Exit();
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
                lblTotalMouseMove.Text = matka.ToString() + "m";
                double hiirimatka = Math.Round(matka * 100 / Properties.Settings.Default.MouseToCursorMultiplier, 2);
                label2.Text = hiirimatka.ToString() + "cm" ;

            }

            int t = CheckIdleTime();

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
            this.tJ_BLOGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            Inform("Tallennettu...");
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }




        private void AddNewItem()
        {
            OracleCommand cmd = new OracleCommand("select tj_blog_sequence.nextval from dual", _con);
            object o = cmd.ExecuteOracleScalar();
            //int i = Convert.ToInt32(o);
            iDTextBox.Text = o.ToString();
            lINK_TOTextBox.Text = sLastNonTJournal;
            lOGGEDDateTimePicker.Value = DateTime.Now;
            cONTENTSTextBox.ReadOnly = false;
            cONTENTSTextBox.Focus();
        }



        private void Form1_Shown(object sender, EventArgs e)
        {
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAll();
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tJ_BLOGBindingSource.AddNew();
            AddNewItem();
        }


        private void DumpMouseData()
        {
            string s = "insert into tj_mouse (id, logged, pixels_moved) values (tj_mouse_sequence.nextval, :logged, :pixels)";
            OracleCommand cmd = new OracleCommand(s, _con);
            cmd.Parameters.Add(new OracleParameter("logged", DateTime.Now));
            cmd.Parameters.Add(new OracleParameter("pixels", totalMouseDistance));

            int i = cmd.ExecuteNonQuery();
            
        }


        
        private void DumpProgramData()
        {
            int total = 0;
            
            string s = "insert into tj_programs (id, title, time, idle, keys, starttime, savetime) values (tj_programs_sequence.nextval, :title, :time, :idle, :keys, :starttime, :savetime)";

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
                
                              
                OracleCommand cmd = new OracleCommand(s, _con);
                cmd.Parameters.Add(new OracleParameter("title", key));
                cmd.Parameters.Add(new OracleParameter("time", ts.TotalSeconds));
                cmd.Parameters.Add(new OracleParameter("idle", tmpIdle));
                cmd.Parameters.Add(new OracleParameter("keys", tmpkeycount));
                cmd.Parameters.Add(new OracleParameter("starttime", DateTime.Now));
                cmd.Parameters.Add(new OracleParameter("savetime", DateTime.Now));

                int i = cmd.ExecuteNonQuery();
                total += i;
            }
            
            System.Diagnostics.Debug.WriteLine("Kirjoitettiin: " + total.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DumpProgramData();
            panelProgramData.Visible = !panelProgramData.Visible;
        }

        private void showProgramHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProgramHistory fph = new FormProgramHistory();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TJ_BLOG' table. You can move, or remove it, as needed.
            this.tJ_BLOGTableAdapter.Fill(this.dataSet1.TJ_BLOG);
            tJ_BLOGBindingSource.Position = tJ_BLOGBindingSource.Count - 1;
            _con = new OracleConnection(Properties.Settings.Default.ConnectionString);
            _con.Open();
            oCCUREDDateTimePicker.DataBindings.Clear();
            oCCUREDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("VALUE", tJ_BLOGBindingSource, "OCCURED", true));
            oCCUREDDateTimePicker.DataBindings[0].Format += new ConvertEventHandler(b_Format);

        }



        void b_Format(object sender, ConvertEventArgs e)
        {
            Binding b = sender as Binding;

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
            panelProgramData.Visible = !panelProgramData.Visible;
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
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i,cLASSTextBox.Text.Contains(i.ToString()));                    
                }
            }
        }

    
    
    }
}

 

