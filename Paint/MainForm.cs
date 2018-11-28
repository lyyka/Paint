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
using GraphicObjects;

namespace Paint
{
    public partial class MainForm : Form
    {
        // drawing buffers
        List<Rectangle> rectangles = new List<Rectangle>();
        List<Ellipse> ellipses = new List<Ellipse>();
        // colors - only basic ones. When user chooses from color mixer, that color is added too.
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
        Random _rnd = new Random();
        // indicates if the user's mouse is pressed down on the canvas
        bool drawing = false;
        // coordinates on mouse move
        int new_x_pos, new_y_pos;
        // coordinats on mouse down
        int x_pos, y_pos;
        // pen width
        int pencil_width = 5;
        // game
        string game_mark;
        public int game_seconds;
        public int game_minutes;
        // pens
        Pen pen = new Pen (Color.Black, 5);
        Pen circle_pen = new Pen(Color.Black, 2);
        Pen rect_pen = new Pen(Color.Black, 2);
        Pen spray = new Pen(Color.Black, 1);
        public MainForm()
        {
            InitializeComponent();
        }

        #region PICTUREBOX DRAWING 

        private void dcPaint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void Draw(Graphics g)
        {
            // will draw from saved

            // draw rectangles
            for(int i = 0; i < rectangles.Count; i++)
            {
                g.DrawRectangle(rect_pen, rectangles[i]);
            }
            // draw ellipses
            for (int i = 0; i < ellipses.Count; i++)
            {
                g.DrawEllipse(circle_pen, ellipses[i].xPos, ellipses[i].yPos, ellipses[i].xSize, ellipses[i].ySize);
            }
        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            x_pos = e.X;
            y_pos = e.Y;
        }

        private void drawingCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void drawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            new_x_pos = e.X;
            new_y_pos = e.Y;

            if (drawing)
            {
                //// eraser
                //if (eraser_rb.Checked)
                //{
                //    Pen temp_eraser_pen = new Pen(Color.White, pencil_width);
                //    g.DrawLine(pen, x_pos, y_pos, new_x_pos, new_y_pos);
                //    x_pos = new_x_pos;
                //    y_pos = new_y_pos;
                //}
                //// basic pen
                //if (basic_pen_rb.Checked)
                //{
                //    g.DrawLine(pen, x_pos, y_pos, new_x_pos, new_y_pos);
                //    x_pos = new_x_pos;
                //    y_pos = new_y_pos;
                //}
                //// spray
                //if (spray_rb.Checked)
                //{
                //    int spray_radius = Convert.ToInt32(spray_radius_nud.Value);
                //    for (int i = 0; i < 100; ++i)
                //    {
                //        double theta = _rnd.NextDouble() * (Math.PI * 2);
                //        double r = _rnd.NextDouble() * spray_radius;
                //        double x = new_x_pos + Math.Cos(theta) * r;
                //        double y = new_y_pos + Math.Sin(theta) * r;
                //        g.DrawEllipse(spray, new Rectangle((int)x - 1, (int)y - 1, 1, 1));
                //    }
                //}
            }

            drawingCanvas.Invalidate();
        }

        private void drawingCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // circle
            if (circle_rb.Checked == true)
            {
                int circle_radius = Convert.ToInt32(circle_radius_nud.Value);
                Ellipse new_ellipse = new Ellipse(x_pos - circle_radius, y_pos - circle_radius, circle_radius * 2, circle_radius * 2);
                ellipses.Add(new_ellipse);
            }
            // rectangle
            if (rect_rb.Checked == true)
            {
                int rect_width = Convert.ToInt32(rectangle_width_nud.Value);
                int rect_height = Convert.ToInt32(rectangle_height_nud.Value);
                Rectangle new_rect = new Rectangle(x_pos, y_pos, rect_width, rect_height);
                rectangles.Add(new_rect);
            }

            drawingCanvas.Invalidate();
        }

        #endregion

        #region game

        private void gameMode_Change(object sender, EventArgs e) // game mode on
        {
            if (game_cb.Checked == true)
            {
                // clear canvas
                Refresh();
                // show the game task
                GameTask game_task_window = new GameTask();
                game_task_window.Show();
                // start the game
                MessageBox.Show("GameMode On.");
                stopwatch_Control.Enabled = true;
                // show end game button
                end_game_btn.Visible = true;
            }
            if (game_cb.Checked == false)
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
            if (game_cb.Checked)
            {
                if(game_minutes == 0)
                {
                    game_mark = "A";
                }
                MessageBox.Show("You finished in " + game_minutes + " minute(s) and " + game_seconds + " seconds. Your mark is " + game_mark + ".");
                stopwatch_Control.Enabled = false;
                game_cb.Checked = false;

                this.Visible = false;
            }
        }

        #endregion

        #region MENU
        private void aboutSoftware_Click(object sender, EventArgs e) // about software
        {
            About abt = new About();
            abt.Show();
        }

        private void help_Click(object sender, EventArgs e) // help
        {
            Help Help = new Help();
            Help.Show();
        }
        #endregion


        private void resetAll_Click(object sender, EventArgs e)
        {
            // pen width
            pencil_width = 5;
            pen_width_nud.Value = 5;
            ChangeColor(Color.Black);
            // check basic pen input method
            basic_pen_rb.Checked = true;
            // reset numeric-up-down values
            circle_radius_nud.Value = 0;
            rectangle_width_nud.Value = 0;
            rectangle_height_nud.Value = 0;
            spray_radius_nud.Value = 0;
            // disable game mode
            game_cb.Checked = false;
            // clear drawings
            Refresh();
        }

        private void saveDrawing_Click(object sender, EventArgs e)
        {
            // NOT WORKING FOR NOW
            Bitmap bitmap = new Bitmap(Convert.ToInt32(1024), Convert.ToInt32(1024), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Rectangle boundaries = new Rectangle(0, 0, Width, Height);
            this.DrawToBitmap(bitmap, boundaries);
            bitmap.Save(@"test.png", ImageFormat.Png);
        }

        private void pencilWidth_Change(object sender, EventArgs e)
        {
            pencil_width = Convert.ToInt32(pen_width_nud.Value);
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
                // get the favourite one
                getFavouriteColor();
            }
            
        }

        private void favourite_color_pictreBox_Click(object sender, EventArgs e) // change current color to favourite color
        {
            ChangeColor(favourite_color_pictureBox.BackColor);
        }

        private void Colormixer_Click(object sender, EventArgs e) // open color mixer
        {
            color_mixer.ShowDialog();
            if (color_mixer.Color != null)
            {
                Color response = color_mixer.Color;
                // add to dictionary for further counting 
                colors.Add(response, 0);
                // make changes
                ChangeColor(response);
            }
        }

        private void green_Click(object sender, EventArgs e) // change to green
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

        private void MainForm_Load(object sender, EventArgs e) // form load
        {
            Icon = new Icon(@"images/icon.ico");
            game_cb.Checked = false;
            basic_pen_rb.Checked = true;
            Colormixer.FlatStyle = FlatStyle.Popup;
            end_game_btn.FlatStyle = FlatStyle.Popup;
            // paint event
            drawingCanvas.Paint += dcPaint;
        }
    }
}
