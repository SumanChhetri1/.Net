using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form
{
    public partial class greatest : Form
    {
        public greatest()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            double c = Convert.ToDouble(txt3.Text);
            if (a > b && a > c)
            {
                txt4.Text = a.ToString();
            }
            else if (b > a && b > c)
            {
                txt4.Text = b.ToString();
            }
            else
            {
                txt4.Text = c.ToString();
            }
        }
    }
}
