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
    public partial class GameTask : Form
    {
        public GameTask()
        {
            InitializeComponent();
        }

        private void GameTask_Load(object sender, EventArgs e)
        {
            string[] tasks = new string[]
            {
                "Christmas Tree with decorations and gifts",
                "Car on a road",
                "A building",
                "Animal of choice",
                "A person",
                "Your favourite sport",
                "Your school building",
                "Favourite super hero",
                "Favourite cartoon charachter"
            };
            Random ran = new Random();
            int random_index = ran.Next(0, tasks.Length);

            task_tb.Text = tasks[random_index];
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
