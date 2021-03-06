﻿using System;
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
            Icon = new Icon(@"images/icon.ico");
            palette_image.BackgroundImage = Image.FromFile(@"images/palette.jpg");
        }

        private void closeAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
