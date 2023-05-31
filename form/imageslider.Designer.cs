
namespace form
{
    partial class imageslider
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
            this.txtcount = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgboard)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(366, 412);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(77, 20);
            this.txtcount.TabIndex = 15;
            this.txtcount.Text = "1";
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(466, 398);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(94, 44);
            this.btnnext.TabIndex = 13;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnprev.Location = new System.Drawing.Point(246, 398);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(91, 44);
            this.btnprev.TabIndex = 12;
            this.btnprev.Text = "Previous";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Image Slider :";
            // 
            // imgboard
            // 
            this.imgboard.Location = new System.Drawing.Point(59, 47);
            this.imgboard.Name = "imgboard";
            this.imgboard.Size = new System.Drawing.Size(670, 345);
            this.imgboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgboard.TabIndex = 14;
            this.imgboard.TabStop = false;
            // 
            // imageslider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgboard);
            this.Name = "imageslider";
            this.Text = "imageslider";
            this.Load += new System.EventHandler(this.imageslider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgboard;
    }
}