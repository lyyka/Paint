using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class CanvasSettings : Form
    {
        MainForm main_form;
        bool new_canvas; // indicates if the user wants to change something or wants new canvas

        // if already set up in main form
        int canvas_width;
        int canvas_height;

        public CanvasSettings(MainForm main_form, bool new_canvas)
        {
            this.main_form = main_form;
            this.new_canvas = new_canvas;

            InitializeComponent();
        }

        private void CanvasSettings_Load(object sender, EventArgs e)
        {
            if (main_form.drawingCanvas.Visible && !new_canvas)
            {
                canvas_width = main_form.drawingCanvas.Width;
                canvas_height = main_form.drawingCanvas.Height;

                canvasWidth.Value = canvas_width;
                canvasHeight.Value = canvas_height;
            }
        }

        private void invertValues_btn_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(canvasWidth.Value);
            canvasWidth.Value = canvasHeight.Value;
            canvasHeight.Value = temp;
        }

        private void createCanvas_Click(object sender, EventArgs e)
        {
            if (main_form.drawingCanvas.Visible && new_canvas)
            {
                DialogResult dg = MessageBox.Show("By creating new canvas your current progress will be lost! Are you sure you want to do this?", "Warning!", MessageBoxButtons.YesNo);

                if (dg == DialogResult.Yes)
                {
                    setUpCanvas();
                }
            }
            else
            {
                setUpCanvas();
            }
        }

        private void setUpCanvas()
        {
            canvas_width = Convert.ToInt32(canvasWidth.Value);
            canvas_height = Convert.ToInt32(canvasHeight.Value);

            main_form.initCanvas(canvas_width, canvas_height, new_canvas);

            this.Close();
        }
    }
}
