namespace Paint
{
    partial class Form5
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
            this.igratb = new System.Windows.Forms.RichTextBox();
            this.izadjibt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kada ste spremni kliknite \"Zapocni\" na pocetnom prozoru.\r\nKada zavrsite samo klik" +
    "nite na \"Zavrsi\" na prvom prozoru.";
            // 
            // igratb
            // 
            this.igratb.Enabled = false;
            this.igratb.Location = new System.Drawing.Point(0, 0);
            this.igratb.Name = "igratb";
            this.igratb.Size = new System.Drawing.Size(456, 36);
            this.igratb.TabIndex = 2;
            this.igratb.Text = "";
            // 
            // izadjibt
            // 
            this.izadjibt.Location = new System.Drawing.Point(335, 92);
            this.izadjibt.Name = "izadjibt";
            this.izadjibt.Size = new System.Drawing.Size(107, 23);
            this.izadjibt.TabIndex = 3;
            this.izadjibt.Text = "Izadji";
            this.izadjibt.UseVisualStyleBackColor = true;
            this.izadjibt.Click += new System.EventHandler(this.izadjibt_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 127);
            this.ControlBox = false;
            this.Controls.Add(this.izadjibt);
            this.Controls.Add(this.igratb);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Igra";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox igratb;
        private System.Windows.Forms.Button izadjibt;
    }
}