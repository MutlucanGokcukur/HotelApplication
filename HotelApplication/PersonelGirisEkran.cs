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
    public partial class PersonelGirisEkran : Form
    {
        public PersonelGirisEkran()
        {
            InitializeComponent();
        }
        int girishakkı = 3;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string PersonelNO = txtPersonelNo.Text;
            int PersonelSifre =Convert.ToInt32(txtSifre.Text);
            PersonelBilgi BulunanPersonel = SanalDataBase.PersonelBilgiList.Find(
            i=>i.PersonelSifre==PersonelSifre);
            if (BulunanPersonel!=null)
            {
                PersonelEkranı P1 = new PersonelEkranı(BulunanPersonel);
                P1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Personel Numarası ya da Şifre Yanlış Girildi","Hata",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
                girishakkı--;
            }
            if (girishakkı==0)
            {
                MessageBox.Show("Giriş Hakkınız Kalmamıştır", "Hata",MessageBoxButtons.OK
                ,MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void txtPersonelNo_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Gold;
        }

        private void txtPersonelNo_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void PersonelGirisEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
