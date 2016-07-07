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
    public partial class Form_ProductManagement : Form
    {
        public Form_ProductManagement()
        {
            InitializeComponent();
        }

        private void tT_PRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAll();

        }

        private void SaveAll()
        {
            this.Validate();
        }

        private void Form_ProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tJournalDataSet.TT_PRODUCTS' table. You can move, or remove it, as needed.
            this.tT_PRODUCTSTableAdapter.Fill(this.tJournalDataSet.TT_PRODUCTS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAll();
        }
    }
}
