using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUSHHH_
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            randiman.Start();
            cikis.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }
            else
            {
                cikis.ResetText();
            }
        }

        private void btnCiftKisilik_MouseCaptureChanged(object sender, EventArgs e)
        {
            cikis.Select();
        }

        private void btnTekKisilik_MouseCaptureChanged(object sender, EventArgs e)
        {
            cikis.Select();
        }

        private void btnTekOyuncu_Click(object sender, EventArgs e)
        {
            btnTekOyuncu.Visible = false;
            btnCiftOyuncu.Visible = false;
            cikis.Select();
        }

        private void btnKolay_MouseCaptureChanged(object sender, EventArgs e)
        {
            cikis.Select();
        }

        private void btnZor_MouseCaptureChanged(object sender, EventArgs e)
        {
            cikis.Select();
        }

        private void btnKolay_Click(object sender, EventArgs e)
        {
            TekOyunculu tekOyunculu = new TekOyunculu();
            tekOyunculu.Zorluk = "Kolay";
            this.Hide();
            tekOyunculu.Show();
        }

        private void btnZor_Click(object sender, EventArgs e)
        {
            TekOyunculu tekOyunculu = new TekOyunculu();
            tekOyunculu.Zorluk = "Zor";
            this.Hide();
            tekOyunculu.Show();
        }

        private void btnCiftOyuncu_Click(object sender, EventArgs e)
        {
            CiftOyunculu ciftOyunculu = new CiftOyunculu();
            this.Hide();
            ciftOyunculu.Show();
        }

        private Random rnd = new Random();
        int deger;
        private void randiman_Tick(object sender, EventArgs e)
        {
            deger = rnd.Next(0, 2);
            if (deger == 0)
            {
                if (panel1.Height <= 70)
                {
                    panel1.Size = new Size(panel1.Width, panel1.Height + 5);
                }
                else
                {
                    panel1.Size = new Size(panel1.Width, panel1.Height - 5);
                }
            }
            else if (deger == 1)
            {
                if (panel1.Height >= 50)
                {
                    panel1.Size = new Size(panel1.Width, panel1.Height - 5);
                }
                else
                {
                    panel1.Size = new Size(panel1.Width, panel1.Height + 5);
                }
            }
        }
    }
}
