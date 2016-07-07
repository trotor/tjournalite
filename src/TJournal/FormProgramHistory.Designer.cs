namespace TJournal
{
    partial class FormProgramHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgramHistory));
            this.tJ_PROGRAMSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tJ_PROGRAMSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tJ_PROGRAMSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tJ_PROGRAMSDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tjournalEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tjprogramsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_PROGRAMSBindingNavigator)).BeginInit();
            this.tJ_PROGRAMSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_PROGRAMSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_PROGRAMSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjournalEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjprogramsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tJ_PROGRAMSBindingNavigator
            // 
            this.tJ_PROGRAMSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tJ_PROGRAMSBindingNavigator.BindingSource = this.tJ_PROGRAMSBindingSource1;
            this.tJ_PROGRAMSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tJ_PROGRAMSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tJ_PROGRAMSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tJ_PROGRAMSBindingNavigatorSaveItem});
            this.tJ_PROGRAMSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tJ_PROGRAMSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tJ_PROGRAMSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tJ_PROGRAMSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tJ_PROGRAMSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tJ_PROGRAMSBindingNavigator.Name = "tJ_PROGRAMSBindingNavigator";
            this.tJ_PROGRAMSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tJ_PROGRAMSBindingNavigator.Size = new System.Drawing.Size(1121, 25);
            this.tJ_PROGRAMSBindingNavigator.TabIndex = 0;
            this.tJ_PROGRAMSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tJ_PROGRAMSBindingSource1
            // 
            this.tJ_PROGRAMSBindingSource1.DataMember = "TJ_PROGRAMS";
            // 
            // tJournalDataSet
            // 
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // tJ_PROGRAMSBindingNavigatorSaveItem
            // 
            this.tJ_PROGRAMSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tJ_PROGRAMSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tJ_PROGRAMSBindingNavigatorSaveItem.Image")));
            this.tJ_PROGRAMSBindingNavigatorSaveItem.Name = "tJ_PROGRAMSBindingNavigatorSaveItem";
            this.tJ_PROGRAMSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tJ_PROGRAMSBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // tJ_PROGRAMSDataGridView
            // 
            this.tJ_PROGRAMSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tJ_PROGRAMSDataGridView.AutoGenerateColumns = false;
            this.tJ_PROGRAMSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tJ_PROGRAMSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.idleDataGridViewTextBoxColumn,
            this.keysDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.savetimeDataGridViewTextBoxColumn});
            this.tJ_PROGRAMSDataGridView.DataSource = this.tjprogramsBindingSource;
            this.tJ_PROGRAMSDataGridView.Location = new System.Drawing.Point(12, 37);
            this.tJ_PROGRAMSDataGridView.Name = "tJ_PROGRAMSDataGridView";
            this.tJ_PROGRAMSDataGridView.Size = new System.Drawing.Size(1097, 439);
            this.tJ_PROGRAMSDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(1034, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tJ_PROGRAMSTableAdapter1
            // 
            // 
            // tableAdapterManager1
            // 
            // 
            // tjournalEntitiesBindingSource
            // 
            this.tjournalEntitiesBindingSource.DataSource = typeof(TJournal.tjournalEntities);
            // 
            // tjprogramsBindingSource
            // 
            this.tjprogramsBindingSource.DataSource = typeof(TJournal.tj_programs);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // idleDataGridViewTextBoxColumn
            // 
            this.idleDataGridViewTextBoxColumn.DataPropertyName = "idle";
            this.idleDataGridViewTextBoxColumn.HeaderText = "idle";
            this.idleDataGridViewTextBoxColumn.Name = "idleDataGridViewTextBoxColumn";
            // 
            // keysDataGridViewTextBoxColumn
            // 
            this.keysDataGridViewTextBoxColumn.DataPropertyName = "keys";
            this.keysDataGridViewTextBoxColumn.HeaderText = "keys";
            this.keysDataGridViewTextBoxColumn.Name = "keysDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "starttime";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "starttime";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // savetimeDataGridViewTextBoxColumn
            // 
            this.savetimeDataGridViewTextBoxColumn.DataPropertyName = "savetime";
            this.savetimeDataGridViewTextBoxColumn.HeaderText = "savetime";
            this.savetimeDataGridViewTextBoxColumn.Name = "savetimeDataGridViewTextBoxColumn";
            // 
            // FormProgramHistory
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1121, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tJ_PROGRAMSDataGridView);
            this.Controls.Add(this.tJ_PROGRAMSBindingNavigator);
            this.Name = "FormProgramHistory";
            this.Text = "FormProgramHistory";
            this.Load += new System.EventHandler(this.FormProgramHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tJ_PROGRAMSBindingNavigator)).EndInit();
            this.tJ_PROGRAMSBindingNavigator.ResumeLayout(false);
            this.tJ_PROGRAMSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_PROGRAMSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_PROGRAMSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjournalEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjprogramsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator tJ_PROGRAMSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tJ_PROGRAMSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tJ_PROGRAMSDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tJ_PROGRAMSBindingSource1;
        private System.Windows.Forms.BindingSource tjournalEntitiesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tjprogramsBindingSource;
    }
}