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
    public partial class imageslider : Form
    {
        public imageslider()
        {
            InitializeComponent();
        }

        private void imageslider_Load(object sender, EventArgs e)
        {
            imgboard.Load(@"D:\BCA\dotnet\form\pictures\img(1).JPG");
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (txtcount.Text == "7")

            {
                txtcount.Text = "0";
            }
            txtcount.Text = (Convert.ToInt32(txtcount.Text) + 1).ToString();
            imgboard.Load(@"D:\BCA\dotnet\form\pictures\img("+txtcount.Text+").JPG");
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (txtcount.Text == "1")

            {
                txtcount.Text = "8";
            }
            txtcount.Text = (Convert.ToInt32(txtcount.Text) - 1).ToString();
            imgboard.Load(@"D:\BCA\dotnet\form\pictures\img(" + txtcount.Text + ").JPG");
        }
    }
}
