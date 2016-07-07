using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Namu
{
    public partial class FormSplashInformer : Form
    {
        
        public FormSplashInformer(string caption, string text, int interval)
        {                            
            InitializeComponent();
            timer1.Interval = interval;
            timer2.Interval = 60;
            this.Text = caption;
            label1.Text = text;
            this.Opacity = 1.0;
            this.Width = label1.Width + label1.Left;
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            double amnt = 0.06;
            if (this.Opacity < amnt)
            {
                timer2.Stop();
                
                this.Close();
            }            
            this.Opacity -= amnt;
            Application.DoEvents();
        }


    }
}
