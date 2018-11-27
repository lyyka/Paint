using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        // colors
        Dictionary<Color, int> colors = new Dictionary<Color, int>()
        {
            {Color.FromArgb(0, 192, 0), 0},
            {Color.Yellow, 0},
            {Color.FromArgb(255, 128, 0), 0},
            {Color.Red, 0},
            {Color.FromArgb(192, 0, 192),0},
            {Color.Black, 0},
            {Color.Fuchsia,0},
            {Color.Aqua,0},
            {Color.Lime,0},
            {Color.FromArgb(192, 0, 0),0}
        };
        private Form5 frm5;
        Random _rnd = new Random();
        bool drawing = false;
        int xp, yp;
        // pen width
        int pencil_width = 5;
        // radius
        int radius;
        // game
        string game_mark;
        public int game_seconds;
        public int game_minutes;
        int width_p; int height_p;
        // favourite colors
        int green_color, yellow_color, orange_color, red_color, purple_color, black_color, pink_color, lightblue_color, lightgreen_color, brown_color;
        // pens
        Pen pen = new Pen (Color.Black, 5);
        Pen circle_pen = new Pen(Color.Black, 2);
        Pen rect_pen = new Pen(Color.Black, 2);
        Pen spray = new Pen(Color.Black, 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void gumica_Click(object sender, EventArgs e) // eraser
        {
            pen.Color = Color.White;
            radioButton3.Checked = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) // when mouse is pushed down
        {         
            drawing = true;
            xp = e.X;
            yp = e.Y;          
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) // while mouse is moving
        {
            if (drawing)
            {
                Graphics g = CreateGraphics();
                if (radioButton5.Checked)
                {
                    Pen temp = new Pen(Color.White, pencil_width);
                    g.DrawLine(temp, xp, yp, e.X, e.Y);
                    xp = e.X;
                    yp = e.Y;
                }
                if (radioButton3.Checked)
                {
                    g.DrawLine(pen, xp, yp, e.X, e.Y);
                    xp = e.X;
                    yp = e.Y;
                }
                if (radioButton4.Checked)
                {
                    int radius = Convert.ToInt32(numericUpDown4.Value);
                    using (g)
                    {
                        for (int i = 0; i < 100; ++i)
                        {
                            double theta = _rnd.NextDouble() * (Math.PI * 2);
                            double r = _rnd.NextDouble() * radius;
                            double x = e.X + Math.Cos(theta) * r;
                            double y = e.Y + Math.Sin(theta) * r;
                            g.DrawEllipse(spray, new Rectangle((int)x - 1, (int)y - 1, 1, 1));
                        }
                    }
                }
                g.Dispose();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) // when mouse is released
        {
            drawing = false;
        }

        private void favourite_color_pictreBox_Click(object sender, EventArgs e) // change current color to favourite color
        {
            pen.Color = favourite_color_pictureBox.BackColor;
            spray.Color = favourite_color_pictureBox.BackColor;
            circle_pen.Color = favourite_color_pictureBox.BackColor;
            rect_pen.Color = favourite_color_pictureBox.BackColor;
        }

        private void Colormixer_Click(object sender, EventArgs e) // open color mixer
        {
            colorDialog1.ShowDialog();
            pen.Color = colorDialog1.Color;
            spray.Color = colorDialog1.Color;
            circle_pen.Color = colorDialog1.Color;
            rect_pen.Color = colorDialog1.Color;
        }

        private void gameMode_Change(object sender, EventArgs e) // game mode on
        {
            if (igracb.Checked == true)
            {
                Refresh();
                Form5 frm5 = new Form5();
                frm5.Show();
            }
            if (igracb.Checked == false)
            {
                stopwatch_Control.Enabled = false;
            }
        }

        private void gameTime_Tick(object sender, EventArgs e) // game time
        {
            game_seconds++;
            if (game_seconds == 60)
            {
                game_seconds = 0;
                game_minutes++;
                if (game_minutes >= 0 && game_minutes < 3)
                {
                    game_mark = "A";
                }
                if (game_minutes >= 3 && game_minutes < 5)
                {
                    game_mark = "B";
                }
                if (game_minutes >= 5 && game_minutes < 6)
                {
                    game_mark = "C";
                }
                if (game_minutes >= 6 && game_minutes < 7)
                {
                    game_mark = "D";
                }
            }
        }

        private void endGame_Click(object sender, EventArgs e) // end game
        {
            if (igracb.Checked)
            {
                MessageBox.Show("You finished in " + game_minutes + " minute(s) and " + game_seconds + " seconds. Your mark is " + game_mark + ".");
                stopwatch_Control.Enabled = false;
                igracb.Checked = false;
            }
            else
            {
                MessageBox.Show("GameMode Off.");
            }
            frm5 = new Form5();
            frm5.Close();
        }

        private void startGame_Click(object sender, EventArgs e) // start game
        {
            if (igracb.Checked)
            {
                stopwatch_Control.Enabled = true;
            }
            else
            {
                MessageBox.Show("GameMode On.");
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e) // rectangle and circle drawing
        {
            //circle
            if (radioButton1.Checked == true)
            {
                radius = Convert.ToInt32(numericUpDown1.Value);
                Graphics g1 = CreateGraphics();
                g1.DrawEllipse(circle_pen, xp - radius, yp-radius, radius*2, radius*2);
                g1.Dispose();
            }
            //rectangle
            if (radioButton2.Checked == true)
            {
                width_p = Convert.ToInt32(numericUpDown2.Value);
                height_p = Convert.ToInt32(numericUpDown3.Value);
                Graphics g2 = CreateGraphics();
                g2.DrawRectangle(rect_pen, xp, yp, width_p, height_p);
                g2.Dispose();
            }
        }

        private void aboutSoftware_Click(object sender, EventArgs e) // about software
        {
            
        }

        private void help_Click(object sender, EventArgs e) // help
        {
            Help Help = new Help();
            Help.Show();
        }

        private void resetAll_Click(object sender, EventArgs e)
        {
            pencil_width = 5;
            numericUpDown5.Value = 5;
            pen.Color = Color.Black;
            circle_pen.Color = Color.Black;
            rect_pen.Color = Color.Black;
            favourite_color_pictureBox.BackColor = Color.White;
            radioButton3.Checked = true;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            igracb.Checked = false;
            Refresh();
        }

        private void saveDrawing_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Convert.ToInt32(1024), Convert.ToInt32(1024), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Rectangle boundaries = new Rectangle(0, 0, Width, Height);
            this.DrawToBitmap(bitmap, boundaries);
            bitmap.Save(@"test.png", ImageFormat.Png);
        }

        private void pencilWidth_Change(object sender, EventArgs e)
        {
            pencil_width = Convert.ToInt32(numericUpDown5.Value);
            pen.Width = pencil_width;
        }

        #region colorChanges

        private void getFavouriteColor()
        {
            List<KeyValuePair<Color, int>> sorted_colors = (from pair in colors
                                                            orderby pair.Value descending
                                                            select pair).ToList();

            favourite_color_pictureBox.BackColor = sorted_colors[0].Key;
            
        }

        private void ChangeColor(Color color)
        {

            if(pen.Color != color)
            {
                // increase for fav color
                colors[color]++;
                // set this color to all
                pen.Color = color;
                circle_pen.Color = color;
                rect_pen.Color = color;
                spray.Color = color;
                getFavouriteColor();
            }
            
        }

        private void green_Click(object sender, EventArgs e) // pchange to green
        {
            ChangeColor(Color.FromArgb(0, 192, 0));
        }

        private void yellow_Click(object sender, EventArgs e) // change to yellow
        {
            ChangeColor(Color.Yellow);
        }

        private void orange_Click(object sender, EventArgs e) // change to orange
        {
            ChangeColor(Color.FromArgb(255, 128, 0));
        }

        private void red_Click(object sender, EventArgs e) // change to red
        {
            ChangeColor(Color.Red);
        }

        private void purple_Click(object sender, EventArgs e) // change to purple
        {
            ChangeColor(Color.FromArgb(192, 0, 192));
        }

        private void black_Click(object sender, EventArgs e) // pchange to black
        {
            ChangeColor(Color.Black);
        }

        private void pink_Click(object sender, EventArgs e) // change to pink
        {
            ChangeColor(Color.Fuchsia);
        }

        private void lightblue_Click(object sender, EventArgs e)// change to light blue
        {
            ChangeColor(Color.Aqua);
        }

        private void lightgreen_Click(object sender, EventArgs e) // change to light green
        {
            ChangeColor(Color.Lime);
        }

        private void brown_Click(object sender, EventArgs e) // change to brown
        {
            ChangeColor(Color.FromArgb(192, 0, 0));
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e) // form load
        {
            Icon = new Icon(@"slike/ikonica.ico");
            igracb.Checked = false;
            radioButton3.Checked = true;
            Colormixer.FlatStyle = FlatStyle.Popup;
            zapocnibt.FlatStyle = FlatStyle.Popup;
            button8.FlatStyle = FlatStyle.Popup;
        }
    }
}
