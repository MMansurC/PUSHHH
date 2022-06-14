
namespace PUSHHH_
{
    partial class CiftOyunculu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiftOyunculu));
            this.panelA = new System.Windows.Forms.Panel();
            this.btnTekrar1 = new System.Windows.Forms.Button();
            this.lblKazanan1 = new System.Windows.Forms.Label();
            this.panelB = new System.Windows.Forms.Panel();
            this.btnTekrar2 = new System.Windows.Forms.Button();
            this.lblKazanan2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.TextBox();
            this.sure = new System.Windows.Forms.Label();
            this.GeriSayim = new System.Windows.Forms.Timer(this.components);
            this.ans1 = new System.Windows.Forms.PictureBox();
            this.ans2 = new System.Windows.Forms.PictureBox();
            this.panelA.SuspendLayout();
            this.panelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ans1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ans2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(15)))));
            this.panelA.Controls.Add(this.ans1);
            this.panelA.Controls.Add(this.btnTekrar1);
            this.panelA.Controls.Add(this.lblKazanan1);
            this.panelA.Location = new System.Drawing.Point(0, 27);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(247, 273);
            this.panelA.TabIndex = 10;
            // 
            // btnTekrar1
            // 
            this.btnTekrar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnTekrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTekrar1.Location = new System.Drawing.Point(175, 170);
            this.btnTekrar1.Name = "btnTekrar1";
            this.btnTekrar1.Size = new System.Drawing.Size(150, 45);
            this.btnTekrar1.TabIndex = 4;
            this.btnTekrar1.Text = "Tekrar Oyna";
            this.btnTekrar1.UseVisualStyleBackColor = false;
            this.btnTekrar1.Visible = false;
            this.btnTekrar1.Click += new System.EventHandler(this.btnTekrar1_Click);
            this.btnTekrar1.MouseCaptureChanged += new System.EventHandler(this.btnTekrar1_MouseCaptureChanged);
            // 
            // lblKazanan1
            // 
            this.lblKazanan1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKazanan1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblKazanan1.Location = new System.Drawing.Point(65, 57);
            this.lblKazanan1.Name = "lblKazanan1";
            this.lblKazanan1.Size = new System.Drawing.Size(370, 40);
            this.lblKazanan1.TabIndex = 3;
            this.lblKazanan1.Text = "Oyuncu 1(A) Kazandı!";
            this.lblKazanan1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKazanan1.Visible = false;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelB.Controls.Add(this.ans2);
            this.panelB.Controls.Add(this.btnTekrar2);
            this.panelB.Controls.Add(this.lblKazanan2);
            this.panelB.Location = new System.Drawing.Point(0, 27);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(500, 273);
            this.panelB.TabIndex = 11;
            // 
            // btnTekrar2
            // 
            this.btnTekrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnTekrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTekrar2.Location = new System.Drawing.Point(175, 170);
            this.btnTekrar2.Name = "btnTekrar2";
            this.btnTekrar2.Size = new System.Drawing.Size(150, 45);
            this.btnTekrar2.TabIndex = 6;
            this.btnTekrar2.Text = "Tekrar Oyna";
            this.btnTekrar2.UseVisualStyleBackColor = false;
            this.btnTekrar2.Visible = false;
            this.btnTekrar2.Click += new System.EventHandler(this.btnTekrar2_Click);
            this.btnTekrar2.MouseCaptureChanged += new System.EventHandler(this.btnTekrar2_MouseCaptureChanged);
            // 
            // lblKazanan2
            // 
            this.lblKazanan2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKazanan2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(85)))), ((int)(((byte)(15)))));
            this.lblKazanan2.Location = new System.Drawing.Point(65, 57);
            this.lblKazanan2.Name = "lblKazanan2";
            this.lblKazanan2.Size = new System.Drawing.Size(370, 40);
            this.lblKazanan2.TabIndex = 5;
            this.lblKazanan2.Text = "Oyuncu 2(5) Kazandı!";
            this.lblKazanan2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKazanan2.Visible = false;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(358, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oyuncu 2(5)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Oyuncu 1(A)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(233, 52);
            this.cikis.Multiline = true;
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(32, 32);
            this.cikis.TabIndex = 7;
            this.cikis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cikis_KeyPress);
            // 
            // sure
            // 
            this.sure.BackColor = System.Drawing.Color.Black;
            this.sure.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sure.ForeColor = System.Drawing.Color.White;
            this.sure.Location = new System.Drawing.Point(220, 120);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(60, 60);
            this.sure.TabIndex = 12;
            this.sure.Text = "3";
            this.sure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeriSayim
            // 
            this.GeriSayim.Interval = 1000;
            this.GeriSayim.Tick += new System.EventHandler(this.GeriSayim_Tick);
            // 
            // ans1
            // 
            this.ans1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ans1.Image = ((System.Drawing.Image)(resources.GetObject("ans1.Image")));
            this.ans1.Location = new System.Drawing.Point(119, 167);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(50, 50);
            this.ans1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ans1.TabIndex = 6;
            this.ans1.TabStop = false;
            this.ans1.Visible = false;
            this.ans1.Click += new System.EventHandler(this.ans1_Click);
            // 
            // ans2
            // 
            this.ans2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ans2.Image = ((System.Drawing.Image)(resources.GetObject("ans2.Image")));
            this.ans2.Location = new System.Drawing.Point(119, 167);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(50, 50);
            this.ans2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ans2.TabIndex = 7;
            this.ans2.TabStop = false;
            this.ans2.Visible = false;
            this.ans2.Click += new System.EventHandler(this.ans2_Click);
            // 
            // CiftOyunculu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikis);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CiftOyunculu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUSHHH!";
            this.Load += new System.EventHandler(this.CiftOyunculu_Load);
            this.panelA.ResumeLayout(false);
            this.panelB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ans1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ans2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Button btnTekrar1;
        private System.Windows.Forms.Label lblKazanan1;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Button btnTekrar2;
        private System.Windows.Forms.Label lblKazanan2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cikis;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Timer GeriSayim;
        private System.Windows.Forms.PictureBox ans1;
        private System.Windows.Forms.PictureBox ans2;
    }
}