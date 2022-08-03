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
    public partial class PersonelEkranı : Form
    {
        PersonelBilgi BulunanPersonel;
        public PersonelEkranı(PersonelBilgi Personel)
        {
            InitializeComponent();
            BulunanPersonel = Personel;

            #region Enabled Durumları
            txtİsim.Enabled = false;
            txtSoyisim.Enabled = false;
            txtPersonelNO.Enabled = false;
            txtTelefonNO.Enabled = false;
            txtYas.Enabled = false;
            txtEmailAdres.Enabled = false;
            txtBulunduguKat.Enabled = false;
            #endregion
        }

        private void PersonelEkranı_Load(object sender, EventArgs e)
        {
            txtİsim.Text = BulunanPersonel.İsim;
            txtSoyisim.Text = BulunanPersonel.Soyisim;
            txtPersonelNO.Text = BulunanPersonel.PersonelNumara;
            txtEmailAdres.Text = BulunanPersonel.EmailAdres;
            txtTelefonNO.Text = BulunanPersonel.TelefonNumara;
            txtYas.Text = Convert.ToString(BulunanPersonel.Yas);
            txtBulunduguKat.Text = Convert.ToString(BulunanPersonel.GorevliOlduguKat);
        }

        private void btnMusteriListesi_Click(object sender, EventArgs e)
        {
            MusteriListesi M1 = new MusteriListesi();
            M1.ShowDialog();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle MusteriEkle = new MusteriEkle();
            MusteriEkle.ShowDialog();
        }
    }
}
