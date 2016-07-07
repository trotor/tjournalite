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
        private tjournalEntities entities;
        public FormProgramHistory(tjournalEntities en)
        {
            InitializeComponent();
            entities = en;
        }

        
        private void FormProgramHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tJournalDataSet.TJ_PROGRAMS' table. You can move, or remove it, as needed.
            //this.tJ_PROGRAMSTableAdapter1.Fill(this.tJournalDataSet.TJ_PROGRAMS);
            
            // TODO: This line of code loads data into the 'dataSet1.TJ_PROGRAMS' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
