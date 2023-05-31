using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace form
{
    public partial class billing : Form
    {
        private Font verdana10Font;
        private StreamReader reader;
        public billing()
        {
            InitializeComponent();
        }

        private void qty_ValueChanged(object sender, EventArgs e)
        {
            qty.Text = "";
        }
        private void rate_Enter(object sender, EventArgs e)
        {
            rate.Text = "";
        }
        private string getbillnumber()
        {
            string str = DateTime.Now.ToString("ddMMyyyyhhmmss");
            return str;
        }

        private void billing_Load(object sender, EventArgs e)
        {
            txtbillno.Text = getbillnumber();
        }
        private void amount_Enter(object sender, EventArgs e)
        {
            amount.Value = Convert.ToDecimal(qty.Value) * Convert.ToDecimal(rate.Value);
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            dgvlist.Rows.Add(new string[] { (dgvlist.Rows.Count+1).ToString(),
            txtitemname.Text,qty.Value.ToString(),rate.Value.ToString(),
            amount.Value.ToString()});
            //clearing box
            txtitemname.Text = "";// txtiteamname.clear();
            qty.Text = "";
            rate.Text = "";
            amount.Text = "";
            //set curser on iteam
            txtitemname.Focus();
            txttotal.Text = gettotal().ToString();

        }
        decimal gettotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvlist.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgvlist.Rows[i].Cells["colamount"].Value);
            }
            return total;
        }

        private void txtnetamount_Enter(object sender, EventArgs e)
        {
            if (txttotal.Text == "" || txtdiscount.Text == "")
            {

            }
            else
            {
                decimal totalamount = Convert.ToDecimal(txttotal.Text);
                decimal discount = Convert.ToDecimal(txtdiscount.Text);
                txtnetamount.Text = (totalamount - ((totalamount * discount) / 100)).ToString();

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dgvlist.Rows.Clear();
            txttotal.Clear();
            txtname.Clear();
            txtdiscount.Clear();
            txtnetamount.Clear();
        }

        
        private void SetBillHeader()
        {
            mybill.Text = "";
            mybill.Text = "Asian Suppliers Company\nBharatpur,Chitwan\nph:056-55566\n";
            mybill.Text += "Bill#:" + txtbillno.Text + "\n Customer Name:"+txtname.Text+"\n";
            mybill.Text += "Date:" + dateTimePicker1.Text + "\n\n";
            mybill.Text += "Sno\tItem Name\t\tQty\tRate\tAmount\n";
            

        }
        private void SetBillFooter()
        {
            mybill.Text += "thank you for visiting us!!";

        }

        private void SetBillContent()
        {
            for (int i = 0; i < dgvlist.Rows.Count; i++)
            {
                mybill.Text += dgvlist.Rows[i].Cells["colsn"].Value.ToString() + "\t" + dgvlist.Rows[i].Cells["colitemname"].Value.ToString() + "\t\t" + dgvlist.Rows[i].Cells["colqty"].Value.ToString() + "\t" + dgvlist.Rows[i].Cells["colrate"].Value.ToString() + "\t" + dgvlist.Rows[i].Cells["colamount"].Value.ToString() + "\n";

            }
        }
        
        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            //Get the Graphics object  
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader  
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position  
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //Draw text  
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Move to next line  
                count++;
            }
            //If PrintPageEventArgs has more pages to print  
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            SetBillHeader();
            SetBillContent();
            SetBillFooter();
            File.WriteAllText(txtbillno.Text + ".txt", mybill.Text);


            //print
            string filename = txtbillno.Text + ".txt";
            //Create a StreamReader object  
            reader = new StreamReader(filename);
            //Create a Verdana font with size 10  
            verdana10Font = new Font("Verdana", 10);
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            //Call Print Method  
            pd.Print();
            //Close the reader  
            if (reader != null)
                reader.Close();
        }

        private void mybill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
