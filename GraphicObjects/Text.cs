using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicObjects
{
    public class Text : GObject
    {
        public int xPos { get; set; }
        public int yPos { get; set; }
        public string text { get; set; }
        public Font font { get; set; }

        public Text(int xPos, int yPos, string text, Font font, Color pen_color, float pen_width)
            : base(pen_color, pen_width)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.text = text;
            this.font = font;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(base.penColor);
            g.DrawString(text, font, brush, xPos, yPos);
        }
    }
}
