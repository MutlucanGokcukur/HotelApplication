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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
            dtpGirisTarih.Enabled = false;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            ListeEkleme();
            MusteriListesi MListe = new MusteriListesi();
            dtpGirisTarih.Value = DateTime.Now;
        }
        int odano;
        public void ListeEkleme()
        {
            Random rnd = new Random();
            int katno = rnd.Next(3, 6);
            if (katno==3)
            {
                odano = rnd.Next(300, 401);
            }
            else if(katno==4)
            {
                odano = rnd.Next(401, 501);
            }
            else if(katno==5)
            {
                odano = rnd.Next(501, 599);
            }
            try
            {
                List<MusteriBilgi> MusteriEkle = new List<MusteriBilgi>()
            {
                new MusteriBilgi
                {
                    İsim=txtİsim.Text,
                    Soyisim=txtSoyisim.Text,
                    Yas=Convert.ToInt32(txtYas.Text),
                    EmailAdres=txtEmailAdres.Text,
                    TelefonNumara=txtTelefonNO.Text,
                    GirisZamanı=DateTime.Now,
                    OdaNO=odano,
                    BulunduguKat=katno
                }
            };
                SanalDataBase.MusteriBilgiList.AddRange(MusteriEkle);
            }
            catch (Exception)
            {
                MessageBox.Show("Tüm Bilgileri Eksiksiz Giriniz","Hata"
                ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtİsim_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Gold;
        }

        private void txtİsim_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
