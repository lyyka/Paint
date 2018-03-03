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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string prvasl = "Bozicna jelka sa ukrasima i poklonima";
            string drugasl = "Automobil i put";
            string trecasl = "Stambena zgrada";
            string cetvrtasl = "Zivotinja po izboru";
            string petasl = "Covek";
            string sestasl = "Sport po izboru";
            string sedmasl = "Skola u koju ides";
            string osmasl = "Omiljeni super junak";
            string devetasl = "Omiljeni crtani junak";
            Random ran = new Random();
            int sl = ran.Next(1, 10);
            switch (sl)
            {
                case 1:
                    igratb.Text = "U ovoj igri nacrtaj: "+prvasl;
                    break;
                case 2:
                    igratb.Text = "U ovoj igri nacrtaj: " + drugasl;
                    break;
                case 3:
                    igratb.Text = "U ovoj igri nacrtaj: " + trecasl;
                    break;
                case 4:
                    igratb.Text = "U ovoj igri nacrtaj: " + cetvrtasl;
                    break;
                case 5:
                    igratb.Text = "U ovoj igri nacrtaj: " + petasl;
                    break;
                case 6:
                    igratb.Text = "U ovoj igri nacrtaj: " + sestasl;
                    break;
                case 7:
                    igratb.Text = "U ovoj igri nacrtaj: " + sedmasl;
                    break;
                case 8:
                    igratb.Text = "U ovoj igri nacrtaj: " + osmasl;
                    break;
                case 9:
                    igratb.Text = "U ovoj igri nacrtaj:" + devetasl;
                    break;
            }
        }

        private void izadjibt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
