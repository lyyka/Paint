namespace Paint
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.helpImg = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.closeHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.helpImg)).BeginInit();
            this.SuspendLayout();
            // 
            // helpImg
            // 
            this.helpImg.BackgroundImage = global::Paint.Properties.Resources.help;
            this.helpImg.Location = new System.Drawing.Point(12, 12);
            this.helpImg.Name = "helpImg";
            this.helpImg.Size = new System.Drawing.Size(128, 128);
            this.helpImg.TabIndex = 0;
            this.helpImg.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(146, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(434, 376);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // closeHelp
            // 
            this.closeHelp.Location = new System.Drawing.Point(12, 352);
            this.closeHelp.Name = "closeHelp";
            this.closeHelp.Size = new System.Drawing.Size(128, 36);
            this.closeHelp.TabIndex = 2;
            this.closeHelp.Text = "Close";
            this.closeHelp.UseVisualStyleBackColor = true;
            this.closeHelp.Click += new System.EventHandler(this.closeHelp_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 400);
            this.Controls.Add(this.closeHelp);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.helpImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.helpImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox helpImg;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button closeHelp;
    }
}