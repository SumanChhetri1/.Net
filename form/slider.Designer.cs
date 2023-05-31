
namespace form
{
    partial class slider
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slider));
            this.txtcount = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgboard = new System.Windows.Forms.PictureBox();
            this.imagelist1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgboard)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(381, 347);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(77, 20);
            this.txtcount.TabIndex = 10;
            this.txtcount.TextChanged += new System.EventHandler(this.slider_Load);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(481, 333);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(94, 44);
            this.btnnext.TabIndex = 8;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click_1);
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnprev.Location = new System.Drawing.Point(261, 333);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(91, 44);
            this.btnprev.TabIndex = 7;
            this.btnprev.Text = "Previous";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Image Slider :";
            // 
            // imgboard
            // 
            this.imgboard.Location = new System.Drawing.Point(236, 66);
            this.imgboard.Name = "imgboard";
            this.imgboard.Size = new System.Drawing.Size(365, 241);
            this.imgboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgboard.TabIndex = 9;
            this.imgboard.TabStop = false;
            this.imgboard.Click += new System.EventHandler(this.imgboard_Click);
            // 
            // imagelist1
            // 
            this.imagelist1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist1.ImageStream")));
            this.imagelist1.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist1.Images.SetKeyName(0, "20220104065756_IMG_4396.JPG");
            this.imagelist1.Images.SetKeyName(1, "20220104075640_IMG_4405.JPG");
            this.imagelist1.Images.SetKeyName(2, "20220104075643_IMG_4406.JPG");
            this.imagelist1.Images.SetKeyName(3, "20220103142139_IMG_5972.JPG");
            // 
            // slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgboard);
            this.Name = "slider";
            this.Text = "slider";
            this.Load += new System.EventHandler(this.slider_Load);
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
        private System.Windows.Forms.ImageList imagelist1;
    }
}