
namespace PUSHHH_
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btnTekOyuncu = new System.Windows.Forms.Button();
            this.btnCiftOyuncu = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKolay = new System.Windows.Forms.Button();
            this.btnZor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.randiman = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTekOyuncu
            // 
            this.btnTekOyuncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnTekOyuncu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTekOyuncu.Location = new System.Drawing.Point(33, 124);
            this.btnTekOyuncu.Name = "btnTekOyuncu";
            this.btnTekOyuncu.Size = new System.Drawing.Size(150, 45);
            this.btnTekOyuncu.TabIndex = 1;
            this.btnTekOyuncu.Text = "Tek Oyuncu";
            this.btnTekOyuncu.UseVisualStyleBackColor = false;
            this.btnTekOyuncu.Click += new System.EventHandler(this.btnTekOyuncu_Click);
            this.btnTekOyuncu.MouseCaptureChanged += new System.EventHandler(this.btnTekKisilik_MouseCaptureChanged);
            // 
            // btnCiftOyuncu
            // 
            this.btnCiftOyuncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCiftOyuncu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiftOyuncu.Location = new System.Drawing.Point(216, 124);
            this.btnCiftOyuncu.Name = "btnCiftOyuncu";
            this.btnCiftOyuncu.Size = new System.Drawing.Size(150, 45);
            this.btnCiftOyuncu.TabIndex = 2;
            this.btnCiftOyuncu.Text = "Çift Oyuncu";
            this.btnCiftOyuncu.UseVisualStyleBackColor = false;
            this.btnCiftOyuncu.Click += new System.EventHandler(this.btnCiftOyuncu_Click);
            this.btnCiftOyuncu.MouseCaptureChanged += new System.EventHandler(this.btnCiftKisilik_MouseCaptureChanged);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(405, 12);
            this.cikis.Multiline = true;
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(32, 32);
            this.cikis.TabIndex = 1;
            this.cikis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 120);
            this.label1.TabIndex = 3;
            this.label1.Text = "P U S H H H !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKolay
            // 
            this.btnKolay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnKolay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKolay.Location = new System.Drawing.Point(33, 124);
            this.btnKolay.Name = "btnKolay";
            this.btnKolay.Size = new System.Drawing.Size(150, 45);
            this.btnKolay.TabIndex = 4;
            this.btnKolay.Text = "Kolay";
            this.btnKolay.UseVisualStyleBackColor = false;
            this.btnKolay.Click += new System.EventHandler(this.btnKolay_Click);
            this.btnKolay.MouseCaptureChanged += new System.EventHandler(this.btnKolay_MouseCaptureChanged);
            // 
            // btnZor
            // 
            this.btnZor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnZor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZor.Location = new System.Drawing.Point(216, 124);
            this.btnZor.Name = "btnZor";
            this.btnZor.Size = new System.Drawing.Size(150, 45);
            this.btnZor.TabIndex = 5;
            this.btnZor.Text = "Zor";
            this.btnZor.UseVisualStyleBackColor = false;
            this.btnZor.Click += new System.EventHandler(this.btnZor_Click);
            this.btnZor.MouseCaptureChanged += new System.EventHandler(this.btnZor_MouseCaptureChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 60);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 120);
            this.label2.TabIndex = 3;
            this.label2.Text = "P U S H H H !";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randiman
            // 
            this.randiman.Interval = 200;
            this.randiman.Tick += new System.EventHandler(this.randiman_Tick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.btnCiftOyuncu);
            this.Controls.Add(this.btnTekOyuncu);
            this.Controls.Add(this.btnZor);
            this.Controls.Add(this.btnKolay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUSHHH!";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTekOyuncu;
        private System.Windows.Forms.Button btnCiftOyuncu;
        private System.Windows.Forms.TextBox cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKolay;
        private System.Windows.Forms.Button btnZor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer randiman;
    }
}

