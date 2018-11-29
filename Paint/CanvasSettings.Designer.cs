namespace Paint
{
    partial class CanvasSettings
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
            this.canvasWidth = new System.Windows.Forms.NumericUpDown();
            this.canvasHeight = new System.Windows.Forms.NumericUpDown();
            this.createCanvas = new System.Windows.Forms.Button();
            this.invertValues_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvasWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            // 
            // canvasWidth
            // 
            this.canvasWidth.BackColor = System.Drawing.Color.White;
            this.canvasWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasWidth.Location = new System.Drawing.Point(56, 37);
            this.canvasWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.canvasWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.canvasWidth.Name = "canvasWidth";
            this.canvasWidth.Size = new System.Drawing.Size(120, 20);
            this.canvasWidth.TabIndex = 3;
            this.canvasWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.canvasWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // canvasHeight
            // 
            this.canvasHeight.BackColor = System.Drawing.Color.White;
            this.canvasHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasHeight.Location = new System.Drawing.Point(56, 63);
            this.canvasHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.canvasHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.canvasHeight.Name = "canvasHeight";
            this.canvasHeight.Size = new System.Drawing.Size(120, 20);
            this.canvasHeight.TabIndex = 4;
            this.canvasHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.canvasHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // createCanvas
            // 
            this.createCanvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCanvas.Location = new System.Drawing.Point(15, 177);
            this.createCanvas.Name = "createCanvas";
            this.createCanvas.Size = new System.Drawing.Size(161, 23);
            this.createCanvas.TabIndex = 5;
            this.createCanvas.Text = "Set";
            this.createCanvas.UseVisualStyleBackColor = true;
            this.createCanvas.Click += new System.EventHandler(this.createCanvas_Click);
            // 
            // invertValues_btn
            // 
            this.invertValues_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invertValues_btn.Location = new System.Drawing.Point(15, 89);
            this.invertValues_btn.Name = "invertValues_btn";
            this.invertValues_btn.Size = new System.Drawing.Size(104, 23);
            this.invertValues_btn.TabIndex = 6;
            this.invertValues_btn.Text = "Invert values";
            this.invertValues_btn.UseVisualStyleBackColor = true;
            this.invertValues_btn.Click += new System.EventHandler(this.invertValues_btn_Click);
            // 
            // CanvasSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(190, 218);
            this.Controls.Add(this.invertValues_btn);
            this.Controls.Add(this.createCanvas);
            this.Controls.Add(this.canvasHeight);
            this.Controls.Add(this.canvasWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canvas Set Up";
            this.Load += new System.EventHandler(this.CanvasSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown canvasWidth;
        private System.Windows.Forms.NumericUpDown canvasHeight;
        private System.Windows.Forms.Button createCanvas;
        private System.Windows.Forms.Button invertValues_btn;
    }
}