using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApplication
{
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }

        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            SanalDataBase db = new SanalDataBase();
            List<MusteriBilgi> MusteriListe = db.MusteriListele();
            DGVListe.DataSource = MusteriListe;
            DGVListe.Columns["Yas"].Width = 50;
            DGVListe.Columns["EmailAdres"].Width = 200;
            DGVListe.Columns["BulunduguKat"].Width = 65;
            DGVListe.Columns["OdaNO"].Width = 60;
            DGVListe.Columns["BulunduguKat"].HeaderText = "Bulunduğu Kat";
            DGVListe.Columns["TelefonNumara"].HeaderText = "Telefon Numarası";
            DGVListe.Columns["EmailAdres"].HeaderText = "E-Mail Adresi";
            DGVListe.Columns["OdaNO"].HeaderText = "Oda Numarası";
            DGVListe.Columns["GirisZamanı"].HeaderText = "Giriş Zamanı";
        }

        private void DGVListe_DoubleClick(object sender, EventArgs e)
        {
            int MusteriOdaNo = (int)DGVListe[6, DGVListe.CurrentCell.RowIndex].Value;
            MusteriBilgi BulunanMusteri = SanalDataBase.MusteriBilgiList.Find(
            i => i.OdaNO == MusteriOdaNo);
            if (BulunanMusteri!=null)
            {
                MusteriBilgisi MusteriBilgi = new MusteriBilgisi(BulunanMusteri);
                MusteriBilgi.ShowDialog();
            }
        }
    }
}
