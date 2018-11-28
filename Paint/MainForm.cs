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
        List<GObject> objects = new List<GObject>();
        List<List<GObject>> steps = new List<List<GObject>>();
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
        Color last_color;
        int x_pos, y_pos;
        // game
        string game_mark;
        public int game_seconds;
        public int game_minutes;
        // pens
        Pen pen = new Pen (Color.Black, 1);
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

            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Draw(g);
            }
        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            List<GObject> objects_copy = new List<GObject>();
            for(int i = 0; i < objects.Count; i++)
            {
                objects_copy.Add(objects[i]);
            }
            steps.Add(objects_copy);
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
                // save eraser and basic pen (both are just lines, colors differ)
                if (eraser_rb.Checked || basic_pen_rb.Checked)
                {
                    GObject new_line = new Line(
                        x_pos, y_pos, new_x_pos, new_y_pos,
                        pen.Color,
                        pen.Width
                    );
                    objects.Add(new_line);
                    drawingCanvas.Invalidate();
                    x_pos = new_x_pos;
                    y_pos = new_y_pos;
                }
                // save spray
                if (spray_rb.Checked)
                {
                    int spray_radius = Convert.ToInt32(spray_radius_nud.Value);
                    for (int i = 0; i < 100; ++i)
                    {
                        double theta = _rnd.NextDouble() * (Math.PI * 2);
                        double r = _rnd.NextDouble() * spray_radius;
                        double x = new_x_pos + Math.Cos(theta) * r;
                        double y = new_y_pos + Math.Sin(theta) * r;

                        GObject ellipse = new Ellipse((int)x - 1, (int)y - 1, 1, 1, pen.Color, pen.Width);
                        objects.Add(ellipse);
                    }
                    Rectangle invalidate_rect = new Rectangle(Convert.ToInt32(new_x_pos - spray_radius - pen.Width), Convert.ToInt32(new_y_pos - spray_radius - pen.Width), Convert.ToInt32(spray_radius * 2), Convert.ToInt32(spray_radius * 2));
                    drawingCanvas.Invalidate(invalidate_rect);
                }
            }
        }

        private void drawingCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // save ellipses
            if (circle_rb.Checked == true)
            {
                int circle_radius = Convert.ToInt32(circle_radius_nud.Value);
                GObject new_ellipse = new Ellipse(x_pos - circle_radius, y_pos - circle_radius, circle_radius * 2, circle_radius * 2,
                        pen.Color,
                        pen.Width);
                objects.Add(new_ellipse);

                Rectangle invalidate_rect = new Rectangle(Convert.ToInt32(x_pos - circle_radius - pen.Width), Convert.ToInt32(y_pos - circle_radius - pen.Width), Convert.ToInt32(circle_radius * 2 + 2*pen.Width), Convert.ToInt32(circle_radius * 2 + 2*pen.Width));
                drawingCanvas.Invalidate(invalidate_rect);
            }
            // save rectangles
            if (rect_rb.Checked == true)
            {
                int rect_width = Convert.ToInt32(rectangle_width_nud.Value);
                int rect_height = Convert.ToInt32(rectangle_height_nud.Value);
                GObject new_rect = new Rect(x_pos, y_pos, rect_width, rect_height,
                        pen.Color,
                        pen.Width);
                objects.Add(new_rect);

                Rectangle invalidate_rect = new Rectangle(Convert.ToInt32(x_pos - pen.Width),Convert.ToInt32(y_pos - pen.Width), Convert.ToInt32(rect_width + 2*pen.Width), Convert.ToInt32(rect_height + 2*pen.Width));
                drawingCanvas.Invalidate(invalidate_rect);
            }

            
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

        private void undo_ts_Click(object sender, EventArgs e) // undo
        {
            if(steps.Count > 0)
            {
                objects = steps[steps.Count - 1];
                steps.RemoveAt(steps.Count - 1);
                drawingCanvas.Invalidate();
            }
            else
            {
                MessageBox.Show("No more steps back.");
            }
        }
        #endregion


        private void resetAll_Click(object sender, EventArgs e)
        {
            // clear buffers
            objects.Clear();
            // clear drawings
            drawingCanvas.Refresh();
            // pen width
            pen_width_nud.Value = 1;
            pen.Width = 1;
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
        }

        private void saveDrawing_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(drawingCanvas.ClientSize.Width, drawingCanvas.ClientSize.Height);
            drawingCanvas.DrawToBitmap(bmp, drawingCanvas.ClientRectangle);

            saveDrawing_Dialog.ShowDialog();

            if(saveDrawing_Dialog.FileName != null)
            {
                bmp.Save(saveDrawing_Dialog.FileName);
            }
        }

        private void pencilWidth_Change(object sender, EventArgs e)
        {
            pen.Width = Convert.ToInt32(pen_width_nud.Value);
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
                // get the favourite one
                getFavouriteColor();
            }
            
        }

        private void eraser_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (eraser_rb.Checked)
            {
                last_color = pen.Color;
                pen.Color = Color.White;
            }
            else
            {
                pen.Color = last_color;
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
                try
                {
                    // mayebe this color is already added, and sameKey exception will be thrown for dictionary
                    colors.Add(response, 0);
                }
                catch { }
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
