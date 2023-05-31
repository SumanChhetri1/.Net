
namespace form
{
    partial class billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.colsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rate = new System.Windows.Forms.NumericUpDown();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtnetamount = new System.Windows.Forms.TextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.mybill = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asian Suppliers Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bharatpur,Chitwan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Billing Form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bill no:";
            // 
            // txtbillno
            // 
            this.txtbillno.Location = new System.Drawing.Point(65, 17);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(94, 20);
            this.txtbillno.TabIndex = 10;
            // 
            // txtitemname
            // 
            this.txtitemname.AutoCompleteCustomSource.AddRange(new string[] {
            "copy",
            "pen ",
            "pencil"});
            this.txtitemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtitemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtitemname.Location = new System.Drawing.Point(21, 149);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(94, 20);
            this.txtitemname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Item Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Amount";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(141, 150);
            this.qty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(84, 20);
            this.qty.TabIndex = 2;
            this.qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty.ValueChanged += new System.EventHandler(this.rate_Enter);
            this.qty.Enter += new System.EventHandler(this.qty_ValueChanged);
            // 
            // dgvlist
            // 
            this.dgvlist.AllowUserToAddRows = false;
            this.dgvlist.AllowUserToDeleteRows = false;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsn,
            this.colitemname,
            this.colqty,
            this.colrate,
            this.colamount});
            this.dgvlist.Location = new System.Drawing.Point(0, 179);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.ReadOnly = true;
            this.dgvlist.Size = new System.Drawing.Size(542, 175);
            this.dgvlist.TabIndex = 12;
            // 
            // colsn
            // 
            this.colsn.HeaderText = "S.N.";
            this.colsn.Name = "colsn";
            this.colsn.ReadOnly = true;
            // 
            // colitemname
            // 
            this.colitemname.HeaderText = "Item Name";
            this.colitemname.Name = "colitemname";
            this.colitemname.ReadOnly = true;
            // 
            // colqty
            // 
            this.colqty.HeaderText = "Quantity";
            this.colqty.Name = "colqty";
            this.colqty.ReadOnly = true;
            // 
            // colrate
            // 
            this.colrate.HeaderText = "Rate";
            this.colrate.Name = "colrate";
            this.colrate.ReadOnly = true;
            // 
            // colamount
            // 
            this.colamount.HeaderText = "Amount";
            this.colamount.Name = "colamount";
            this.colamount.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(560, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker1.TabIndex = 133;
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(250, 149);
            this.rate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(84, 20);
            this.rate.TabIndex = 3;
            this.rate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rate.Enter += new System.EventHandler(this.rate_Enter);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(357, 149);
            this.amount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(84, 20);
            this.amount.TabIndex = 4;
            this.amount.Enter += new System.EventHandler(this.amount_Enter);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(461, 143);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 30);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(0, 383);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 41);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(313, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Discount % :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(306, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Net Amount :";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(412, 360);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(94, 20);
            this.txttotal.TabIndex = 21;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(412, 383);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(94, 20);
            this.txtdiscount.TabIndex = 6;
            // 
            // txtnetamount
            // 
            this.txtnetamount.Location = new System.Drawing.Point(412, 407);
            this.txtnetamount.Name = "txtnetamount";
            this.txtnetamount.Size = new System.Drawing.Size(94, 20);
            this.txtnetamount.TabIndex = 7;
            this.txtnetamount.Enter += new System.EventHandler(this.txtnetamount_Enter);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(96, 383);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 39);
            this.btnprint.TabIndex = 8;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-3, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 15);
            this.label13.TabIndex = 134;
            this.label13.Text = "Customer Name :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(121, 57);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(114, 20);
            this.txtname.TabIndex = 0;
            // 
            // mybill
            // 
            this.mybill.Location = new System.Drawing.Point(560, 116);
            this.mybill.Name = "mybill";
            this.mybill.Size = new System.Drawing.Size(238, 264);
            this.mybill.TabIndex = 135;
            this.mybill.Text = "";
            this.mybill.TextChanged += new System.EventHandler(this.mybill_TextChanged);
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mybill);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtnetamount);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvlist);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.txtbillno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "billing";
            this.Text = "billing";
            this.Load += new System.EventHandler(this.billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown rate;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtnetamount;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RichTextBox mybill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colamount;
    }
}