namespace Paint
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pen_width_nud = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.favColor_label = new System.Windows.Forms.Label();
            this.mostUsedColor_pb = new System.Windows.Forms.Button();
            this.Colormixer = new System.Windows.Forms.Button();
            this.brownColor = new System.Windows.Forms.Button();
            this.limeColor = new System.Windows.Forms.Button();
            this.aquaColor = new System.Windows.Forms.Button();
            this.whiteColor = new System.Windows.Forms.Button();
            this.blackColor = new System.Windows.Forms.Button();
            this.purpleColor = new System.Windows.Forms.Button();
            this.redColor = new System.Windows.Forms.Button();
            this.orangeColor = new System.Windows.Forms.Button();
            this.yellowColor = new System.Windows.Forms.Button();
            this.greenColor = new System.Windows.Forms.Button();
            this.color_mixer = new System.Windows.Forms.ColorDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrawing_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.openDrawing_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDrawing_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasSettings_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAll_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ts = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDrawing_Dialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapesControl_gb = new System.Windows.Forms.GroupBox();
            this.rect_pb = new System.Windows.Forms.PictureBox();
            this.circle_pb = new System.Windows.Forms.PictureBox();
            this.drawingControls_gb = new System.Windows.Forms.GroupBox();
            this.text_pb = new System.Windows.Forms.PictureBox();
            this.pen_pb = new System.Windows.Forms.PictureBox();
            this.eraser_pb = new System.Windows.Forms.PictureBox();
            this.spray_pb = new System.Windows.Forms.PictureBox();
            this.openDrawing_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.savedStatus_label = new System.Windows.Forms.Label();
            this.sizeValue_label = new System.Windows.Forms.Label();
            this.sizeCaption_label = new System.Windows.Forms.Label();
            this.drawingCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pen_width_nud)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.shapesControl_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rect_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle_pb)).BeginInit();
            this.drawingControls_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pen_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spray_pb)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pen_width_nud);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen width";
            // 
            // pen_width_nud
            // 
            this.pen_width_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pen_width_nud.Location = new System.Drawing.Point(20, 36);
            this.pen_width_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pen_width_nud.Name = "pen_width_nud";
            this.pen_width_nud.Size = new System.Drawing.Size(101, 45);
            this.pen_width_nud.TabIndex = 0;
            this.pen_width_nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pen_width_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pen_width_nud.ValueChanged += new System.EventHandler(this.pencilWidth_Change);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.favColor_label);
            this.groupBox2.Controls.Add(this.mostUsedColor_pb);
            this.groupBox2.Controls.Add(this.Colormixer);
            this.groupBox2.Controls.Add(this.brownColor);
            this.groupBox2.Controls.Add(this.limeColor);
            this.groupBox2.Controls.Add(this.aquaColor);
            this.groupBox2.Controls.Add(this.whiteColor);
            this.groupBox2.Controls.Add(this.blackColor);
            this.groupBox2.Controls.Add(this.purpleColor);
            this.groupBox2.Controls.Add(this.redColor);
            this.groupBox2.Controls.Add(this.orangeColor);
            this.groupBox2.Controls.Add(this.yellowColor);
            this.groupBox2.Controls.Add(this.greenColor);
            this.groupBox2.Location = new System.Drawing.Point(165, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // favColor_label
            // 
            this.favColor_label.AutoSize = true;
            this.favColor_label.Location = new System.Drawing.Point(271, 36);
            this.favColor_label.Name = "favColor_label";
            this.favColor_label.Size = new System.Drawing.Size(56, 13);
            this.favColor_label.TabIndex = 34;
            this.favColor_label.Text = "Most used";
            // 
            // mostUsedColor_pb
            // 
            this.mostUsedColor_pb.BackColor = System.Drawing.Color.LightGray;
            this.mostUsedColor_pb.FlatAppearance.BorderSize = 0;
            this.mostUsedColor_pb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mostUsedColor_pb.Location = new System.Drawing.Point(282, 53);
            this.mostUsedColor_pb.Name = "mostUsedColor_pb";
            this.mostUsedColor_pb.Size = new System.Drawing.Size(36, 27);
            this.mostUsedColor_pb.TabIndex = 10;
            this.mostUsedColor_pb.UseVisualStyleBackColor = false;
            // 
            // Colormixer
            // 
            this.Colormixer.BackColor = System.Drawing.Color.White;
            this.Colormixer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Colormixer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Colormixer.Location = new System.Drawing.Point(170, 29);
            this.Colormixer.Name = "Colormixer";
            this.Colormixer.Size = new System.Drawing.Size(76, 59);
            this.Colormixer.TabIndex = 11;
            this.Colormixer.UseVisualStyleBackColor = false;
            this.Colormixer.Click += new System.EventHandler(this.Colormixer_Click);
            // 
            // brownColor
            // 
            this.brownColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brownColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brownColor.FlatAppearance.BorderSize = 0;
            this.brownColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brownColor.Location = new System.Drawing.Point(139, 63);
            this.brownColor.Name = "brownColor";
            this.brownColor.Size = new System.Drawing.Size(25, 25);
            this.brownColor.TabIndex = 9;
            this.brownColor.TabStop = false;
            this.brownColor.UseVisualStyleBackColor = false;
            // 
            // limeColor
            // 
            this.limeColor.BackColor = System.Drawing.Color.Lime;
            this.limeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limeColor.FlatAppearance.BorderSize = 0;
            this.limeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limeColor.Location = new System.Drawing.Point(108, 63);
            this.limeColor.Name = "limeColor";
            this.limeColor.Size = new System.Drawing.Size(25, 25);
            this.limeColor.TabIndex = 8;
            this.limeColor.TabStop = false;
            this.limeColor.UseVisualStyleBackColor = false;
            // 
            // aquaColor
            // 
            this.aquaColor.BackColor = System.Drawing.Color.Aqua;
            this.aquaColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aquaColor.FlatAppearance.BorderSize = 0;
            this.aquaColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aquaColor.Location = new System.Drawing.Point(77, 63);
            this.aquaColor.Name = "aquaColor";
            this.aquaColor.Size = new System.Drawing.Size(25, 25);
            this.aquaColor.TabIndex = 7;
            this.aquaColor.TabStop = false;
            this.aquaColor.UseVisualStyleBackColor = false;
            // 
            // whiteColor
            // 
            this.whiteColor.BackColor = System.Drawing.Color.White;
            this.whiteColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whiteColor.FlatAppearance.BorderSize = 0;
            this.whiteColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.whiteColor.Location = new System.Drawing.Point(15, 63);
            this.whiteColor.Name = "whiteColor";
            this.whiteColor.Size = new System.Drawing.Size(25, 25);
            this.whiteColor.TabIndex = 6;
            this.whiteColor.TabStop = false;
            this.whiteColor.UseVisualStyleBackColor = false;
            // 
            // blackColor
            // 
            this.blackColor.BackColor = System.Drawing.Color.Black;
            this.blackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackColor.FlatAppearance.BorderSize = 0;
            this.blackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blackColor.Location = new System.Drawing.Point(46, 63);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(25, 25);
            this.blackColor.TabIndex = 5;
            this.blackColor.TabStop = false;
            this.blackColor.UseVisualStyleBackColor = false;
            // 
            // purpleColor
            // 
            this.purpleColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.purpleColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purpleColor.FlatAppearance.BorderSize = 0;
            this.purpleColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purpleColor.Location = new System.Drawing.Point(139, 30);
            this.purpleColor.Name = "purpleColor";
            this.purpleColor.Size = new System.Drawing.Size(25, 25);
            this.purpleColor.TabIndex = 4;
            this.purpleColor.TabStop = false;
            this.purpleColor.UseVisualStyleBackColor = false;
            // 
            // redColor
            // 
            this.redColor.BackColor = System.Drawing.Color.Red;
            this.redColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redColor.FlatAppearance.BorderSize = 0;
            this.redColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.redColor.Location = new System.Drawing.Point(108, 30);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(25, 25);
            this.redColor.TabIndex = 3;
            this.redColor.TabStop = false;
            this.redColor.UseVisualStyleBackColor = false;
            // 
            // orangeColor
            // 
            this.orangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orangeColor.FlatAppearance.BorderSize = 0;
            this.orangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orangeColor.Location = new System.Drawing.Point(77, 30);
            this.orangeColor.Name = "orangeColor";
            this.orangeColor.Size = new System.Drawing.Size(25, 25);
            this.orangeColor.TabIndex = 2;
            this.orangeColor.TabStop = false;
            this.orangeColor.UseVisualStyleBackColor = false;
            // 
            // yellowColor
            // 
            this.yellowColor.BackColor = System.Drawing.Color.Yellow;
            this.yellowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellowColor.FlatAppearance.BorderSize = 0;
            this.yellowColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yellowColor.Location = new System.Drawing.Point(46, 30);
            this.yellowColor.Name = "yellowColor";
            this.yellowColor.Size = new System.Drawing.Size(25, 25);
            this.yellowColor.TabIndex = 1;
            this.yellowColor.TabStop = false;
            this.yellowColor.UseVisualStyleBackColor = false;
            // 
            // greenColor
            // 
            this.greenColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenColor.FlatAppearance.BorderSize = 0;
            this.greenColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.greenColor.Location = new System.Drawing.Point(15, 30);
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(25, 25);
            this.greenColor.TabIndex = 0;
            this.greenColor.TabStop = false;
            this.greenColor.UseVisualStyleBackColor = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.edit_ts,
            this.about_ts});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1360, 24);
            this.menuStrip.TabIndex = 30;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrawing_ts,
            this.openDrawing_ts,
            this.saveDrawing_ts,
            this.saveAs_ts});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDrawing_ts
            // 
            this.newDrawing_ts.Name = "newDrawing_ts";
            this.newDrawing_ts.Size = new System.Drawing.Size(145, 22);
            this.newDrawing_ts.Text = "New Drawing";
            this.newDrawing_ts.Click += new System.EventHandler(this.newDrawing_ts_Click);
            // 
            // openDrawing_ts
            // 
            this.openDrawing_ts.Name = "openDrawing_ts";
            this.openDrawing_ts.Size = new System.Drawing.Size(145, 22);
            this.openDrawing_ts.Text = "Open...";
            this.openDrawing_ts.Click += new System.EventHandler(this.openDrawing_ts_Click);
            // 
            // saveDrawing_ts
            // 
            this.saveDrawing_ts.Enabled = false;
            this.saveDrawing_ts.Name = "saveDrawing_ts";
            this.saveDrawing_ts.Size = new System.Drawing.Size(145, 22);
            this.saveDrawing_ts.Text = "Save...";
            this.saveDrawing_ts.Click += new System.EventHandler(this.saveDrawing_ts_Click);
            // 
            // saveAs_ts
            // 
            this.saveAs_ts.Enabled = false;
            this.saveAs_ts.Name = "saveAs_ts";
            this.saveAs_ts.Size = new System.Drawing.Size(145, 22);
            this.saveAs_ts.Text = "Save As...";
            this.saveAs_ts.Click += new System.EventHandler(this.saveAs_ts_Click);
            // 
            // edit_ts
            // 
            this.edit_ts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canvasSettings_ts,
            this.resetAll_ts,
            this.undo_ts});
            this.edit_ts.Name = "edit_ts";
            this.edit_ts.Size = new System.Drawing.Size(39, 20);
            this.edit_ts.Text = "Edit";
            // 
            // canvasSettings_ts
            // 
            this.canvasSettings_ts.Name = "canvasSettings_ts";
            this.canvasSettings_ts.Size = new System.Drawing.Size(166, 22);
            this.canvasSettings_ts.Text = "Canvas Settings...";
            this.canvasSettings_ts.Click += new System.EventHandler(this.canvasSettings_ts_Click);
            // 
            // resetAll_ts
            // 
            this.resetAll_ts.Name = "resetAll_ts";
            this.resetAll_ts.Size = new System.Drawing.Size(166, 22);
            this.resetAll_ts.Text = "Reset All";
            this.resetAll_ts.Click += new System.EventHandler(this.resetAll_Click);
            // 
            // undo_ts
            // 
            this.undo_ts.Name = "undo_ts";
            this.undo_ts.Size = new System.Drawing.Size(166, 22);
            this.undo_ts.Text = "Undo";
            this.undo_ts.Click += new System.EventHandler(this.undo_ts_Click);
            // 
            // about_ts
            // 
            this.about_ts.Name = "about_ts";
            this.about_ts.Size = new System.Drawing.Size(52, 20);
            this.about_ts.Text = "About";
            this.about_ts.Click += new System.EventHandler(this.aboutSoftware_Click);
            // 
            // saveDrawing_Dialog
            // 
            this.saveDrawing_Dialog.Filter = "PNG|*.png";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.shapesControl_gb);
            this.panel1.Controls.Add(this.drawingControls_gb);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 129);
            this.panel1.TabIndex = 33;
            // 
            // shapesControl_gb
            // 
            this.shapesControl_gb.Controls.Add(this.rect_pb);
            this.shapesControl_gb.Controls.Add(this.circle_pb);
            this.shapesControl_gb.Location = new System.Drawing.Point(796, 3);
            this.shapesControl_gb.Name = "shapesControl_gb";
            this.shapesControl_gb.Size = new System.Drawing.Size(549, 118);
            this.shapesControl_gb.TabIndex = 36;
            this.shapesControl_gb.TabStop = false;
            this.shapesControl_gb.Text = "Shapes";
            // 
            // rect_pb
            // 
            this.rect_pb.BackColor = System.Drawing.Color.Transparent;
            this.rect_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rect_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rect_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rect_pb.Location = new System.Drawing.Point(6, 23);
            this.rect_pb.Name = "rect_pb";
            this.rect_pb.Size = new System.Drawing.Size(32, 32);
            this.rect_pb.TabIndex = 33;
            this.rect_pb.TabStop = false;
            // 
            // circle_pb
            // 
            this.circle_pb.BackColor = System.Drawing.Color.Transparent;
            this.circle_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circle_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circle_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circle_pb.Location = new System.Drawing.Point(44, 23);
            this.circle_pb.Name = "circle_pb";
            this.circle_pb.Size = new System.Drawing.Size(32, 32);
            this.circle_pb.TabIndex = 34;
            this.circle_pb.TabStop = false;
            // 
            // drawingControls_gb
            // 
            this.drawingControls_gb.Controls.Add(this.text_pb);
            this.drawingControls_gb.Controls.Add(this.pen_pb);
            this.drawingControls_gb.Controls.Add(this.eraser_pb);
            this.drawingControls_gb.Controls.Add(this.spray_pb);
            this.drawingControls_gb.Location = new System.Drawing.Point(518, 3);
            this.drawingControls_gb.Name = "drawingControls_gb";
            this.drawingControls_gb.Size = new System.Drawing.Size(272, 118);
            this.drawingControls_gb.TabIndex = 36;
            this.drawingControls_gb.TabStop = false;
            this.drawingControls_gb.Text = "Drawing";
            // 
            // text_pb
            // 
            this.text_pb.BackColor = System.Drawing.Color.Transparent;
            this.text_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.text_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_pb.Location = new System.Drawing.Point(120, 23);
            this.text_pb.Name = "text_pb";
            this.text_pb.Size = new System.Drawing.Size(32, 32);
            this.text_pb.TabIndex = 39;
            this.text_pb.TabStop = false;
            // 
            // pen_pb
            // 
            this.pen_pb.BackColor = System.Drawing.Color.Transparent;
            this.pen_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pen_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pen_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pen_pb.Location = new System.Drawing.Point(6, 23);
            this.pen_pb.Name = "pen_pb";
            this.pen_pb.Size = new System.Drawing.Size(32, 32);
            this.pen_pb.TabIndex = 35;
            this.pen_pb.TabStop = false;
            // 
            // eraser_pb
            // 
            this.eraser_pb.BackColor = System.Drawing.Color.Transparent;
            this.eraser_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraser_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eraser_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraser_pb.Location = new System.Drawing.Point(82, 23);
            this.eraser_pb.Name = "eraser_pb";
            this.eraser_pb.Size = new System.Drawing.Size(32, 32);
            this.eraser_pb.TabIndex = 37;
            this.eraser_pb.TabStop = false;
            // 
            // spray_pb
            // 
            this.spray_pb.BackColor = System.Drawing.Color.Transparent;
            this.spray_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spray_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spray_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spray_pb.Location = new System.Drawing.Point(44, 23);
            this.spray_pb.Name = "spray_pb";
            this.spray_pb.Size = new System.Drawing.Size(32, 32);
            this.spray_pb.TabIndex = 36;
            this.spray_pb.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.menuStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 153);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.savedStatus_label);
            this.panel3.Controls.Add(this.sizeValue_label);
            this.panel3.Controls.Add(this.sizeCaption_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 828);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1360, 23);
            this.panel3.TabIndex = 35;
            // 
            // savedStatus_label
            // 
            this.savedStatus_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.savedStatus_label.Location = new System.Drawing.Point(1260, 0);
            this.savedStatus_label.Name = "savedStatus_label";
            this.savedStatus_label.Size = new System.Drawing.Size(100, 23);
            this.savedStatus_label.TabIndex = 38;
            this.savedStatus_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeValue_label
            // 
            this.sizeValue_label.AutoSize = true;
            this.sizeValue_label.Location = new System.Drawing.Point(71, 5);
            this.sizeValue_label.Name = "sizeValue_label";
            this.sizeValue_label.Size = new System.Drawing.Size(0, 13);
            this.sizeValue_label.TabIndex = 37;
            // 
            // sizeCaption_label
            // 
            this.sizeCaption_label.AutoSize = true;
            this.sizeCaption_label.Location = new System.Drawing.Point(3, 5);
            this.sizeCaption_label.Name = "sizeCaption_label";
            this.sizeCaption_label.Size = new System.Drawing.Size(67, 13);
            this.sizeCaption_label.TabIndex = 36;
            this.sizeCaption_label.Text = "Canvas size:";
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingCanvas.BackColor = System.Drawing.Color.White;
            this.drawingCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawingCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.drawingCanvas.Location = new System.Drawing.Point(14, 166);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(1331, 648);
            this.drawingCanvas.TabIndex = 32;
            this.drawingCanvas.TabStop = false;
            this.drawingCanvas.Visible = false;
            this.drawingCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseDown);
            this.drawingCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseMove);
            this.drawingCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1360, 851);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.drawingCanvas);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pen_width_nud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.shapesControl_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rect_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle_pb)).EndInit();
            this.drawingControls_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.text_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pen_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spray_pb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button brownColor;
        private System.Windows.Forms.Button limeColor;
        private System.Windows.Forms.Button aquaColor;
        private System.Windows.Forms.Button whiteColor;
        private System.Windows.Forms.Button blackColor;
        private System.Windows.Forms.Button purpleColor;
        private System.Windows.Forms.Button redColor;
        private System.Windows.Forms.Button orangeColor;
        private System.Windows.Forms.Button yellowColor;
        private System.Windows.Forms.Button greenColor;
        private System.Windows.Forms.Button mostUsedColor_pb;
        private System.Windows.Forms.ColorDialog color_mixer;
        private System.Windows.Forms.Button Colormixer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem about_ts;
        private System.Windows.Forms.NumericUpDown pen_width_nud;
        private System.Windows.Forms.PictureBox rect_pb;
        private System.Windows.Forms.PictureBox circle_pb;
        private System.Windows.Forms.PictureBox pen_pb;
        private System.Windows.Forms.PictureBox spray_pb;
        private System.Windows.Forms.PictureBox eraser_pb;
        private System.Windows.Forms.SaveFileDialog saveDrawing_Dialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrawing_ts;
        private System.Windows.Forms.ToolStripMenuItem openDrawing_ts;
        private System.Windows.Forms.ToolStripMenuItem saveDrawing_ts;
        private System.Windows.Forms.ToolStripMenuItem saveAs_ts;
        public System.Windows.Forms.PictureBox drawingCanvas;
        private System.Windows.Forms.ToolStripMenuItem edit_ts;
        private System.Windows.Forms.ToolStripMenuItem resetAll_ts;
        private System.Windows.Forms.ToolStripMenuItem undo_ts;
        private System.Windows.Forms.ToolStripMenuItem canvasSettings_ts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label favColor_label;
        private System.Windows.Forms.OpenFileDialog openDrawing_Dialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label sizeValue_label;
        private System.Windows.Forms.Label sizeCaption_label;
        private System.Windows.Forms.Label savedStatus_label;
        private System.Windows.Forms.GroupBox shapesControl_gb;
        private System.Windows.Forms.GroupBox drawingControls_gb;
        private System.Windows.Forms.PictureBox text_pb;
    }
}

