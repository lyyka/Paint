namespace Paint
{
    partial class AddText
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
            this.text_to_add = new System.Windows.Forms.TextBox();
            this.textToAdd_label = new System.Windows.Forms.Label();
            this.fontSize_nud = new System.Windows.Forms.NumericUpDown();
            this.fontSize_label = new System.Windows.Forms.Label();
            this.currentColor_pb = new System.Windows.Forms.PictureBox();
            this.color_label = new System.Windows.Forms.Label();
            this.addText_btn = new System.Windows.Forms.Button();
            this.color_mixer = new System.Windows.Forms.ColorDialog();
            this.fontFamily_cb = new System.Windows.Forms.ComboBox();
            this.fontFamily_label = new System.Windows.Forms.Label();
            this.previewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColor_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // text_to_add
            // 
            this.text_to_add.Location = new System.Drawing.Point(12, 40);
            this.text_to_add.Name = "text_to_add";
            this.text_to_add.Size = new System.Drawing.Size(161, 20);
            this.text_to_add.TabIndex = 0;
            // 
            // textToAdd_label
            // 
            this.textToAdd_label.AutoSize = true;
            this.textToAdd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToAdd_label.Location = new System.Drawing.Point(9, 24);
            this.textToAdd_label.Name = "textToAdd_label";
            this.textToAdd_label.Size = new System.Drawing.Size(36, 13);
            this.textToAdd_label.TabIndex = 1;
            this.textToAdd_label.Text = "Text:";
            // 
            // fontSize_nud
            // 
            this.fontSize_nud.Location = new System.Drawing.Point(12, 159);
            this.fontSize_nud.Name = "fontSize_nud";
            this.fontSize_nud.Size = new System.Drawing.Size(120, 20);
            this.fontSize_nud.TabIndex = 2;
            // 
            // fontSize_label
            // 
            this.fontSize_label.AutoSize = true;
            this.fontSize_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSize_label.Location = new System.Drawing.Point(9, 143);
            this.fontSize_label.Name = "fontSize_label";
            this.fontSize_label.Size = new System.Drawing.Size(62, 13);
            this.fontSize_label.TabIndex = 3;
            this.fontSize_label.Text = "Font size:";
            // 
            // currentColor_pb
            // 
            this.currentColor_pb.Location = new System.Drawing.Point(15, 209);
            this.currentColor_pb.Name = "currentColor_pb";
            this.currentColor_pb.Size = new System.Drawing.Size(49, 50);
            this.currentColor_pb.TabIndex = 4;
            this.currentColor_pb.TabStop = false;
            this.currentColor_pb.Click += new System.EventHandler(this.currentColor_pb_Click);
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_label.Location = new System.Drawing.Point(12, 193);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(40, 13);
            this.color_label.TabIndex = 5;
            this.color_label.Text = "Color:";
            // 
            // addText_btn
            // 
            this.addText_btn.BackColor = System.Drawing.Color.White;
            this.addText_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addText_btn.Location = new System.Drawing.Point(12, 285);
            this.addText_btn.Name = "addText_btn";
            this.addText_btn.Size = new System.Drawing.Size(161, 23);
            this.addText_btn.TabIndex = 13;
            this.addText_btn.Text = "Add Text";
            this.addText_btn.UseVisualStyleBackColor = false;
            this.addText_btn.Click += new System.EventHandler(this.addText_btn_Click);
            // 
            // fontFamily_cb
            // 
            this.fontFamily_cb.FormattingEnabled = true;
            this.fontFamily_cb.Location = new System.Drawing.Point(12, 86);
            this.fontFamily_cb.Name = "fontFamily_cb";
            this.fontFamily_cb.Size = new System.Drawing.Size(121, 21);
            this.fontFamily_cb.TabIndex = 14;
            this.fontFamily_cb.SelectedIndexChanged += new System.EventHandler(this.fontFamily_cb_SelectedIndexChanged);
            // 
            // fontFamily_label
            // 
            this.fontFamily_label.AutoSize = true;
            this.fontFamily_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontFamily_label.Location = new System.Drawing.Point(9, 70);
            this.fontFamily_label.Name = "fontFamily_label";
            this.fontFamily_label.Size = new System.Drawing.Size(72, 13);
            this.fontFamily_label.TabIndex = 15;
            this.fontFamily_label.Text = "Font family:";
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.Location = new System.Drawing.Point(8, 110);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(99, 20);
            this.previewLabel.TabIndex = 16;
            this.previewLabel.Text = "Font preview";
            // 
            // AddText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(186, 322);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.fontFamily_label);
            this.Controls.Add(this.fontFamily_cb);
            this.Controls.Add(this.addText_btn);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.currentColor_pb);
            this.Controls.Add(this.fontSize_label);
            this.Controls.Add(this.fontSize_nud);
            this.Controls.Add(this.textToAdd_label);
            this.Controls.Add(this.text_to_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Text";
            this.Load += new System.EventHandler(this.AddText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontSize_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColor_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_to_add;
        private System.Windows.Forms.Label textToAdd_label;
        private System.Windows.Forms.NumericUpDown fontSize_nud;
        private System.Windows.Forms.Label fontSize_label;
        private System.Windows.Forms.PictureBox currentColor_pb;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Button addText_btn;
        private System.Windows.Forms.ColorDialog color_mixer;
        private System.Windows.Forms.ComboBox fontFamily_cb;
        private System.Windows.Forms.Label fontFamily_label;
        private System.Windows.Forms.Label previewLabel;
    }
}