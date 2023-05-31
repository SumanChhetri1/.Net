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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtmemory.Text=txt1.Text;
            txt1.Text = "";
            txtoperator.Text = "+";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtmemory.Text = txt1.Text;
            txt1.Text = "";
            txtoperator.Text = "-";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "7";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "8";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "9";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            txtmemory.Text = txt1.Text;
            txt1.Text = "";
            txtoperator.Text = "*";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "0";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if(txt1.Text.Contains("."))
            {

            }
            else
            {
                txt1.Text = txt1.Text + ".";
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            txtmemory.Text = txt1.Text;
            txt1.Text = "";
            txtoperator.Text = "/";
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if(txtoperator.Text=="+")
            {
                txt1.Text = (Convert.ToDecimal(txtmemory.Text) + Convert.ToDecimal(txt1.Text)).ToString();
            }
            else if (txtoperator.Text == "-")
            {
                txt1.Text = (Convert.ToDecimal(txtmemory.Text) - Convert.ToDecimal(txt1.Text)).ToString();
            }
            else if (txtoperator.Text == "*")
            {
                txt1.Text = (Convert.ToDecimal(txtmemory.Text) * Convert.ToDecimal(txt1.Text)).ToString();
            }
            else if (txtoperator.Text == "/")
            {
                txt1.Text = (Convert.ToDecimal(txtmemory.Text) / Convert.ToDecimal(txt1.Text)).ToString();
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txtoperator.Text = "";
            txtmemory.Text = "";
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if(txt1.Text.Length>0)
            {
                txt1.Text = txt1.Text.Substring(0,txt1.Text.Length-1);
            }
            if (txt1.Text.Length == 0)
            {
                txt1.Text = "0";
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
