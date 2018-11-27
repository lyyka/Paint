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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Image help2 = Image.FromFile(@"slike/help2.png");
            pictureBox1.Image = help2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
