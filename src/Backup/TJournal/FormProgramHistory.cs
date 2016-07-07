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
    public partial class FormProgramHistory : Form
    {
        public FormProgramHistory()
        {
            InitializeComponent();
        }

        private void tJ_PROGRAMSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tJ_PROGRAMSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormProgramHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TJ_PROGRAMS' table. You can move, or remove it, as needed.
            this.tJ_PROGRAMSTableAdapter.Fill(this.dataSet1.TJ_PROGRAMS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
