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
    public partial class CiftOyunculu : Form
    {
        public CiftOyunculu()
        {
            InitializeComponent();
        }
        private void CiftOyunculu_Load(object sender, EventArgs e)
        {
            cikis.Enabled = false;
            GeriSayim.Start();
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

        private int CikisHakki = 0;
        private void cikis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'A' || e.KeyChar == 'a')
            {
                if (CikisHakki == 0 && lblKazanan1.Visible == false)
                {
                    CikisHakki = 1;
                }

                if (panelA.Width > 0 && panelA.Width < 500)
                {
                    panelA.Size = new Size(panelA.Width + 20, panelA.Height);
                }

                if (panelA.Width <= 0 || panelA.Width >= 500)
                {
                    KazananKim();
                }

            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape) && CikisHakki == 0)
            {
                Application.Exit();
            }
            else if(e.KeyChar == '5')
            {
                if (CikisHakki == 0 && lblKazanan1.Visible == false)
                {
                    CikisHakki = 1;
                }

                if (panelA.Width > 0 && panelA.Width < 500)
                {
                    panelA.Size = new Size(panelA.Width - 20, panelA.Height);
                }
                
                if(panelA.Width <= 0 || panelA.Width >= 500)
                {
                    KazananKim();
                }
            }
            else
            {
                cikis.ResetText();
            }
        }

        private void GeriSayim_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sure.Text) > 1)
            {
                sure.Text = Convert.ToString(Convert.ToInt32(sure.Text) - 1);
            }
            else
            {
                sure.Visible = false;
                cikis.Enabled = true;
                cikis.Select();
            }
        }

        private void btnTekrar1_Click(object sender, EventArgs e)
        {
            CiftOyunculu cift = new CiftOyunculu();
            this.Hide();
            cift.Show();
        }

        private void btnTekrar2_Click(object sender, EventArgs e)
        {
            CiftOyunculu cift = new CiftOyunculu();
            this.Hide();
            cift.Show();
        }

        private void btnTekrar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            cikis.Select();
        }

        private void btnTekrar2_MouseCaptureChanged(object sender, EventArgs e)
        {
            cikis.Select();
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
