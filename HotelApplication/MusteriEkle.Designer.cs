
namespace HotelApplication
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            this.dtpGirisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTelefonNO = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpGirisTarih
            // 
            this.dtpGirisTarih.Location = new System.Drawing.Point(150, 150);
            this.dtpGirisTarih.Name = "dtpGirisTarih";
            this.dtpGirisTarih.Size = new System.Drawing.Size(206, 22);
            this.dtpGirisTarih.TabIndex = 34;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(150, 185);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(206, 22);
            this.txtYas.TabIndex = 4;
            this.txtYas.Enter += new System.EventHandler(this.txtİsim_Enter);
            this.txtYas.Leave += new System.EventHandler(this.txtİsim_Leave);
            // 
            // txtTelefonNO
            // 
            this.txtTelefonNO.Location = new System.Drawing.Point(150, 80);
            this.txtTelefonNO.Name = "txtTelefonNO";
            this.txtTelefonNO.Size = new System.Drawing.Size(206, 22);
            this.txtTelefonNO.TabIndex = 2;
            this.txtTelefonNO.Enter += new System.EventHandler(this.txtİsim_Enter);
            this.txtTelefonNO.Leave += new System.EventHandler(this.txtİsim_Leave);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(150, 45);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(206, 22);
            this.txtSoyisim.TabIndex = 1;
            this.txtSoyisim.Enter += new System.EventHandler(this.txtİsim_Enter);
            this.txtSoyisim.Leave += new System.EventHandler(this.txtİsim_Leave);
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(149, 7);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(206, 22);
            this.txtİsim.TabIndex = 0;
            this.txtİsim.Enter += new System.EventHandler(this.txtİsim_Enter);
            this.txtİsim.Leave += new System.EventHandler(this.txtİsim_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(13, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Yaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(13, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "E-Mail Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "İsim:";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.Gold;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(292, 225);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(92, 63);
            this.btnMusteriEkle.TabIndex = 5;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Gold;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(361, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(23, 27);
            this.btnKapat.TabIndex = 36;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.Location = new System.Drawing.Point(150, 114);
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(206, 22);
            this.txtEmailAdres.TabIndex = 3;
            this.txtEmailAdres.Enter += new System.EventHandler(this.txtİsim_Enter);
            this.txtEmailAdres.Leave += new System.EventHandler(this.txtİsim_Leave);
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 288);
            this.Controls.Add(this.txtEmailAdres);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.dtpGirisTarih);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtTelefonNO);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriEkle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGirisTarih;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtTelefonNO;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtEmailAdres;
    }
}