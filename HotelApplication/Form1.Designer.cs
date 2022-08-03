
namespace HotelApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMusteriGiris = new System.Windows.Forms.Button();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.BackColor = System.Drawing.Color.Gold;
            this.btnMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGiris.Location = new System.Drawing.Point(36, 69);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.Size = new System.Drawing.Size(110, 100);
            this.btnMusteriGiris.TabIndex = 0;
            this.btnMusteriGiris.Text = "Müşteri Giriş";
            this.btnMusteriGiris.UseVisualStyleBackColor = false;
            this.btnMusteriGiris.Click += new System.EventHandler(this.btnMusteriGiris_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.BackColor = System.Drawing.Color.Gold;
            this.btnPersonelGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGiris.Location = new System.Drawing.Point(196, 69);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(110, 100);
            this.btnPersonelGiris.TabIndex = 1;
            this.btnPersonelGiris.Text = "Personel Giriş";
            this.btnPersonelGiris.UseVisualStyleBackColor = false;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yıldız Otel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.btnMusteriGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriGiris;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Label label1;
    }
}

