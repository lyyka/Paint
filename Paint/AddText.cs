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
    public partial class AddText : Form
    {
        Color current_color;
        MainForm caller;
        int xPos;
        int yPos;

        public AddText(Color current_color, int xPos, int yPos, MainForm caller)
        {
            this.current_color = current_color;
            this.xPos = xPos;
            this.yPos = yPos;
            this.caller = caller;

            InitializeComponent();
        }

        private void AddText_Load(object sender, EventArgs e)
        {
            Text = "(" + xPos + "," + yPos + ")";
            // load all fonts
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fontFamily_cb.Items.Add(font.Name);
            }
            // set current color
            currentColor_pb.BackColor = current_color;
        }

        private void coloMixer_Click(object sender, EventArgs e)
        {
            color_mixer.ShowDialog();
            if (color_mixer.Color != null)
            {
                Color response = color_mixer.Color;
                // add to dictionary for further counting 
                current_color = response;
                // make changes
                currentColor_pb.BackColor = current_color;
            }
        }

        private void addText_btn_Click(object sender, EventArgs e)
        {
            float font_size = (float)fontSize_nud.Value;
            string text = text_to_add.Text.Trim();
            if(text.Length > 0)
            {
                Font new_font = new Font(fontFamily_cb.Items[fontFamily_cb.SelectedIndex].ToString(), font_size);
                caller.AddText(xPos, yPos, text, new_font, current_color);
            }
            else
            {
                MessageBox.Show("Text is empty!");
            }
        }

        private void fontFamily_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font preview_font = new Font(fontFamily_cb.Items[fontFamily_cb.SelectedIndex].ToString(), 12);
            previewLabel.Font = preview_font;
        }
    }
}
