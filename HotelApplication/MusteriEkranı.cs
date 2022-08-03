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
    public partial class MusteriEkranı : Form
    {
        MusteriBilgi BulunanMusteri;
        PersonelBilgi Personel;
        public MusteriEkranı(MusteriBilgi Musteri)
        {
            InitializeComponent();
            BulunanMusteri = Musteri;

            #region Enabled Durumları
            txtİsim.Enabled = false;
            txtSoyisim.Enabled = false;
            txtOdaNO.Enabled = false;
            txtTelefonNO.Enabled = false;
            txtYas.Enabled = false;
            txtKatGorevli.Enabled = false;
            txtKatNo.Enabled = false;
            txtEmailAdres.Enabled = false;
            #endregion
        }

        private void MusteriEkranı_Load(object sender, EventArgs e)
        {
            #region Bilgileri TextBox'lara Yazdırma
            txtİsim.Text = BulunanMusteri.İsim;
            txtSoyisim.Text = BulunanMusteri.Soyisim;
            txtOdaNO.Text =Convert.ToString(BulunanMusteri.OdaNO);
            txtTelefonNO.Text = BulunanMusteri.TelefonNumara;
            txtYas.Text =Convert.ToString(BulunanMusteri.Yas);
            txtKatGorevli.Text = BulunanMusteri.EmailAdres;
            txtKatNo.Text = Convert.ToString(BulunanMusteri.BulunduguKat);
            txtEmailAdres.Text = BulunanMusteri.EmailAdres;
            #endregion

            #region Kat Görevlisini Yazdırma
            if (Convert.ToInt32(txtKatNo.Text)==0)
            {
                txtKatGorevli.Text = "Mutlucan Gökçukur";
            }
            else if(Convert.ToInt32(txtKatNo.Text)==1)
            {
                txtKatGorevli.Text = "Mahmut Satici";
            }
            else if(Convert.ToInt32(txtKatNo.Text)==2)
            {
                txtKatGorevli.Text = "Yusuf Üzeyir Kaya";
            }
            #endregion

            #region Personel Bilgisi Alma
            PersonelBilgi BulunanPersonel = SanalDataBase.PersonelBilgiList.Find(
            i => i.İsim+ " "+i.Soyisim == txtKatGorevli.Text);
            Personel = BulunanPersonel;
            #endregion
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            SiparisEkranı SiparisEkran = new SiparisEkranı();
            SiparisEkran.ShowDialog();
            this.Close();
        }

        private void btnGorevliBilgi_Click(object sender, EventArgs e)
        {
            KatGorevliBilgileri KGB = new KatGorevliBilgileri(Personel);
            KGB.ShowDialog();
            
        }
    }
}
