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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Personel Giriş
        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            PersonelGirisEkran PGiris = new PersonelGirisEkran();
            PGiris.ShowDialog();
            this.Close();
        }
        #endregion

        #region Müşteri Giriş
        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
            MusteriGirisEkran MGiris = new MusteriGirisEkran();
            MGiris.ShowDialog();
            this.Close();
        }
        #endregion
    }
}
