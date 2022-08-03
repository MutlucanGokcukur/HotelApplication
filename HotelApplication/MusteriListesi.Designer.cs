
namespace HotelApplication
{
    partial class MusteriListesi
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
            this.DGVListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListe)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVListe
            // 
            this.DGVListe.AllowUserToAddRows = false;
            this.DGVListe.AllowUserToDeleteRows = false;
            this.DGVListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVListe.Location = new System.Drawing.Point(0, 0);
            this.DGVListe.Name = "DGVListe";
            this.DGVListe.ReadOnly = true;
            this.DGVListe.RowHeadersWidth = 51;
            this.DGVListe.RowTemplate.Height = 24;
            this.DGVListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListe.Size = new System.Drawing.Size(1127, 450);
            this.DGVListe.TabIndex = 0;
            this.DGVListe.DoubleClick += new System.EventHandler(this.DGVListe_DoubleClick);
            // 
            // MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.DGVListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MusteriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Listesi";
            this.Load += new System.EventHandler(this.MusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListe;
    }
}