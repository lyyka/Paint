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
        string current_file = "";
        // drawing buffers
        List<GObject> objects = new List<GObject>();
        List<GObject> last_saved = new List<GObject>();
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
        // coordinates on mouse down for drawing
        Color last_color;
        int x_pos, y_pos;
        // for drawing circles and reactangles real time
        int live_circle_rect_x;
        int live_circle_rect_y;
        // pens
        Pen pen = new Pen (Color.Black, 1);
        public MainForm()
        {
            InitializeComponent();
        }

        #region PICTUREBOX DRAWING 

        private void dcPaint(object sender, PaintEventArgs e)
        {
            if (rect_rb.Checked)
            {
                liveDrawRectangle(e.Graphics);
            }
            if (circle_rb.Checked)
            {
                liveDrawEllipse(e.Graphics);
            }
            Draw(e.Graphics);
        }

        // live draw functions

        private void liveDrawRectangle(Graphics g)
        {
            g.DrawRectangle(pen, x_pos, y_pos, live_circle_rect_x, live_circle_rect_y);
        }

        private void liveDrawEllipse(Graphics g)
        {
            g.DrawEllipse(pen, x_pos, y_pos, live_circle_rect_x, live_circle_rect_y);
        }

        // add txt callback from AddText form
        public void AddText(int xPos, int ypos, string text, Font font, Color color)
        {
            GObject new_text = new Text(xPos, ypos, text, font, color, pen.Width);
            objects.Add(new_text);

            drawingCanvas.Invalidate();
        }

        private void Draw(Graphics g)
        {
            if(last_saved.Count != objects.Count)
            {
                savedStatus_label.Text = "Pending changes";
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // will draw from saved

            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Draw(g);
            }
        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            // copy from objects to objects_copy
            List<GObject> objects_copy = new List<GObject>();
            for (int i = 0; i < objects.Count; i++)
            {
                objects_copy.Add(objects[i]);
            }
            // add list of current objects to steps, so user can undo to last made step
            steps.Add(objects_copy);
            // position on mouse down
            x_pos = e.X;
            y_pos = e.Y;


            // INTIALIZE ADD TEXT ON MOUSE DOWN
            if (text_rb.Checked)
            {
                AddText at = new AddText(pen.Color,x_pos,y_pos, this);
                at.Show();
            }
        }

        private void drawingCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            // save live drawn shapes on mouse up
            if (rect_rb.Checked)
            {
                GObject new_rect = new Rect(x_pos, y_pos, live_circle_rect_x, live_circle_rect_y, pen.Color, pen.Width);
                objects.Add(new_rect);
            }
            if (circle_rb.Checked)
            {
                GObject new_ellipse = new Ellipse(x_pos, y_pos, live_circle_rect_x, live_circle_rect_y, pen.Color, pen.Width);
                objects.Add(new_ellipse);
            }
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
                        eraser_rb.Checked ? Color.White : pen.Color,
                        pen.Width
                    );
                    objects.Add(new_line);
                    x_pos = new_x_pos;
                    y_pos = new_y_pos;
                    drawingCanvas.Invalidate();
                }
                // save spray
                if (spray_rb.Checked)
                {
                    int spray_radius = Convert.ToInt32(pen.Width);
                    for (int i = 0; i < 100; ++i)
                    {
                        double theta = _rnd.NextDouble() * (Math.PI * 2);
                        double r = _rnd.NextDouble() * spray_radius;
                        double x = new_x_pos + Math.Cos(theta) * r;
                        double y = new_y_pos + Math.Sin(theta) * r;

                        GObject ellipse = new Ellipse((int)x - 1, (int)y - 1, 1, 1, pen.Color, 1);
                        objects.Add(ellipse);
                    }
                    drawingCanvas.Invalidate();
                }
                // draw rectangle on mouse move
                if (rect_rb.Checked || circle_rb.Checked)
                {
                    live_circle_rect_x = new_x_pos - x_pos;
                    live_circle_rect_y = new_y_pos - y_pos;

                    drawingCanvas.Invalidate();
                }
            }
        }

        #endregion

        #region MENU

        private void newDrawing_ts_Click(object sender, EventArgs e) // new drawing
        {
            CanvasSettings cs = new CanvasSettings(this, true);
            cs.Show();
        }

        private void openDrawing_ts_Click(object sender, EventArgs e) // open existing drawing
        {
            openDrawing_Dialog.ShowDialog();
            if(openDrawing_Dialog.FileName.Trim() != "")
            {
                string file_name = openDrawing_Dialog.FileName;
                if(objects.Count > 0)
                {
                    DialogResult dg = MessageBox.Show("By opening new file your current progress will be lost! Are you sure you want to do this?", "Warning!", MessageBoxButtons.YesNo);

                    if (dg == DialogResult.Yes)
                    {
                        openImage(file_name);
                    }
                }
                else
                {
                    openImage(file_name);
                }
            }
        }

        private void openImage(string file_name)
        {
            current_file = file_name;
            Text = "Current: " + current_file;
            Image opened = Image.FromFile(current_file);
            drawingCanvas.Width = opened.Width;
            drawingCanvas.Height = opened.Height;
            drawingCanvas.BackgroundImage = opened;
        }

        private void saveDrawing_ts_Click(object sender, EventArgs e) // just save
        {
            if(current_file.Trim().Length > 0 && File.Exists(current_file))
            {
                Bitmap bmp = new Bitmap(drawingCanvas.ClientSize.Width, drawingCanvas.ClientSize.Height);
                drawingCanvas.DrawToBitmap(bmp, drawingCanvas.ClientRectangle);
                bmp.Save(current_file);
                setSaved();
            }
            else
            {
                SaveAs();
            }
        }

        private void saveAs_ts_Click(object sender, EventArgs e) // save as
        {
            SaveAs();
        }

        private void SaveAs() // save as
        {
            Bitmap bmp = new Bitmap(drawingCanvas.ClientSize.Width, drawingCanvas.ClientSize.Height);
            drawingCanvas.DrawToBitmap(bmp, drawingCanvas.ClientRectangle);

            saveDrawing_Dialog.ShowDialog();

            if (saveDrawing_Dialog.FileName != "")
            {
                bmp.Save(saveDrawing_Dialog.FileName);

                Text = "Current: " + saveDrawing_Dialog.FileName;

                current_file = saveDrawing_Dialog.FileName;
            }
            setSaved();
        }
        private void setSaved() // save saved objects, so we have what to compare if changes occured
        {
            savedStatus_label.Text = "Changes saved";
            for (int i = 0; i < objects.Count; i++)
            {
                last_saved.Add(objects[i]);
            }
        }

        private void canvasSettings_ts_Click(object sender, EventArgs e) // settings
        {
            CanvasSettings cs = new CanvasSettings(this, false);
            cs.Show();
        }

        private void resetAll_Click(object sender, EventArgs e) // reset all
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
        }

        private void undo_ts_Click(object sender, EventArgs e) // undo
        {
            if (steps.Count > 0)
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

        private void aboutSoftware_Click(object sender, EventArgs e) // about software
        {
            About abt = new About();
            abt.Show();
        }

        #endregion

        private void pencilWidth_Change(object sender, EventArgs e)
        {
            pen.Width = Convert.ToInt32(pen_width_nud.Value);
        }

        #region colorChanges

        private void getMostUsedColor()
        {
            List<KeyValuePair<Color, int>> sorted_colors = (from pair in colors
                                                            orderby pair.Value descending
                                                            select pair).ToList();

            mostUsedColor_pb.BackColor = sorted_colors[0].Key;
            
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
                getMostUsedColor();
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

        private void colorBox_Click(object sender, EventArgs e) // on color boxes click
        {
            Button colorButton_clicked = sender as Button;

            if (colors.ContainsKey(colorButton_clicked.BackColor))
            {
                ChangeColor(colorButton_clicked.BackColor);
            }
        }

        #endregion

        public void initCanvas(int width, int height, bool full_refresh)
        {
            if (full_refresh)
            {
                current_file = "";
                Text = "Current file: Untitled";
                saveAs_ts.Enabled = true;
                saveDrawing_ts.Enabled = true;
                objects.Clear();
            }
            drawingCanvas.Refresh();

            drawingCanvas.Width = width;
            drawingCanvas.Height = height;
            sizeValue_label.Text = width + "x" + height;
            drawingCanvas.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e) // form load
        {
            // select basic pen drawing method
            basic_pen_rb.Checked = true;
            // click events for colors
            greenColor.Click += colorBox_Click;
            yellowColor.Click += colorBox_Click;
            orangeColor.Click += colorBox_Click;
            redColor.Click += colorBox_Click;
            purpleColor.Click += colorBox_Click;
            whiteColor.Click += colorBox_Click;
            blackColor.Click += colorBox_Click;
            aquaColor.Click += colorBox_Click;
            limeColor.Click += colorBox_Click;
            brownColor.Click += colorBox_Click;
            mostUsedColor_pb.Click += colorBox_Click;
            // paint event
            drawingCanvas.Paint += dcPaint;

            initCanvas(drawingCanvas.Width, drawingCanvas.Height, true);
        }
    }
}
