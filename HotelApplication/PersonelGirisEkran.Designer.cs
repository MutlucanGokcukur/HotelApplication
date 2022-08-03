
namespace HotelApplication
{
    partial class PersonelGirisEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGirisEkran));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Gold;
            this.btnGirisYap.Location = new System.Drawing.Point(384, 108);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(100, 38);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtPersonelNo.Location = new System.Drawing.Point(384, 31);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(100, 22);
            this.txtPersonelNo.TabIndex = 0;
            this.txtPersonelNo.Enter += new System.EventHandler(this.txtPersonelNo_Enter);
            this.txtPersonelNo.Leave += new System.EventHandler(this.txtPersonelNo_Leave);
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.BackColor = System.Drawing.Color.Gold;
            this.lblPersonelNo.Location = new System.Drawing.Point(246, 34);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(132, 17);
            this.lblPersonelNo.TabIndex = 2;
            this.lblPersonelNo.Text = "Personel Numarası:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(384, 80);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.Enter += new System.EventHandler(this.txtPersonelNo_Enter);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Gold;
            this.lblSifre.Location = new System.Drawing.Point(246, 85);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(41, 17);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PersonelGirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(497, 154);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblPersonelNo);
            this.Controls.Add(this.txtPersonelNo);
            this.Controls.Add(this.btnGirisYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonelGirisEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş Ekranı";
            this.Load += new System.EventHandler(this.PersonelGirisEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}