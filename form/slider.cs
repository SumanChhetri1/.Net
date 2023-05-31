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
    public partial class slider : Form
    {
        public slider()
        {
            InitializeComponent();
        }

        private void slider_Load(object sender, EventArgs e)
        {
            txtcount.Text = count.ToString();
        }
        private void imgboard_Click(object sender, EventArgs e)
        {

        }
        int count = 0;

        private void btnprev_Click_1(object sender, EventArgs e)
        {
            if (Math.Abs(count) < 4)
            {
                imgboard.Image = imagelist1.Images[Math.Abs(count)];
                count--;
            }
            else
            {
                count = 0;
            }
            txtcount.Text = Math.Abs(count).ToString();
        }

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            if (Math.Abs(count) < 4)
            {
                imgboard.Image = imagelist1.Images[Math.Abs(count)];
                count++;
            }
            else
            {
                count = 0;
            }
            txtcount.Text = Math.Abs(count).ToString();
        }

        private void txtcount_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
