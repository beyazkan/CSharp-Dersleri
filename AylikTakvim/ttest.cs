using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AylikTakvim
{
    public partial class ttest : Form
    {
        DateTime dt = DateTime.Now;
        public ttest()
        {
            InitializeComponent();
            yenile();
        }

        private void yenile()
        {
            flowLayoutPanel1.Controls.Clear();

            lblAy.Text = dt.ToString("MMMM");
            flowLayoutPanel1.SuspendLayout();
           int days = DateTime.DaysInMonth(dt.Year, dt.Month);
            for (int i = 0; i < days; i++)
            {
                flowLayoutPanel1.Controls.Add( new trh_gun(i+1) );
            }
            flowLayoutPanel1.ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dt= dt.AddMonths(1);
            yenile();

        }
    }
}
