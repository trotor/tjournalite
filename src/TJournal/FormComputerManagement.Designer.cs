namespace TJournal
{
    partial class FormComputerManagement
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
            this.tJ_PROGRAMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tJ_COMPUTERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tJ_COMPUTERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.ORDERNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.separator = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_PROGRAMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_COMPUTERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_COMPUTERSDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tJournalDataSet
            // 
            // 
            // tJ_PROGRAMSBindingSource
            // 
            this.tJ_PROGRAMSBindingSource.DataMember = "TJ_PROGRAMS";
            // 
            // tJ_PROGRAMSTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
            // 
            // tJ_COMPUTERSTableAdapter
            // 
            // 
            // tJ_COMPUTERSBindingSource
            // 
            this.tJ_COMPUTERSBindingSource.DataMember = "TJ_COMPUTERS";
            // 
            // tJ_COMPUTERSDataGridView
            // 
            this.tJ_COMPUTERSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tJ_COMPUTERSDataGridView.AutoGenerateColumns = false;
            this.tJ_COMPUTERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tJ_COMPUTERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ORDERNUM,
            this.separator});
            this.tJ_COMPUTERSDataGridView.DataSource = this.tJ_COMPUTERSBindingSource;
            this.tJ_COMPUTERSDataGridView.Location = new System.Drawing.Point(12, 28);
            this.tJ_COMPUTERSDataGridView.Name = "tJ_COMPUTERSDataGridView";
            this.tJ_COMPUTERSDataGridView.Size = new System.Drawing.Size(752, 324);
            this.tJ_COMPUTERSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COMPUTERID";
            this.dataGridViewTextBoxColumn2.HeaderText = "COMPUTERID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ADDRESS";
            this.dataGridViewTextBoxColumn3.HeaderText = "ADDRESS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COMMENTS";
            this.dataGridViewTextBoxColumn4.HeaderText = "COMMENTS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DESCRIPTION";
            this.dataGridViewTextBoxColumn5.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(689, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ORDERNUM
            // 
            this.ORDERNUM.DataPropertyName = "ORDERNUM";
            this.ORDERNUM.HeaderText = "ORDERNUM";
            this.ORDERNUM.Name = "ORDERNUM";
            // 
            // separator
            // 
            this.separator.DataPropertyName = "separator";
            this.separator.HeaderText = "separator";
            this.separator.Name = "separator";
            // 
            // FormComputerManagement
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(776, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tJ_COMPUTERSDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormComputerManagement";
            this.Text = "FormComputerManagement";
            this.Load += new System.EventHandler(this.FormComputerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tJ_PROGRAMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_COMPUTERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_COMPUTERSDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tJ_PROGRAMSBindingSource;
        private System.Windows.Forms.BindingSource tJ_COMPUTERSBindingSource;
        private System.Windows.Forms.DataGridView tJ_COMPUTERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERNUM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn separator;
    }
}