using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TJournal
{
    public partial class FormTags : Form
    {
        private SqlConnection _con = null;

        private string _tag = "";

        public string Tags { get { return _tag; } }


        public FormTags(SqlConnection con, string tagstring)
        {
            InitializeComponent();
            _con = con;
            _tag = tagstring;

            
            string[] tagit = _tag.Split(new char[]{'#'});


            string sql = "select tag from tt_tags order by tag";
            SqlCommand cmd = new SqlCommand(sql, _con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string currenttag = rdr["tag"].ToString();
                bool valittu = tagit.Contains(currenttag);
                checkedListBox1.Items.Add(currenttag,valittu);
            }
            rdr.Close();
        }



        private void FormTags_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tJournalDataSet.TT_TAGS' table. You can move, or remove it, as needed.
            this.tT_TAGSTableAdapter.Fill(this.tJournalDataSet.TT_TAGS);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tag = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if (_tag.Length > 0) { _tag += "#"; }

                _tag += checkedListBox1.CheckedItems[i].ToString() ;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
