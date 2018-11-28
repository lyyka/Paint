namespace Paint
{
    partial class GameTask
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
            this.task_tb = new System.Windows.Forms.RichTextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task_tb
            // 
            this.task_tb.Location = new System.Drawing.Point(0, 0);
            this.task_tb.Name = "task_tb";
            this.task_tb.ReadOnly = true;
            this.task_tb.Size = new System.Drawing.Size(456, 62);
            this.task_tb.TabIndex = 2;
            this.task_tb.Text = "";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(167, 79);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(107, 23);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "Close this";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_Click);
            // 
            // GameTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 116);
            this.ControlBox = false;
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.task_tb);
            this.Name = "GameTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Task";
            this.Load += new System.EventHandler(this.GameTask_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox task_tb;
        private System.Windows.Forms.Button close_btn;
    }
}