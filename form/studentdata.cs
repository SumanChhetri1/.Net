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
    public partial class s : Form
    {
        DataGridViewButtonColumn coledit = new DataGridViewButtonColumn();
        DataGridViewButtonColumn coldelete = new DataGridViewButtonColumn();
        public s()
        {
            InitializeComponent();
        }

        private void studentdata_Load(object sender, EventArgs e)
        {
            dgvstudent.DataSource = getallrecords("HP", "studentDB", "tblstudents");

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
            dgvstudent.Columns.Add(coledit);
            //add column to grid
            dgvstudent.Columns.Add(coldelete);


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
            SqlConnection conn = new SqlConnection("server=HP ;database=studentDB ;integrated security =true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblstudents" + "(Name, Email, Age, DOB, Address, Gender)" + "values(@Name, @Email, @Age, @DOB, @Address, @Gender) ");
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Age", age.Text);
            cmd.Parameters.AddWithValue("@DOB", dob.Value);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@Gender", gender.Text);

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
            SqlConnection conn = new SqlConnection("server=HP ;database=studentDB ;integrated security =true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update  tblstudents set Name=@Name, Email=@Email, Age=@Age, DOB=@DOB, Address=@Address, Gender=@Gender where sid=@sid");
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Age", age.Text);
            cmd.Parameters.AddWithValue("@DOB", dob.Value);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@Gender", gender.Text);
            cmd.Parameters.AddWithValue("@sid", txtsid.Text);


            cmd.Connection = conn;
            //execute query
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                MessageBox.Show("data updated!");
            else
                MessageBox.Show("data update failed!");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "Add")
            {
                databaseinsert();
                dgvstudent.DataSource = getallrecords("HP", "studentDB", "tblstudents");
                txtsid.Clear();
                txtname.Clear();
                txtemail.Clear();
                age.Value = 0;
                gender.Text = "";
                dob.Value = DateTime.Now;
                txtaddress.Clear();
            }
            else if (btnadd.Text == "Update")
            {
                databaseupdate();
                dgvstudent.DataSource = getallrecords("HP", "studentDB", "tblstudents");
            }

        }

        private void dgvstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == coledit.Index)//update
            {
                txtsid.Text = dgvstudent.Rows[e.RowIndex].Cells["sid"].Value.ToString();
                txtname.Text = dgvstudent.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtemail.Text = dgvstudent.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                age.Value = Convert.ToInt32(dgvstudent.Rows[e.RowIndex].Cells["Age"].Value.ToString());
                dob.Value = Convert.ToDateTime(dgvstudent.Rows[e.RowIndex].Cells["DOB"].Value.ToString());
                txtaddress.Text = dgvstudent.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                gender.Text = dgvstudent.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                //changing button name
                btnadd.Text = "Update";

            }
            else if (e.ColumnIndex == coldelete.Index)//delete
            {
                DialogResult ans = MessageBox.Show("Are you sure to delete", "Confirmation", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection("server=HP ;database=studentDB ;integrated security =true;");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from  tblstudents where sid=@sid");
                    cmd.Parameters.AddWithValue("@sid", dgvstudent.Rows[e.RowIndex].Cells["sid"].Value.ToString());
                    cmd.Connection = conn;
                    //execute query
                    int an = cmd.ExecuteNonQuery();
                    if (an > 0)
                        MessageBox.Show("data deleted!");
                    else
                        MessageBox.Show("data deletion failed!");
                    dgvstudent.DataSource = getallrecords("HP", "studentDB", "tblstudents");//refresh dgvtable...
                }

            }



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsid.Clear();
            txtname.Clear();
            txtemail.Clear();
            age.Value = 0;
            gender.Text = "";
            dob.Value =DateTime.Now;
            txtaddress.Clear();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //create the temporary datasource i.e.bindingsource because it can filter
            BindingSource bs = new BindingSource();
            //assign original datasource(i.e)data  to binding source
            bs.DataSource =dgvstudent.DataSource;
            //now filter the binding source
            bs.Filter = "Name like'*" + txtsearch.Text + "*'";
            //now assign filtered data in grid
            dgvstudent.DataSource = bs;
            //clear any selection if any on datagrid
            dgvstudent.ClearSelection();

        }
    }
}

   