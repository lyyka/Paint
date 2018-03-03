using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        // deklaracija promenljivih
        private Form3 frm3;
        private Form5 frm5;
        Random _rnd = new Random();
        bool crtanje = false;
        Pen olovkasprej = new Pen(Color.Black, 1);
        int xp, yp;
        string ocena;
        int r, g, b;
        int debolovke = 5;
        int poluprecnik;
        public int stoperitza;
        public int minuti;
        int sirinap; int visinap;
        int zelenab, zutab, narandzastab, crvenab, ljubicastab, crnab, rozeb, svetloplavab, svetlozelenab, braonb;
        Pen olovka = new Pen (Color.Black, 5);
        Pen olovkakurg = new Pen(Color.Black, 2);
        Pen olovkapravoug = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
        }
        private void zelena_Click(object sender, EventArgs e) // promena boje u zelenu
        {
            olovka.Color = Color.FromArgb(0, 192, 0);
            olovkakurg.Color = Color.FromArgb(0, 192, 0);
            olovkapravoug.Color = Color.FromArgb(0, 192, 0);
            olovkasprej.Color = Color.FromArgb(0, 192, 0);
            zelenab++;
        }
        private void button3_Click(object sender, EventArgs e)// omiljena boja
        {
            if (zelenab == 0 && zutab == 0 && narandzastab == 0 && crvenab == 0 && ljubicastab == 0 && crnab == 0 && rozeb == 0 && svetloplavab == 0 && svetlozelenab == 0 && braonb == 0)
            {
                MessageBox.Show("Jos niste izabrali ni jednu boju.");
            }
            else
            {
                int[] niz = { zelenab, zutab, narandzastab, crvenab, ljubicastab, crnab, rozeb, svetloplavab, svetlozelenab, braonb }; // odredjivanje omiljene boje
                int omiljenab = niz.Max();
                if (omiljenab == zelenab)
                {
                    omiljenaboja.BackColor = Color.FromArgb(0, 192, 0);
                }
                if (omiljenab == zutab)
                {
                    omiljenaboja.BackColor = Color.Yellow;
                }
                if (omiljenab == narandzastab)
                {
                    omiljenaboja.BackColor = Color.FromArgb(255, 128, 0);
                }
                if (omiljenab == crvenab)
                {
                    omiljenaboja.BackColor = Color.Red;
                }
                if (omiljenab == ljubicastab)
                {
                    omiljenaboja.BackColor = Color.FromArgb(192, 0, 192);
                }
                if (omiljenab == crnab)
                {
                    omiljenaboja.BackColor = Color.Black;
                }
                if (omiljenab == rozeb)
                {
                    omiljenaboja.BackColor = Color.Fuchsia;
                }
                if (omiljenab == svetloplavab)
                {
                    omiljenaboja.BackColor = Color.Aqua;
                }
                if (omiljenab == svetlozelenab)
                {
                    omiljenaboja.BackColor = Color.Lime;
                }
                if (omiljenab == braonb)
                {
                    omiljenaboja.BackColor = Color.FromArgb(192, 0, 0);
                }
            }
        }

        private void gumica_Click(object sender, EventArgs e) // gumica
        {
            olovka.Color = Color.White;
            radioButton3.Checked = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) // kada se klikne mis 
        {         
            crtanje = true;
            xp = e.X;
            yp = e.Y;          
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //dok se mis pomera 
        {

            if (crtanje)
            {
                if(radioButton3.Checked == true)
                {
                    Graphics g = CreateGraphics();
                    g.DrawLine(olovka, xp, yp, e.X, e.Y);
                    xp = e.X;
                    yp = e.Y;
                    g.Dispose();
                }
                if (radioButton4.Checked == true) // jedini deo koda skinut sa interneta
                {
                    int radius = 15;

                    using (Graphics g = this.CreateGraphics())
                    {
                        for (int i = 0; i < 100; ++i)
                        {
                            double theta = _rnd.NextDouble() * (Math.PI * 2);
                            double r = _rnd.NextDouble() * radius;
                            double x = e.X + Math.Cos(theta) * r;
                            double y = e.Y + Math.Sin(theta) * r;
                            g.DrawEllipse(olovkasprej, new Rectangle((int)x - 1, (int)y - 1, 1, 1));
                        }
                    }
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) //kada se pusti levi taster misa
        {
            crtanje = false;
        }

        private void button1_Click(object sender, EventArgs e) // povecavanje debljine olovke
        {
            if(debolovke >= 100)
            {
                MessageBox.Show("Debljina olovke ne moze biti veca od 100");
            }
            else
            {
                debolovke++;
                debljinaolovke.Text = Convert.ToString(debolovke);
                olovka.Width = debolovke;
            }
        }

        private void button2_Click(object sender, EventArgs e) // smanjivanje debljine olovke
        {
            if(debolovke - 1 >= 1)
            {
                debolovke--;
                debljinaolovke.Text = Convert.ToString(debolovke);
                olovka.Width = debolovke;
            }
            else
            {
                MessageBox.Show("Ne mozete smanjiti debljinu olovke na vrednost manju od 1.");
            }
        }

        private void button4_Click(object sender, EventArgs e) // izbrisi sve
        {
            Refresh();
        }

        private void omiljenaboja_Click(object sender, EventArgs e) // promena boje olovke u omiljenu boju
        {
            if (omiljenaboja.BackColor == Color.FromArgb(0, 192, 0))
            {
                olovka.Color = Color.FromArgb(0, 192, 0);

            }
            if (omiljenaboja.BackColor == Color.Yellow)
            {
                olovka.Color = Color.Yellow;
            }
            if (omiljenaboja.BackColor == Color.FromArgb(255, 128, 0))
            {
                olovka.Color = Color.FromArgb(255, 128, 0);
            }
            if (omiljenaboja.BackColor == Color.Red)
            {
                olovka.Color = Color.Red;
            }
            if (omiljenaboja.BackColor == Color.FromArgb(192, 0, 192))
            {
                olovka.Color = Color.FromArgb(192, 0, 192);
            }
            if (omiljenaboja.BackColor == Color.Black)
            {
                olovka.Color = Color.Black;
            }
            if (omiljenaboja.BackColor == Color.Fuchsia)
            {
                olovka.Color = Color.Fuchsia;
            }
            if (omiljenaboja.BackColor == Color.Aqua)
            {
                olovka.Color = Color.Aqua;
            }
            if (omiljenaboja.BackColor == Color.Lime)
            {
                olovka.Color = Color.Lime;
            }
            if (omiljenaboja.BackColor == Color.FromArgb(192, 0, 0))
            {
                olovka.Color = Color.FromArgb(192, 0, 0);
            }
        }

        private void button6_Click(object sender, EventArgs e) // RGB unos
        {
            if (frm3.textBox1.Text == "" && frm3.textBox2.Text == "" && frm3.textBox3.Text == "") // ako nista nije uneto
            {
                MessageBox.Show("Doslo je do greske. Niste uneli ni jednu vrednost.");
            }
            else
            {
                r = Convert.ToInt32(frm3.textBox1.Text);
                g = Convert.ToInt32(frm3.textBox2.Text);
                b = Convert.ToInt32(frm3.textBox3.Text);
                if (r > 255 || g > 255 || b > 255) // ako su brojevi ili neki od brojeva veci od 255
                {
                    MessageBox.Show("Brojevi moraju biti od 0 do 255.");
                    frm3.textBox1.Text = "";
                    frm3.textBox2.Text = "";
                    frm3.textBox3.Text = "";
                }
                else // kada je sve kako treba
                {
                    olovka.Color = Color.FromArgb(r, g, b);
                    olovkakurg.Color = Color.FromArgb(r, g, b);
                    olovkapravoug.Color = Color.FromArgb(r, g, b);
                    olovkasprej.Color = Color.FromArgb(r, g, b);
                    frm3.Close();
                }
            }
            
        }
        private void Colormixer_Click(object sender, EventArgs e) // klik na kolor mikser 
        {
            colorDialog1.ShowDialog();
            olovka.Color = colorDialog1.Color;
            olovkasprej.Color = colorDialog1.Color;
            olovkakurg.Color = colorDialog1.Color;
            olovkapravoug.Color = colorDialog1.Color;
        }

        private void igracb_CheckedChanged(object sender, EventArgs e) // ukljucivanje moda za igru
        {
            if (igracb.Checked == true)
            {
                Refresh();
                Form5 frm5 = new Form5();
                frm5.Show();
            }
            if (igracb.Checked == false)
            {
                stoperica.Enabled = false;
            }
        }

        private void stoperica_Tick(object sender, EventArgs e) // merenje vremena za igru i davanje ocena
        {
            stoperitza++;
            if (stoperitza == 60)
            {
                stoperitza = 0;
                minuti++;
                if (minuti >= 1 && minuti < 3)
                {
                    ocena = "A";
                }
                if (minuti >= 3 && minuti < 5)
                {
                    ocena = "B";
                }
                if (minuti >= 5 && minuti < 6)
                {
                    ocena = "C";
                }
                if (minuti >= 6 && minuti < 7)
                {
                    ocena = "D";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e) // dugme za kraj igre
        {
            if (igracb.Checked)
            {              
                if (minuti == 0)
                {
                    MessageBox.Show("Zavrsili ste za " + stoperitza + " sekundi. Vasa ocena je A.");
                    stoperica.Enabled = false;
                    igracb.Checked = false;
                }
                if (minuti > 1)
                {
                    MessageBox.Show("Zavrsili ste za " + minuti + " minuta i " + stoperitza + " sekundi. Vasa ocena je " + ocena + ".");
                    stoperica.Enabled = false;
                    igracb.Checked = false;
                }
                if(minuti == 1)
                {
                    MessageBox.Show("Zavrsili ste za " + minuti + " minut i " + stoperitza + " sekundi. Vasa ocena je " + ocena + ".");
                    stoperica.Enabled = false;
                    igracb.Checked = false;
                }
                stoperica.Enabled = false;
                igracb.Checked = false;
            }
            else // ako je dugme kliknuto dok mod za igru nije ukljucen
            {
                MessageBox.Show("Mod za igru je iskljucen.");
            }
            frm5 = new Form5();
            frm5.Close();
        }

        private void zapocnibt_Click(object sender, EventArgs e) // pocetak igre
        {
            if (igracb.Checked)
            {
                stoperica.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mod za igru je iskljucen.");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) // crtanje pravougaonika i krugova
        {
            if (radioButton1.Checked == true)
            {
                poluprecnik = Convert.ToInt32(numericUpDown1.Value);
                Graphics g1 = CreateGraphics();
                g1.DrawEllipse(olovkakurg, xp - poluprecnik, yp-poluprecnik, poluprecnik*2, poluprecnik*2);
                g1.Dispose();
            }
            if (radioButton2.Checked == true)
            {
                sirinap = Convert.ToInt32(numericUpDown2.Value);
                visinap = Convert.ToInt32(numericUpDown3.Value);
                Graphics g2 = CreateGraphics();
                g2.DrawRectangle(olovkapravoug, xp, yp, sirinap, visinap);
                g2.Dispose();
            }
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e) // o programu
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e) // pomoc
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void resetujSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debolovke = 5;
            debljinaolovke.Text = Convert.ToString(debolovke);
            olovka.Color = Color.Black;
            olovkakurg.Color = Color.Black;
            olovkapravoug.Color = Color.Black;
            omiljenaboja.BackColor = Color.White;
            radioButton3.Checked = true;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            igracb.Checked = false;
        }

        private void sacuvajCrtezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Convert.ToInt32(1024), Convert.ToInt32(1024), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Rectangle boundaries = new Rectangle(0, 0, Width, Height);
            this.DrawToBitmap(bitmap, boundaries);
            bitmap.Save(@"test.png", ImageFormat.Png);
        }

        private void button5_Click(object sender, EventArgs e) // otvaranje RGB prozora
        {
            frm3 = new Form3();
            frm3.Show();
        }

        private void ChangeColor(Color color)
        {
            if(color == Color.Yellow && olovka.Color != Color.Yellow) { zutab++; }
            if(color == Color.FromArgb(255, 128, 0) && olovka.Color != Color.FromArgb(255, 128, 0)) { narandzastab++; }
            if(color == Color.Red && olovka.Color != Color.Red) { crvenab++; }
            if(color == Color.FromArgb(192, 0, 192) && olovka.Color != Color.FromArgb(192, 0, 192)) { ljubicastab++; }
            if(color == Color.Black && olovka.Color != Color.Black) { crnab++; }
            if(color == Color.Fuchsia && olovka.Color != Color.Fuchsia) { rozeb++; }
            if(color == Color.Aqua && olovka.Color != Color.Aqua) { svetloplavab++; }
            if(color == Color.Lime && olovka.Color != Color.Lime) { svetlozelenab++; }
            if(color == Color.FromArgb(192, 0, 0) && olovka.Color != Color.FromArgb(192, 0, 0)) { braonb++; }
            olovka.Color = color;
            olovkakurg.Color = color;
            olovkapravoug.Color = color;
            olovkasprej.Color = color;
        }

        private void zuta_Click(object sender, EventArgs e) // promena boje u zutu
        {
            ChangeColor(Color.Yellow);
        }

        private void narandzasta_Click(object sender, EventArgs e) // promena boje u narandzastu
        {
            ChangeColor(Color.FromArgb(255, 128, 0));
        }

        private void crvena_Click(object sender, EventArgs e) // promena boje u crvenu
        {
            ChangeColor(Color.Red);
        }

        private void ljubicasta_Click(object sender, EventArgs e) // promena boja ljubicastu
        {
            ChangeColor(Color.FromArgb(192, 0, 192));
        }

        private void crna_Click(object sender, EventArgs e) // promena boje u crnu
        {
            ChangeColor(Color.Black);
        }

        private void roze_Click(object sender, EventArgs e) // promena boje u roze
        {
            ChangeColor(Color.Fuchsia);
        }

        private void svetloplava_Click(object sender, EventArgs e)// promena boje u svetlo plavu
        {
            ChangeColor(Color.Aqua);
        }

        private void svetlozelena_Click(object sender, EventArgs e) // promena boje u svetlo zelenu
        {
            ChangeColor(Color.Lime);
        }

        private void braon_Click(object sender, EventArgs e) // promena boje u braon
        {
            ChangeColor(Color.FromArgb(192, 0, 0));
        }

        private void Form1_Load(object sender, EventArgs e) // ucitavanje forme
        {
            Icon = new Icon(@"slike/ikonica.ico");
            debljinaolovke.Text = Convert.ToString(debolovke);
            igracb.Checked = false;
            Image slika = Image.FromFile(@"slike/gumica.jpg");
            gumica.BackgroundImage = slika;
            radioButton3.Checked = true;
            button1.FlatStyle = FlatStyle.Popup;
            button2.FlatStyle = FlatStyle.Popup;
            button5.FlatStyle = FlatStyle.Popup;
            button6.FlatStyle = FlatStyle.Popup;
            Colormixer.FlatStyle = FlatStyle.Popup;
            button3.FlatStyle = FlatStyle.Popup;
            button4.FlatStyle = FlatStyle.Popup;
            gumica.FlatStyle = FlatStyle.Popup;
            zapocnibt.FlatStyle = FlatStyle.Popup;
            button8.FlatStyle = FlatStyle.Popup;
        }
    }
}
