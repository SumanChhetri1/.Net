using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace form
{
    public partial class rawmatrial : Form
    {
        DataGridViewButtonColumn coledit = new DataGridViewButtonColumn();
        DataGridViewButtonColumn coldelete = new DataGridViewButtonColumn();
        public rawmatrial()
        {
            InitializeComponent();
        }

        private void rawmatrial_Load(object sender, EventArgs e)
        {
            dgvmaterial.DataSource = getallrecords("HP", "rawmaterialDB", "tblrawmaterial");

            coledit.HeaderText = "Edit";
            coledit.MinimumWidth = 6;
            coledit.Name = "Column1";
            coledit.ReadOnly = true;
            coledit.Text = "Edit";
            coledit.UseColumnTextForButtonValue = true;
            coledit.Width = 125;

            coldelete.HeaderText = "Delete";
            coldelete.MinimumWidth = 6;
            coldelete.Name = "Column2";
            coldelete.ReadOnly = true;
            coldelete.Text = "Delete";
            coldelete.UseColumnTextForButtonValue = true;
            coldelete.Width = 125;


            //add column to grid
            dgvmaterial.Columns.Add(coledit);
            //add column to grid
            dgvmaterial.Columns.Add(coldelete);
        }
        private DataTable getallrecords(string servername, string databasename, string tablename)
        {
            SqlConnection conn = new SqlConnection("server=" + servername + " ;database=" + databasename + " ;integrated security =true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from " + tablename + "");
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            conn.Close();
            return (dt);

        }
        private void databaseinsert()
        {
            SqlConnection conn = new SqlConnection("server=HP ;database=rawmaterialDB ;integrated security =true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblrawmaterial" + "( [Material Name], Email, Price, Date, Address, Quantity)" + "values( @MaterialName, @Email, @Price, @Date, @Address, @Quantity) ");
            cmd.Parameters.AddWithValue("@MaterialName", txtname.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Price", price.Value);
            cmd.Parameters.AddWithValue("@Date", date.Value);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@Quantity", qty.Value);

            cmd.Connection = conn;
            //execute query
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                MessageBox.Show("data saved!");
            else
                MessageBox.Show("data save failed!");

        }
        private void databaseupdate()
        {
            SqlConnection conn = new SqlConnection("server=HP ;database=rawmaterialDB ;integrated security =true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update  tblrawmaterial set [Material Name]=@MaterialName, Email=@Email, Price=@Price, Date=@Date, Address=@Address, Quantity=@Quantity where SNO=@SNO");
            cmd.Parameters.AddWithValue("@MaterialName", txtname.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Price", price.Value);
            cmd.Parameters.AddWithValue("@Date", date.Value);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@Quantity", qty.Value);
            cmd.Parameters.AddWithValue("@SNO", txtsno.Text);


            cmd.Connection = conn;
            //execute query
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                MessageBox.Show("data updated!");
            else
                MessageBox.Show("data update failed!");
        }

       

        private void dgvmaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == coledit.Index)//update
            {
                txtsno.Text = dgvmaterial.Rows[e.RowIndex].Cells["SNO"].Value.ToString();
                txtname.Text = dgvmaterial.Rows[e.RowIndex].Cells["Material Name"].Value.ToString();
                txtemail.Text = dgvmaterial.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                price.Value = Convert.ToInt32(dgvmaterial.Rows[e.RowIndex].Cells["Price"].Value.ToString());
                date.Value = Convert.ToDateTime(dgvmaterial.Rows[e.RowIndex].Cells["Date"].Value.ToString());
                txtaddress.Text = dgvmaterial.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                qty.Text = dgvmaterial.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                //changing button name
                btnadd.Text = "Update";

            }
            else if (e.ColumnIndex == coldelete.Index)//delete
            {
                DialogResult ans = MessageBox.Show("Are you sure to delete", "Confirmation", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection("server=HP ;database=rawmaterialDB ;integrated security =true;");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from  tblrawmaterial where SNO=@SNO");
                    cmd.Parameters.AddWithValue("@SNO", dgvmaterial.Rows[e.RowIndex].Cells["SNO"].Value.ToString());
                    cmd.Connection = conn;
                    //execute query
                    int an = cmd.ExecuteNonQuery();
                    if (an > 0)
                        MessageBox.Show("data deleted!");
                    else
                        MessageBox.Show("data deletion failed!");
                    dgvmaterial.DataSource = getallrecords("HP", "rawmaterialDB", "tblrawmaterial");//refresh dgvtable...
                }

            }



        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (btnadd.Text == "Add")
            {
                databaseinsert();
                dgvmaterial.DataSource = getallrecords("HP", "rawmaterialDB", "tblrawmaterial");
                txtsno.Clear();
                txtname.Clear();
                txtemail.Clear();
                price.Value = 1;
                qty.Text = "";
                date.Value = DateTime.Now;
                txtaddress.Clear();
            }
            else if (btnadd.Text == "Update")
            {
                databaseupdate();
                dgvmaterial.DataSource = getallrecords("HP", "rawmaterialDB", "tblrawmaterial");
            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtsno.Clear();
            txtname.Clear();
            txtemail.Clear();
            price.Value = 1;
            qty.Text = "";
            date.Value = DateTime.Now;
            txtaddress.Clear();

        }

        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            //create the temporary datasource i.e.bindingsource because it can filter
            BindingSource bs = new BindingSource();
            //assign original datasource(i.e)data  to binding source
            bs.DataSource = dgvmaterial.DataSource;
            //now filter the binding source
            bs.Filter = "[Material Name] like'*" + txtsearch.Text + "*'";
            //now assign filtered data in grid
            dgvmaterial.DataSource = bs;
            //clear any selection if any on datagrid
            dgvmaterial.ClearSelection();
        }
    }
}

