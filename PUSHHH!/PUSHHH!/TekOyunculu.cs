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
    public partial class TekOyunculu : Form
    {
        public TekOyunculu()
        {
            InitializeComponent();
        }

        private void KazananKim()
        {
            lblKazanan1.Visible = true;
            btnTekrar1.Visible = true;
            lblKazanan2.Visible = true;
            btnTekrar2.Visible = true;
            CikisHakki = 0;
            ans1.Visible = true;
            ans2.Visible = true;
        }

        public string Zorluk;
        private void TekOyunculu_Load(object sender, EventArgs e)
        {
            if (Zorluk == "Kolay")
            {
                YapayZeka.Interval = 300;
            }
            else if (Zorluk == "Zor")
            {
                YapayZeka.Interval = 150;
            }
            cikis.Select();
        }

        private int CikisHakki = 0;
        private void cikis_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 'A'||e.KeyChar=='a')
            {
                if (label3.Visible == true)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                }
                if (CikisHakki == 0 && lblKazanan1.Visible == false)
                {
                    CikisHakki = 1;
                    YapayZeka.Start();
                }
                else
                {
                    if (panelA.Width > 0 && panelA.Width < 500)
                    {
                        panelA.Size = new Size(panelA.Width + 20, panelA.Height);
                    }

                    if (panelA.Width == 0 || panelA.Width == 500)
                    {
                        YapayZeka.Stop();
                        KazananKim();
                    }

                }
                
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape) && CikisHakki == 0)
            {
                Application.Exit();
            }
            else
            {
                cikis.ResetText();
            }
        }

        private void YapayZeka_Tick(object sender, EventArgs e)
        {
            if (panelA.Width > 0 && panelA.Width < 500)
            {
                panelA.Size = new Size(panelA.Width - 20, panelA.Height);
            }

            if (panelA.Width <= 0 || panelA.Width >= 500)
            {
                YapayZeka.Stop();
                KazananKim();
            }
        }

        private void btnTekrar1_Click(object sender, EventArgs e)
        {
            TekOyunculu tek = new TekOyunculu();
            tek.Zorluk = Zorluk;
            this.Hide();
            tek.Show();
        }

        private void btnTekrar2_Click(object sender, EventArgs e)
        {
            TekOyunculu tek = new TekOyunculu();
            tek.Zorluk = Zorluk;
            this.Hide();
            tek.Show();
        }

        private void btnTekrar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            cikis.Select();
        }

        private void btnTekrar2_MouseCaptureChanged(object sender, EventArgs e)
        {
            cikis.Select();
        }

        private void cikis_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ans1_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            this.Hide();
            ana.Show();
        }

        private void ans2_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            this.Hide();
            ana.Show();
        }

    }
}
