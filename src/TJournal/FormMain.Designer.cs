namespace TJournal
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                SaveKeycount();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cONTENTSLabel;
            System.Windows.Forms.Label oCCUREDLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label lINK_TOLabel;
            System.Windows.Forms.Label lOGGEDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextSysTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.computersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonbonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.previousItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showProgramHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPrograms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGroups = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFormToggle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lOGGEDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.lblKeycount = new System.Windows.Forms.Label();
            this.lINK_TOTextBox = new System.Windows.Forms.TextBox();
            this.cONTENTSTextBox = new System.Windows.Forms.TextBox();
            this.tJ_BLOGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tJ_BLOGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mOODComboBox = new System.Windows.Forms.ComboBox();
            this.btnSetOccuredDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oCCUREDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cLASSTextBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblKeyCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblCursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblMousePIxels = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblMouseDistance = new System.Windows.Forms.ToolStripStatusLabel();
            this.tJ_BLOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cONTENTSLabel = new System.Windows.Forms.Label();
            oCCUREDLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            lINK_TOLabel = new System.Windows.Forms.Label();
            lOGGEDLabel = new System.Windows.Forms.Label();
            this.contextSysTray.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_BLOGBindingNavigator)).BeginInit();
            this.tJ_BLOGBindingNavigator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_BLOGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cONTENTSLabel
            // 
            cONTENTSLabel.AutoSize = true;
            cONTENTSLabel.Location = new System.Drawing.Point(15, 64);
            cONTENTSLabel.Name = "cONTENTSLabel";
            cONTENTSLabel.Size = new System.Drawing.Size(31, 13);
            cONTENTSLabel.TabIndex = 16;
            cONTENTSLabel.Text = "Entry";
            // 
            // oCCUREDLabel
            // 
            oCCUREDLabel.AutoSize = true;
            oCCUREDLabel.Location = new System.Drawing.Point(353, 39);
            oCCUREDLabel.Name = "oCCUREDLabel";
            oCCUREDLabel.Size = new System.Drawing.Size(48, 13);
            oCCUREDLabel.TabIndex = 21;
            oCCUREDLabel.Text = "Occured";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(32, 35);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(14, 13);
            iDLabel.TabIndex = 12;
            iDLabel.Text = "#";
            // 
            // lINK_TOLabel
            // 
            lINK_TOLabel.AutoSize = true;
            lINK_TOLabel.Location = new System.Drawing.Point(9, 235);
            lINK_TOLabel.Name = "lINK_TOLabel";
            lINK_TOLabel.Size = new System.Drawing.Size(69, 13);
            lINK_TOLabel.TabIndex = 18;
            lINK_TOLabel.Text = "Autolinked to";
            // 
            // lOGGEDLabel
            // 
            lOGGEDLabel.AutoSize = true;
            lOGGEDLabel.Location = new System.Drawing.Point(106, 39);
            lOGGEDLabel.Name = "lOGGEDLabel";
            lOGGEDLabel.Size = new System.Drawing.Size(43, 13);
            lOGGEDLabel.TabIndex = 14;
            lOGGEDLabel.Text = "Logged";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextSysTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TJournal";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextSysTray
            // 
            this.contextSysTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computersToolStripMenuItem,
            this.openMainWindowToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextSysTray.Name = "contextSysTray";
            this.contextSysTray.Size = new System.Drawing.Size(179, 70);
            // 
            // computersToolStripMenuItem
            // 
            this.computersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bonbonToolStripMenuItem});
            this.computersToolStripMenuItem.Name = "computersToolStripMenuItem";
            this.computersToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.computersToolStripMenuItem.Text = "Computers";
            this.computersToolStripMenuItem.Visible = false;
            // 
            // bonbonToolStripMenuItem
            // 
            this.bonbonToolStripMenuItem.Name = "bonbonToolStripMenuItem";
            this.bonbonToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.bonbonToolStripMenuItem.Text = "Bonbon";
            this.bonbonToolStripMenuItem.Click += new System.EventHandler(this.bonbonToolStripMenuItem_Click);
            // 
            // openMainWindowToolStripMenuItem
            // 
            this.openMainWindowToolStripMenuItem.Name = "openMainWindowToolStripMenuItem";
            this.openMainWindowToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openMainWindowToolStripMenuItem.Text = "Open main window";
            this.openMainWindowToolStripMenuItem.Click += new System.EventHandler(this.openMainWindowToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.quitToolStripMenuItem.Text = "Exit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.moodToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.previousItemToolStripMenuItem,
            this.moveNextToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // previousItemToolStripMenuItem
            // 
            this.previousItemToolStripMenuItem.Name = "previousItemToolStripMenuItem";
            this.previousItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.previousItemToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.previousItemToolStripMenuItem.Text = "Previous item";
            this.previousItemToolStripMenuItem.Click += new System.EventHandler(this.previousItemToolStripMenuItem_Click);
            // 
            // moveNextToolStripMenuItem
            // 
            this.moveNextToolStripMenuItem.Name = "moveNextToolStripMenuItem";
            this.moveNextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.moveNextToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.moveNextToolStripMenuItem.Text = "Next item";
            this.moveNextToolStripMenuItem.Click += new System.EventHandler(this.moveNextToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.closeWindowToolStripMenuItem.Text = "Close window    Alt+F4";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerEditorToolStripMenuItem,
            this.productManagementToolStripMenuItem,
            this.toolStripSeparator3,
            this.showProgramHistoryToolStripMenuItem,
            this.browseItemsToolStripMenuItem,
            this.insertTagsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // computerEditorToolStripMenuItem
            // 
            this.computerEditorToolStripMenuItem.Name = "computerEditorToolStripMenuItem";
            this.computerEditorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.computerEditorToolStripMenuItem.Text = "Computer editor";
            this.computerEditorToolStripMenuItem.Visible = false;
            this.computerEditorToolStripMenuItem.Click += new System.EventHandler(this.computerEditorToolStripMenuItem_Click);
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            this.productManagementToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.productManagementToolStripMenuItem.Text = "Product management";
            this.productManagementToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // showProgramHistoryToolStripMenuItem
            // 
            this.showProgramHistoryToolStripMenuItem.Name = "showProgramHistoryToolStripMenuItem";
            this.showProgramHistoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showProgramHistoryToolStripMenuItem.Text = "Show program history";
            this.showProgramHistoryToolStripMenuItem.Click += new System.EventHandler(this.showProgramHistoryToolStripMenuItem_Click);
            // 
            // browseItemsToolStripMenuItem
            // 
            this.browseItemsToolStripMenuItem.Name = "browseItemsToolStripMenuItem";
            this.browseItemsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.browseItemsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.browseItemsToolStripMenuItem.Text = "Browse items";
            this.browseItemsToolStripMenuItem.Visible = false;
            this.browseItemsToolStripMenuItem.Click += new System.EventHandler(this.browseItemsToolStripMenuItem_Click);
            // 
            // insertTagsToolStripMenuItem
            // 
            this.insertTagsToolStripMenuItem.Name = "insertTagsToolStripMenuItem";
            this.insertTagsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.insertTagsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.insertTagsToolStripMenuItem.Text = "Insert tags";
            this.insertTagsToolStripMenuItem.Visible = false;
            // 
            // moodToolStripMenuItem
            // 
            this.moodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.dToolStripMenuItem});
            this.moodToolStripMenuItem.Name = "moodToolStripMenuItem";
            this.moodToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.moodToolStripMenuItem.Text = "Mood";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.oToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oToolStripMenuItem.Text = "XO";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.SetMoodToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = ":(";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SetMoodToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = ":|";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.SetMoodToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = ":)";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.SetMoodToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.dToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dToolStripMenuItem.Text = "XD";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.SetMoodToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutHelp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuAboutHelp
            // 
            this.mnuAboutHelp.Name = "mnuAboutHelp";
            this.mnuAboutHelp.Size = new System.Drawing.Size(107, 22);
            this.mnuAboutHelp.Text = "About";
            this.mnuAboutHelp.Click += new System.EventHandler(this.mnuAboutHelp_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tJournalToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Visible = false;
            // 
            // tJournalToolStripMenuItem
            // 
            this.tJournalToolStripMenuItem.Name = "tJournalToolStripMenuItem";
            this.tJournalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.tJournalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tJournalToolStripMenuItem.Text = "tJournal";
            this.tJournalToolStripMenuItem.Click += new System.EventHandler(this.tJournalToolStripMenuItem_Click);
            // 
            // lvPrograms
            // 
            this.lvPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPrograms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPrograms.Location = new System.Drawing.Point(13, 6);
            this.lvPrograms.Name = "lvPrograms";
            this.lvPrograms.Size = new System.Drawing.Size(930, 238);
            this.lvPrograms.TabIndex = 3;
            this.lvPrograms.UseCompatibleStateImageBehavior = false;
            this.lvPrograms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Program";
            this.columnHeader1.Width = 726;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Keys";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Idletime";
            // 
            // lvGroups
            // 
            this.lvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvGroups.Location = new System.Drawing.Point(9, 28);
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(686, 181);
            this.lvGroups.TabIndex = 7;
            this.lvGroups.UseCompatibleStateImageBehavior = false;
            this.lvGroups.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Program title";
            this.columnHeader9.Width = 727;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Time";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Keys";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Idle";
            // 
            // btnFormToggle
            // 
            this.btnFormToggle.Location = new System.Drawing.Point(723, 350);
            this.btnFormToggle.Name = "btnFormToggle";
            this.btnFormToggle.Size = new System.Drawing.Size(20, 23);
            this.btnFormToggle.TabIndex = 20;
            this.btnFormToggle.Text = "+";
            this.btnFormToggle.UseVisualStyleBackColor = true;
            this.btnFormToggle.Visible = false;
            this.btnFormToggle.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Windows ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lOGGEDDateTimePicker);
            this.tabPage1.Controls.Add(lOGGEDLabel);
            this.tabPage1.Controls.Add(this.uSERNAMETextBox);
            this.tabPage1.Controls.Add(this.iDTextBox);
            this.tabPage1.Controls.Add(this.lblKeycount);
            this.tabPage1.Controls.Add(this.lINK_TOTextBox);
            this.tabPage1.Controls.Add(this.cONTENTSTextBox);
            this.tabPage1.Controls.Add(this.tJ_BLOGBindingNavigator);
            this.tabPage1.Controls.Add(this.mOODComboBox);
            this.tabPage1.Controls.Add(lINK_TOLabel);
            this.tabPage1.Controls.Add(this.btnSetOccuredDate);
            this.tabPage1.Controls.Add(iDLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(oCCUREDLabel);
            this.tabPage1.Controls.Add(this.oCCUREDDateTimePicker);
            this.tabPage1.Controls.Add(cONTENTSLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Journal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mood";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lOGGEDDateTimePicker
            // 
            this.lOGGEDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tJ_BLOGBindingSource, "LOGGED", true));
            this.lOGGEDDateTimePicker.Location = new System.Drawing.Point(161, 35);
            this.lOGGEDDateTimePicker.Name = "lOGGEDDateTimePicker";
            this.lOGGEDDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.lOGGEDDateTimePicker.TabIndex = 15;
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tJ_BLOGBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(656, 35);
            this.uSERNAMETextBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.ReadOnly = true;
            this.uSERNAMETextBox.Size = new System.Drawing.Size(182, 20);
            this.uSERNAMETextBox.TabIndex = 28;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tJ_BLOGBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(52, 35);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(48, 20);
            this.iDTextBox.TabIndex = 13;
            // 
            // lblKeycount
            // 
            this.lblKeycount.AutoSize = true;
            this.lblKeycount.Location = new System.Drawing.Point(335, 265);
            this.lblKeycount.Name = "lblKeycount";
            this.lblKeycount.Size = new System.Drawing.Size(35, 13);
            this.lblKeycount.TabIndex = 4;
            this.lblKeycount.Text = "label1";
            this.lblKeycount.Visible = false;
            // 
            // lINK_TOTextBox
            // 
            this.lINK_TOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tJ_BLOGBindingSource, "LINK_TO", true));
            this.lINK_TOTextBox.Location = new System.Drawing.Point(88, 232);
            this.lINK_TOTextBox.Name = "lINK_TOTextBox";
            this.lINK_TOTextBox.Size = new System.Drawing.Size(750, 20);
            this.lINK_TOTextBox.TabIndex = 19;
            // 
            // cONTENTSTextBox
            // 
            this.cONTENTSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tJ_BLOGBindingSource, "CONTENTS", true));
            this.cONTENTSTextBox.Location = new System.Drawing.Point(51, 61);
            this.cONTENTSTextBox.Multiline = true;
            this.cONTENTSTextBox.Name = "cONTENTSTextBox";
            this.cONTENTSTextBox.Size = new System.Drawing.Size(787, 165);
            this.cONTENTSTextBox.TabIndex = 17;
            this.cONTENTSTextBox.TextChanged += new System.EventHandler(this.cONTENTSTextBox_TextChanged);
            this.cONTENTSTextBox.DoubleClick += new System.EventHandler(this.cONTENTSTextBox_DoubleClick);
            // 
            // tJ_BLOGBindingNavigator
            // 
            this.tJ_BLOGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tJ_BLOGBindingNavigator.BindingSource = this.tJ_BLOGBindingSource;
            this.tJ_BLOGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tJ_BLOGBindingNavigator.DeleteItem = null;
            this.tJ_BLOGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tJ_BLOGBindingNavigatorSaveItem});
            this.tJ_BLOGBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tJ_BLOGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tJ_BLOGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tJ_BLOGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tJ_BLOGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tJ_BLOGBindingNavigator.Name = "tJ_BLOGBindingNavigator";
            this.tJ_BLOGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tJ_BLOGBindingNavigator.Size = new System.Drawing.Size(837, 25);
            this.tJ_BLOGBindingNavigator.TabIndex = 11;
            this.tJ_BLOGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.previousItemToolStripMenuItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.moveNextToolStripMenuItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tJ_BLOGBindingNavigatorSaveItem
            // 
            this.tJ_BLOGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tJ_BLOGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tJ_BLOGBindingNavigatorSaveItem.Image")));
            this.tJ_BLOGBindingNavigatorSaveItem.Name = "tJ_BLOGBindingNavigatorSaveItem";
            this.tJ_BLOGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tJ_BLOGBindingNavigatorSaveItem.Text = "Save Data";
            this.tJ_BLOGBindingNavigatorSaveItem.Click += new System.EventHandler(this.tJ_BLOGBindingNavigatorSaveItem_Click);
            // 
            // mOODComboBox
            // 
            this.mOODComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tJ_BLOGBindingSource, "MOOD", true));
            this.mOODComboBox.FormattingEnabled = true;
            this.mOODComboBox.Items.AddRange(new object[] {
            "XO",
            ":(",
            ":|",
            ":)",
            "XD"});
            this.mOODComboBox.Location = new System.Drawing.Point(88, 257);
            this.mOODComboBox.Name = "mOODComboBox";
            this.mOODComboBox.Size = new System.Drawing.Size(58, 21);
            this.mOODComboBox.TabIndex = 27;
            this.mOODComboBox.TextChanged += new System.EventHandler(this.mOODComboBox_TextChanged);
            // 
            // btnSetOccuredDate
            // 
            this.btnSetOccuredDate.Location = new System.Drawing.Point(600, 34);
            this.btnSetOccuredDate.Name = "btnSetOccuredDate";
            this.btnSetOccuredDate.Size = new System.Drawing.Size(75, 23);
            this.btnSetOccuredDate.TabIndex = 23;
            this.btnSetOccuredDate.Text = "Set occured date";
            this.btnSetOccuredDate.UseVisualStyleBackColor = true;
            this.btnSetOccuredDate.Click += new System.EventHandler(this.btnSetOccuredDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total keycount:";
            this.label1.Visible = false;
            // 
            // oCCUREDDateTimePicker
            // 
            this.oCCUREDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tJ_BLOGBindingSource, "OCCURED", true));
            this.oCCUREDDateTimePicker.Location = new System.Drawing.Point(407, 35);
            this.oCCUREDDateTimePicker.Name = "oCCUREDDateTimePicker";
            this.oCCUREDDateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.oCCUREDDateTimePicker.TabIndex = 22;
            // 
            // cLASSTextBox
            // 
            this.cLASSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tJ_BLOGBindingSource, "CLASS", true));
            this.cLASSTextBox.Location = new System.Drawing.Point(705, 455);
            this.cLASSTextBox.Name = "cLASSTextBox";
            this.cLASSTextBox.ReadOnly = true;
            this.cLASSTextBox.Size = new System.Drawing.Size(107, 20);
            this.cLASSTextBox.TabIndex = 25;
            this.cLASSTextBox.Visible = false;
            this.cLASSTextBox.TextChanged += new System.EventHandler(this.cLASSTextBox_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Generic",
            "Software",
            "Work",
            "Legendary!",
            "Trip"});
            this.checkedListBox1.Location = new System.Drawing.Point(514, 382);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(107, 139);
            this.checkedListBox1.TabIndex = 26;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 330);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(843, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time spent in programs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(843, 304);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvGroups);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(835, 278);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Applications";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvPrograms);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(835, 278);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Windows";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslblKeyCount,
            this.toolStripStatusLabel2,
            this.tslblCursor,
            this.toolStripStatusLabel3,
            this.tslblMousePIxels,
            this.toolStripStatusLabel4,
            this.tslblMouseDistance});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "Total keycount:";
            // 
            // tslblKeyCount
            // 
            this.tslblKeyCount.AutoSize = false;
            this.tslblKeyCount.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslblKeyCount.Name = "tslblKeyCount";
            this.tslblKeyCount.Size = new System.Drawing.Size(100, 17);
            this.tslblKeyCount.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel2.Text = "Session cursor: ";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslblCursor
            // 
            this.tslblCursor.AutoSize = false;
            this.tslblCursor.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslblCursor.Name = "tslblCursor";
            this.tslblCursor.Size = new System.Drawing.Size(100, 17);
            this.tslblCursor.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel3.Text = "Session pixels:";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslblMousePIxels
            // 
            this.tslblMousePIxels.AutoSize = false;
            this.tslblMousePIxels.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslblMousePIxels.Name = "tslblMousePIxels";
            this.tslblMousePIxels.Size = new System.Drawing.Size(100, 17);
            this.tslblMousePIxels.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "Mouse distance:";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslblMouseDistance
            // 
            this.tslblMouseDistance.AutoSize = false;
            this.tslblMouseDistance.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.tslblMouseDistance.Name = "tslblMouseDistance";
            this.tslblMouseDistance.Size = new System.Drawing.Size(100, 17);
            this.tslblMouseDistance.Text = "toolStripStatusLabel5";
            // 
            // tJ_BLOGBindingSource
            // 
            this.tJ_BLOGBindingSource.DataSource = typeof(TJournal.tj_blog);
            this.tJ_BLOGBindingSource.CurrentItemChanged += new System.EventHandler(this.tJ_BLOGBindingSource_CurrentItemChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(854, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cLASSTextBox);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnFormToggle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "tJournaLite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextSysTray.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_BLOGBindingNavigator)).EndInit();
            this.tJ_BLOGBindingNavigator.ResumeLayout(false);
            this.tJ_BLOGBindingNavigator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_BLOGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextSysTray;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem openMainWindowToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView lvPrograms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvGroups;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.BindingSource tJ_BLOGBindingSource;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnFormToggle;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProgramHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonbonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem moveNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutHelp;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker lOGGEDDateTimePicker;
        private System.Windows.Forms.Label lblKeycount;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox lINK_TOTextBox;
        private System.Windows.Forms.TextBox cLASSTextBox;
        private System.Windows.Forms.TextBox cONTENTSTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.BindingNavigator tJ_BLOGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tJ_BLOGBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox mOODComboBox;
        private System.Windows.Forms.Button btnSetOccuredDate;
        private System.Windows.Forms.DateTimePicker oCCUREDDateTimePicker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslblKeyCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslblCursor;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslblMousePIxels;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tslblMouseDistance;
    }
}

