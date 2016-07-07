using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TJournal
{
    public partial class FormBrowseItems : Form
    {
        public FormBrowseItems()
        {
            InitializeComponent();
        }

        private void tJ_BLOGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tJ_BLOGBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormBrowseItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tJournalDataSet.TJ_BLOG' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet1.TJ_BLOG' table. You can move, or remove it, as needed.
            
        }
    }
}
