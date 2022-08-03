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
    public partial class MusteriBilgisi : Form
    {
        MusteriBilgi BulunanMusteri;
        public MusteriBilgisi(MusteriBilgi Musteri)
        {
            InitializeComponent();
            BulunanMusteri = Musteri;

            #region Enabled Durumları
            txtİsim.Enabled = false;
            txtSoyisim.Enabled = false;
            txtBulunduguKat.Enabled = false;
            txtEmailAdres.Enabled = false;
            txtTelefonNO.Enabled = false;
            txtYas.Enabled = false;
            txtOdaNO.Enabled = false;
            dtpGirisTarih.Enabled = false;
            txtKatGorevlisi.Enabled = false;
            #endregion

        }

        private void MusteriBilgisi_Load(object sender, EventArgs e)
        {
            #region Müşteri Bilgileri Yazdırma
            txtİsim.Text = BulunanMusteri.İsim;
            txtSoyisim.Text = BulunanMusteri.Soyisim;
            txtOdaNO.Text =Convert.ToString(BulunanMusteri.OdaNO);
            txtEmailAdres.Text = BulunanMusteri.EmailAdres;
            txtTelefonNO.Text = BulunanMusteri.TelefonNumara;
            dtpGirisTarih.Value = BulunanMusteri.GirisZamanı;
            txtYas.Text =Convert.ToString(BulunanMusteri.Yas);
            txtBulunduguKat.Text =Convert.ToString(BulunanMusteri.BulunduguKat);
            #endregion

            if (Convert.ToInt32(txtBulunduguKat.Text) == 0)
            {
                txtKatGorevlisi.Text = "Mutlucan Gökçukur";
            }
            else if (Convert.ToInt32(txtBulunduguKat.Text) == 1)
            {
                txtKatGorevlisi.Text = "Mahmut Satici";
            }
            else if (Convert.ToInt32(txtBulunduguKat.Text) == 2)
            {
                txtKatGorevlisi.Text = "Yusuf Üzeyir Kaya";
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
