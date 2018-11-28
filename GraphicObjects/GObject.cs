using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicObjects
{
    public abstract class GObject
    {
        // color this was drawn with
        public Color penColor { get; set; }

        // width of the pen
        public float penWidth { get; set; }

        public GObject(Color pen_color, float pen_width)
        {
            penColor = pen_color;

            penWidth = pen_width;
        }

        public abstract void Draw(Graphics g);
    }
}
