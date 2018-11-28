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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pen_width_nud = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Colormixer = new System.Windows.Forms.Button();
            this.braon = new System.Windows.Forms.Button();
            this.svetlozelena = new System.Windows.Forms.Button();
            this.svetloplava = new System.Windows.Forms.Button();
            this.roze = new System.Windows.Forms.Button();
            this.crna = new System.Windows.Forms.Button();
            this.ljubicasta = new System.Windows.Forms.Button();
            this.crvena = new System.Windows.Forms.Button();
            this.narandzasta = new System.Windows.Forms.Button();
            this.zuta = new System.Windows.Forms.Button();
            this.zelena = new System.Windows.Forms.Button();
            this.favourite_color_pictureBox = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.circle_rb = new System.Windows.Forms.RadioButton();
            this.rect_rb = new System.Windows.Forms.RadioButton();
            this.circle_radius_nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rectangle_width_nud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rectangle_height_nud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.basic_pen_rb = new System.Windows.Forms.RadioButton();
            this.color_mixer = new System.Windows.Forms.ColorDialog();
            this.spray_rb = new System.Windows.Forms.RadioButton();
            this.game_cb = new System.Windows.Forms.CheckBox();
            this.end_game_btn = new System.Windows.Forms.Button();
            this.stopwatch_Control = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujSveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajCrtezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.eraser_rb = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.spray_radius_nud = new System.Windows.Forms.NumericUpDown();
            this.drawingCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pen_width_nud)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circle_radius_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_width_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_height_nud)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spray_radius_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pen_width_nud);
            this.groupBox1.Location = new System.Drawing.Point(11, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen width";
            // 
            // pen_width_nud
            // 
            this.pen_width_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pen_width_nud.Location = new System.Drawing.Point(59, 31);
            this.pen_width_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pen_width_nud.Name = "pen_width_nud";
            this.pen_width_nud.Size = new System.Drawing.Size(75, 45);
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
            this.groupBox2.Controls.Add(this.Colormixer);
            this.groupBox2.Controls.Add(this.braon);
            this.groupBox2.Controls.Add(this.svetlozelena);
            this.groupBox2.Controls.Add(this.svetloplava);
            this.groupBox2.Controls.Add(this.roze);
            this.groupBox2.Controls.Add(this.crna);
            this.groupBox2.Controls.Add(this.ljubicasta);
            this.groupBox2.Controls.Add(this.crvena);
            this.groupBox2.Controls.Add(this.narandzasta);
            this.groupBox2.Controls.Add(this.zuta);
            this.groupBox2.Controls.Add(this.zelena);
            this.groupBox2.Location = new System.Drawing.Point(227, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 98);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // Colormixer
            // 
            this.Colormixer.Location = new System.Drawing.Point(216, 18);
            this.Colormixer.Name = "Colormixer";
            this.Colormixer.Size = new System.Drawing.Size(121, 61);
            this.Colormixer.TabIndex = 11;
            this.Colormixer.Text = "All colors";
            this.Colormixer.UseVisualStyleBackColor = true;
            this.Colormixer.Click += new System.EventHandler(this.Colormixer_Click);
            // 
            // braon
            // 
            this.braon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.braon.FlatAppearance.BorderSize = 0;
            this.braon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.braon.Location = new System.Drawing.Point(174, 52);
            this.braon.Name = "braon";
            this.braon.Size = new System.Drawing.Size(36, 27);
            this.braon.TabIndex = 9;
            this.braon.UseVisualStyleBackColor = false;
            this.braon.Click += new System.EventHandler(this.brown_Click);
            // 
            // svetlozelena
            // 
            this.svetlozelena.BackColor = System.Drawing.Color.Lime;
            this.svetlozelena.FlatAppearance.BorderSize = 0;
            this.svetlozelena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.svetlozelena.Location = new System.Drawing.Point(132, 52);
            this.svetlozelena.Name = "svetlozelena";
            this.svetlozelena.Size = new System.Drawing.Size(36, 27);
            this.svetlozelena.TabIndex = 8;
            this.svetlozelena.UseVisualStyleBackColor = false;
            this.svetlozelena.Click += new System.EventHandler(this.lightgreen_Click);
            // 
            // svetloplava
            // 
            this.svetloplava.BackColor = System.Drawing.Color.Aqua;
            this.svetloplava.FlatAppearance.BorderSize = 0;
            this.svetloplava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.svetloplava.Location = new System.Drawing.Point(90, 51);
            this.svetloplava.Name = "svetloplava";
            this.svetloplava.Size = new System.Drawing.Size(36, 27);
            this.svetloplava.TabIndex = 7;
            this.svetloplava.UseVisualStyleBackColor = false;
            this.svetloplava.Click += new System.EventHandler(this.lightblue_Click);
            // 
            // roze
            // 
            this.roze.BackColor = System.Drawing.Color.Fuchsia;
            this.roze.FlatAppearance.BorderSize = 0;
            this.roze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roze.Location = new System.Drawing.Point(48, 51);
            this.roze.Name = "roze";
            this.roze.Size = new System.Drawing.Size(36, 27);
            this.roze.TabIndex = 6;
            this.roze.UseVisualStyleBackColor = false;
            this.roze.Click += new System.EventHandler(this.pink_Click);
            // 
            // crna
            // 
            this.crna.BackColor = System.Drawing.Color.Black;
            this.crna.FlatAppearance.BorderSize = 0;
            this.crna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crna.Location = new System.Drawing.Point(6, 51);
            this.crna.Name = "crna";
            this.crna.Size = new System.Drawing.Size(36, 27);
            this.crna.TabIndex = 5;
            this.crna.UseVisualStyleBackColor = false;
            this.crna.Click += new System.EventHandler(this.black_Click);
            // 
            // ljubicasta
            // 
            this.ljubicasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ljubicasta.FlatAppearance.BorderSize = 0;
            this.ljubicasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ljubicasta.Location = new System.Drawing.Point(174, 19);
            this.ljubicasta.Name = "ljubicasta";
            this.ljubicasta.Size = new System.Drawing.Size(36, 27);
            this.ljubicasta.TabIndex = 4;
            this.ljubicasta.UseVisualStyleBackColor = false;
            this.ljubicasta.Click += new System.EventHandler(this.purple_Click);
            // 
            // crvena
            // 
            this.crvena.BackColor = System.Drawing.Color.Red;
            this.crvena.FlatAppearance.BorderSize = 0;
            this.crvena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crvena.Location = new System.Drawing.Point(132, 19);
            this.crvena.Name = "crvena";
            this.crvena.Size = new System.Drawing.Size(36, 27);
            this.crvena.TabIndex = 3;
            this.crvena.UseVisualStyleBackColor = false;
            this.crvena.Click += new System.EventHandler(this.red_Click);
            // 
            // narandzasta
            // 
            this.narandzasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.narandzasta.FlatAppearance.BorderSize = 0;
            this.narandzasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.narandzasta.Location = new System.Drawing.Point(90, 18);
            this.narandzasta.Name = "narandzasta";
            this.narandzasta.Size = new System.Drawing.Size(36, 27);
            this.narandzasta.TabIndex = 2;
            this.narandzasta.UseVisualStyleBackColor = false;
            this.narandzasta.Click += new System.EventHandler(this.orange_Click);
            // 
            // zuta
            // 
            this.zuta.BackColor = System.Drawing.Color.Yellow;
            this.zuta.FlatAppearance.BorderSize = 0;
            this.zuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zuta.Location = new System.Drawing.Point(48, 19);
            this.zuta.Name = "zuta";
            this.zuta.Size = new System.Drawing.Size(36, 27);
            this.zuta.TabIndex = 1;
            this.zuta.UseVisualStyleBackColor = false;
            this.zuta.Click += new System.EventHandler(this.yellow_Click);
            // 
            // zelena
            // 
            this.zelena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.zelena.FlatAppearance.BorderSize = 0;
            this.zelena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zelena.Location = new System.Drawing.Point(6, 19);
            this.zelena.Name = "zelena";
            this.zelena.Size = new System.Drawing.Size(36, 27);
            this.zelena.TabIndex = 0;
            this.zelena.UseVisualStyleBackColor = false;
            this.zelena.Click += new System.EventHandler(this.green_Click);
            // 
            // favourite_color_pictureBox
            // 
            this.favourite_color_pictureBox.BackColor = System.Drawing.Color.LightGray;
            this.favourite_color_pictureBox.FlatAppearance.BorderSize = 0;
            this.favourite_color_pictureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favourite_color_pictureBox.Location = new System.Drawing.Point(67, 39);
            this.favourite_color_pictureBox.Name = "favourite_color_pictureBox";
            this.favourite_color_pictureBox.Size = new System.Drawing.Size(36, 27);
            this.favourite_color_pictureBox.TabIndex = 10;
            this.favourite_color_pictureBox.UseVisualStyleBackColor = false;
            this.favourite_color_pictureBox.Click += new System.EventHandler(this.favourite_color_pictreBox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.favourite_color_pictureBox);
            this.groupBox3.Location = new System.Drawing.Point(576, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 98);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Favourite color";
            // 
            // circle_rb
            // 
            this.circle_rb.AutoSize = true;
            this.circle_rb.CausesValidation = false;
            this.circle_rb.Location = new System.Drawing.Point(10, 62);
            this.circle_rb.Name = "circle_rb";
            this.circle_rb.Size = new System.Drawing.Size(51, 17);
            this.circle_rb.TabIndex = 14;
            this.circle_rb.Text = "Circle";
            this.circle_rb.UseVisualStyleBackColor = true;
            // 
            // rect_rb
            // 
            this.rect_rb.AutoSize = true;
            this.rect_rb.CausesValidation = false;
            this.rect_rb.Location = new System.Drawing.Point(10, 20);
            this.rect_rb.Name = "rect_rb";
            this.rect_rb.Size = new System.Drawing.Size(74, 17);
            this.rect_rb.TabIndex = 16;
            this.rect_rb.Text = "Rectangle";
            this.rect_rb.UseVisualStyleBackColor = true;
            // 
            // circle_radius_nud
            // 
            this.circle_radius_nud.CausesValidation = false;
            this.circle_radius_nud.Location = new System.Drawing.Point(67, 62);
            this.circle_radius_nud.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.circle_radius_nud.Name = "circle_radius_nud";
            this.circle_radius_nud.Size = new System.Drawing.Size(40, 20);
            this.circle_radius_nud.TabIndex = 15;
            this.circle_radius_nud.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "(radius)";
            // 
            // rectangle_width_nud
            // 
            this.rectangle_width_nud.CausesValidation = false;
            this.rectangle_width_nud.Location = new System.Drawing.Point(107, 16);
            this.rectangle_width_nud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rectangle_width_nud.Name = "rectangle_width_nud";
            this.rectangle_width_nud.Size = new System.Drawing.Size(38, 20);
            this.rectangle_width_nud.TabIndex = 17;
            this.rectangle_width_nud.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "(width)";
            // 
            // rectangle_height_nud
            // 
            this.rectangle_height_nud.CausesValidation = false;
            this.rectangle_height_nud.Location = new System.Drawing.Point(159, 16);
            this.rectangle_height_nud.Maximum = new decimal(new int[] {
            1214,
            0,
            0,
            0});
            this.rectangle_height_nud.Name = "rectangle_height_nud";
            this.rectangle_height_nud.Size = new System.Drawing.Size(38, 20);
            this.rectangle_height_nud.TabIndex = 18;
            this.rectangle_height_nud.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "(height)";
            // 
            // basic_pen_rb
            // 
            this.basic_pen_rb.AutoSize = true;
            this.basic_pen_rb.CausesValidation = false;
            this.basic_pen_rb.Enabled = false;
            this.basic_pen_rb.Location = new System.Drawing.Point(321, 16);
            this.basic_pen_rb.Name = "basic_pen_rb";
            this.basic_pen_rb.Size = new System.Drawing.Size(44, 17);
            this.basic_pen_rb.TabIndex = 22;
            this.basic_pen_rb.Text = "Pen";
            this.basic_pen_rb.UseVisualStyleBackColor = true;
            // 
            // spray_rb
            // 
            this.spray_rb.AutoSize = true;
            this.spray_rb.CausesValidation = false;
            this.spray_rb.Enabled = false;
            this.spray_rb.Location = new System.Drawing.Point(321, 39);
            this.spray_rb.Name = "spray_rb";
            this.spray_rb.Size = new System.Drawing.Size(52, 17);
            this.spray_rb.TabIndex = 11;
            this.spray_rb.Text = "Spray";
            this.spray_rb.UseVisualStyleBackColor = true;
            // 
            // game_cb
            // 
            this.game_cb.AutoSize = true;
            this.game_cb.Location = new System.Drawing.Point(12, 740);
            this.game_cb.Name = "game_cb";
            this.game_cb.Size = new System.Drawing.Size(81, 17);
            this.game_cb.TabIndex = 27;
            this.game_cb.Text = "GameMode";
            this.game_cb.UseVisualStyleBackColor = true;
            this.game_cb.CheckedChanged += new System.EventHandler(this.gameMode_Change);
            // 
            // end_game_btn
            // 
            this.end_game_btn.Location = new System.Drawing.Point(99, 738);
            this.end_game_btn.Name = "end_game_btn";
            this.end_game_btn.Size = new System.Drawing.Size(120, 21);
            this.end_game_btn.TabIndex = 29;
            this.end_game_btn.Text = "End GameMode";
            this.end_game_btn.UseVisualStyleBackColor = true;
            this.end_game_btn.Visible = false;
            this.end_game_btn.Click += new System.EventHandler(this.endGame_Click);
            // 
            // stopwatch_Control
            // 
            this.stopwatch_Control.Interval = 1000;
            this.stopwatch_Control.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.resetujSveToolStripMenuItem,
            this.sacuvajCrtezToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1286, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.oProgramuToolStripMenuItem.Text = "About";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.aboutSoftware_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.pomocToolStripMenuItem.Text = "Help";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.help_Click);
            // 
            // resetujSveToolStripMenuItem
            // 
            this.resetujSveToolStripMenuItem.Name = "resetujSveToolStripMenuItem";
            this.resetujSveToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.resetujSveToolStripMenuItem.Text = "Reset All";
            this.resetujSveToolStripMenuItem.Click += new System.EventHandler(this.resetAll_Click);
            // 
            // sacuvajCrtezToolStripMenuItem
            // 
            this.sacuvajCrtezToolStripMenuItem.Enabled = false;
            this.sacuvajCrtezToolStripMenuItem.Name = "sacuvajCrtezToolStripMenuItem";
            this.sacuvajCrtezToolStripMenuItem.Size = new System.Drawing.Size(211, 20);
            this.sacuvajCrtezToolStripMenuItem.Text = "Save drawing (not yet implemented)";
            this.sacuvajCrtezToolStripMenuItem.Click += new System.EventHandler(this.saveDrawing_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.eraser_rb);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.spray_radius_nud);
            this.groupBox4.Controls.Add(this.basic_pen_rb);
            this.groupBox4.Controls.Add(this.spray_rb);
            this.groupBox4.Controls.Add(this.rectangle_height_nud);
            this.groupBox4.Controls.Add(this.rect_rb);
            this.groupBox4.Controls.Add(this.rectangle_width_nud);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.circle_radius_nud);
            this.groupBox4.Controls.Add(this.circle_rb);
            this.groupBox4.Location = new System.Drawing.Point(759, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(513, 98);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tools";
            // 
            // eraser_rb
            // 
            this.eraser_rb.AutoSize = true;
            this.eraser_rb.Enabled = false;
            this.eraser_rb.Location = new System.Drawing.Point(321, 62);
            this.eraser_rb.Name = "eraser_rb";
            this.eraser_rb.Size = new System.Drawing.Size(55, 17);
            this.eraser_rb.TabIndex = 32;
            this.eraser_rb.Text = "Eraser";
            this.eraser_rb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(420, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "(radius)";
            // 
            // spray_radius_nud
            // 
            this.spray_radius_nud.CausesValidation = false;
            this.spray_radius_nud.Enabled = false;
            this.spray_radius_nud.Location = new System.Drawing.Point(376, 39);
            this.spray_radius_nud.Name = "spray_radius_nud";
            this.spray_radius_nud.Size = new System.Drawing.Size(38, 20);
            this.spray_radius_nud.TabIndex = 12;
            this.spray_radius_nud.TabStop = false;
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingCanvas.Location = new System.Drawing.Point(11, 131);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(1261, 602);
            this.drawingCanvas.TabIndex = 32;
            this.drawingCanvas.TabStop = false;
            this.drawingCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseClick);
            this.drawingCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseDown);
            this.drawingCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseMove);
            this.drawingCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 769);
            this.Controls.Add(this.drawingCanvas);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.end_game_btn);
            this.Controls.Add(this.game_cb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pen_width_nud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circle_radius_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_width_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_height_nud)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spray_radius_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button braon;
        private System.Windows.Forms.Button svetlozelena;
        private System.Windows.Forms.Button svetloplava;
        private System.Windows.Forms.Button roze;
        private System.Windows.Forms.Button crna;
        private System.Windows.Forms.Button ljubicasta;
        private System.Windows.Forms.Button crvena;
        private System.Windows.Forms.Button narandzasta;
        private System.Windows.Forms.Button zuta;
        private System.Windows.Forms.Button zelena;
        private System.Windows.Forms.Button favourite_color_pictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton circle_rb;
        private System.Windows.Forms.RadioButton rect_rb;
        private System.Windows.Forms.NumericUpDown circle_radius_nud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rectangle_width_nud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rectangle_height_nud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton basic_pen_rb;
        private System.Windows.Forms.ColorDialog color_mixer;
        private System.Windows.Forms.Button Colormixer;
        private System.Windows.Forms.RadioButton spray_rb;
        private System.Windows.Forms.CheckBox game_cb;
        private System.Windows.Forms.Button end_game_btn;
        private System.Windows.Forms.Timer stopwatch_Control;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetujSveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajCrtezToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spray_radius_nud;
        private System.Windows.Forms.NumericUpDown pen_width_nud;
        private System.Windows.Forms.RadioButton eraser_rb;
        private System.Windows.Forms.PictureBox drawingCanvas;
    }
}

