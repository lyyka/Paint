namespace Paint
{
    partial class About
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
            this.palette_image = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.closeAbout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.palette_image)).BeginInit();
            this.SuspendLayout();
            // 
            // palette_image
            // 
            this.palette_image.BackgroundImage = global::Paint.Properties.Resources.palette;
            this.palette_image.Location = new System.Drawing.Point(12, 12);
            this.palette_image.Name = "palette_image";
            this.palette_image.Size = new System.Drawing.Size(348, 192);
            this.palette_image.TabIndex = 1;
            this.palette_image.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(126, 255);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "luka.robajac@gmail.com";
            // 
            // closeAbout_btn
            // 
            this.closeAbout_btn.Location = new System.Drawing.Point(129, 296);
            this.closeAbout_btn.Name = "closeAbout_btn";
            this.closeAbout_btn.Size = new System.Drawing.Size(118, 31);
            this.closeAbout_btn.TabIndex = 6;
            this.closeAbout_btn.Text = "OK";
            this.closeAbout_btn.UseVisualStyleBackColor = true;
            this.closeAbout_btn.Click += new System.EventHandler(this.closeAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Made by: Luka Robajac";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 353);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.closeAbout_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.palette_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.palette_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox palette_image;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button closeAbout_btn;
        private System.Windows.Forms.Label label1;
    }
}