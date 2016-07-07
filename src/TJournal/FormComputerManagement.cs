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
    public partial class FormComputerManagement : Form
    {
        public FormComputerManagement()
        {
            InitializeComponent();
        }

        private void tJ_PROGRAMSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAll();

        }

        private void SaveAll()
        {
            this.Validate();
            this.tJ_COMPUTERSBindingSource.EndEdit();
        }

        private void FormComputerManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tJournalDataSet.TJ_COMPUTERS' table. You can move, or remove it, as needed.

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAll();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
