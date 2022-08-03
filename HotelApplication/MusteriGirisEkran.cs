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
    public partial class MusteriGirisEkran : Form
    {
        public MusteriGirisEkran()
        {
            InitializeComponent();
            cmbBulunduguKat.Items.Add(0);
            cmbBulunduguKat.Items.Add(1);
            cmbBulunduguKat.Items.Add(2);
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            SanalDataBase db = new SanalDataBase();
            db.MusteriListele();
            
            MusteriBilgi BulunanMusteri = SanalDataBase.MusteriBilgiList.Find(
            i => i.OdaNO == Convert.ToInt32(txtOdaNO.Text));

            #region Girdiği Kat ve Oda Numara Kontrolü
            if (Convert.ToInt32(cmbBulunduguKat.Text)==0)
            {
                int odano = Convert.ToInt32(txtOdaNO.Text);
                if (0<odano && odano<101)
                {
                    MusteriEkranı MEkran = new MusteriEkranı(BulunanMusteri);
                    MEkran.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kat Numarası veya Oda Numarası Yanlış Girildi");
                }
            }
            else if(Convert.ToInt32(cmbBulunduguKat.Text) == 1)
            {
                int odano = Convert.ToInt32(txtOdaNO.Text);
                if (100 < odano && odano < 201)
                {
                    MusteriEkranı MEkran = new MusteriEkranı(BulunanMusteri);
                    MEkran.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kat Numarası veya Oda Numarası Yanlış Girildi");
                }
            }
            else if(Convert.ToInt32(cmbBulunduguKat.Text) == 2)
            {
                int odano = Convert.ToInt32(txtOdaNO.Text);
                if (200 < odano && odano < 301)
                {
                    MusteriEkranı MEkran = new MusteriEkranı(BulunanMusteri);
                    MEkran.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kat Numarası veya Oda Numarası Yanlış Girildi");
                }
            }
            #endregion
        }

        private void txtOdaNO_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Gold;
        }
    }
}
