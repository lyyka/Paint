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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            Image picture = Image.FromFile(@"images/palette.jpg");
            palette_image.BackgroundImage = picture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
