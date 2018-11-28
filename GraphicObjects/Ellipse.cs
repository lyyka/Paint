using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicObjects
{
    public class Ellipse
    {
        int x_pos;
        int y_pos;
        int x_size;
        int y_size;
        public Ellipse(int x_pos, int y_pos, int x_size, int y_size)
        {
            this.x_pos = x_pos;
            this.y_pos = y_pos;
            this.x_size = x_size;
            this.y_size = y_size;
        }

        public int xPos
        {
            get { return x_pos; }
        }
        public int yPos
        {
            get { return y_pos; }
        }
        public int xSize
        {
            get { return x_size; }
        }
        public int ySize
        {
            get { return y_size; }
        }
    }
}
