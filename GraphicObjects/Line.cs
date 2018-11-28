using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicObjects
{
    public class Line : GObject
    {
        public int xStart { get; set; }
        public int yStart { get; set; }
        public int xEnd { get; set; }
        public int yEnd { get; set; }

        public Line(int x_start, int y_start, int x_end, int y_end, Color pen_color, float pen_width)
            : base(pen_color, pen_width)
        {
            xStart = x_start;
            yStart = y_start;
            xEnd = x_end;
            yEnd = y_end;
        }

        public override void Draw(Graphics g)
        {
            Pen temp_pen = new Pen(penColor, penWidth);
            g.DrawLine(temp_pen, xStart, yStart, xEnd, yEnd);
        }
        
    }
}
