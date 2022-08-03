
namespace HotelApplication
{
    partial class MusteriGirisEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGirisEkran));
            this.txtOdaNO = new System.Windows.Forms.TextBox();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.lblKatNo = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.cmbBulunduguKat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtOdaNO
            // 
            this.txtOdaNO.Location = new System.Drawing.Point(204, 67);
            this.txtOdaNO.Name = "txtOdaNO";
            this.txtOdaNO.Size = new System.Drawing.Size(100, 22);
            this.txtOdaNO.TabIndex = 0;
            this.txtOdaNO.Enter += new System.EventHandler(this.txtOdaNO_Enter);
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.BackColor = System.Drawing.Color.Gold;
            this.lblOdaNo.Location = new System.Drawing.Point(12, 69);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(158, 20);
            this.lblOdaNo.TabIndex = 1;
            this.lblOdaNo.Text = "Oda Numaranızı Giriniz:";
            // 
            // lblKatNo
            // 
            this.lblKatNo.AutoSize = true;
            this.lblKatNo.BackColor = System.Drawing.Color.Gold;
            this.lblKatNo.Location = new System.Drawing.Point(12, 32);
            this.lblKatNo.Name = "lblKatNo";
            this.lblKatNo.Size = new System.Drawing.Size(175, 17);
            this.lblKatNo.TabIndex = 1;
            this.lblKatNo.Text = "Bulunduğunuz Katı Giriniz:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Gold;
            this.btnGirisYap.Location = new System.Drawing.Point(204, 95);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(100, 38);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // cmbBulunduguKat
            // 
            this.cmbBulunduguKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBulunduguKat.FormattingEnabled = true;
            this.cmbBulunduguKat.Location = new System.Drawing.Point(204, 25);
            this.cmbBulunduguKat.Name = "cmbBulunduguKat";
            this.cmbBulunduguKat.Size = new System.Drawing.Size(100, 24);
            this.cmbBulunduguKat.TabIndex = 3;
            // 
            // MusteriGirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(331, 152);
            this.Controls.Add(this.cmbBulunduguKat);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblKatNo);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.txtOdaNO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MusteriGirisEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOdaNO;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label lblKatNo;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.ComboBox cmbBulunduguKat;
    }
}