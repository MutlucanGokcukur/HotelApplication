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
    public partial class SiparisEkranı : Form
    {
        public SiparisEkranı()
        {
            InitializeComponent();
        }

        private void SiparisEkranı_Load(object sender, EventArgs e)
        {
            #region Çorba Listesi
            lstSuluYemekler.Items.Add("Yayla Çorbası");
            lstSuluYemekler.Items.Add("Mercimek Çorbası");
            lstSuluYemekler.Items.Add("Tarhana Çorbası");
            lstSuluYemekler.Items.Add("Şehriye Çorbası");
            lstSuluYemekler.Items.Add("Alaromen Çorbası");
            lstSuluYemekler.Items.Add("Domates Çorbası");
            lstSuluYemekler.Items.Add("Ezogelin Çorbası");
            lstSuluYemekler.Items.Add("Kremalı Sebze Çorbası");
            #endregion

            #region Ara Yemek Listesi
            lstAraYemekler.Items.Add("İzmir Köfte");
            lstAraYemekler.Items.Add("Zeytinyağlı Türlü");
            lstAraYemekler.Items.Add("Piliç Kanat Izgara");
            lstAraYemekler.Items.Add("Patlıcan Musakka");
            lstAraYemekler.Items.Add("Tavuklu Nohut");
            lstAraYemekler.Items.Add("Zeytinyağlı Bezelye");
            lstAraYemekler.Items.Add("Haşlama Tavuk");
            lstAraYemekler.Items.Add("Rulo Et Köfte");
            lstAraYemekler.Items.Add("Arnavut Ciğeri");
            lstAraYemekler.Items.Add("Dana Rosto");
            lstAraYemekler.Items.Add("Zeytinyağlı Kuru Fasulye");
            lstAraYemekler.Items.Add("Tavuk Sote");
            lstAraYemekler.Items.Add("Terbiyeli Köfte");
            #endregion

            #region Ana Yemek Listesi
            lstAnaYemekler.Items.Add("Tel Şehriyeli Bulgur Pilavı");
            lstAnaYemekler.Items.Add("Peynirli Makarna");
            lstAnaYemekler.Items.Add("Sade Pirinç Pilavı");
            lstAnaYemekler.Items.Add("Sade Bulgur Pilavı");
            lstAnaYemekler.Items.Add("Arpa Şehriyeli Pirinç Pilavı");
            lstAnaYemekler.Items.Add("Meyane Pilavı");
            lstAnaYemekler.Items.Add("Bolonez Soslu Makarna");
            lstAnaYemekler.Items.Add("Erişte Güveç");
            lstAnaYemekler.Items.Add("Sebzeli Bulgur Pilavı");
            lstAnaYemekler.Items.Add("Su Böreği");
            lstAnaYemekler.Items.Add("Sebzeli Erişte");
            lstAnaYemekler.Items.Add("Cevizli Erişte");
            lstAnaYemekler.Items.Add("Yoğurtlu Havuç Trator");
            lstAnaYemekler.Items.Add("Soslu Karışık Kızartma");
            #endregion

            #region Yemek Yanında Listesi
            lstYemekYanında.Items.Add("Karpuz");
            lstYemekYanında.Items.Add("Çoban Salatası");
            lstYemekYanında.Items.Add("Cacık");
            lstYemekYanında.Items.Add("Kase Yoğurt");
            lstYemekYanında.Items.Add("Karışık Turşu");
            lstYemekYanında.Items.Add("Havuç Rulo");
            lstYemekYanında.Items.Add("Patlıcan Kuleleri");
            lstYemekYanında.Items.Add("Fırında Baharatlı Patates");
            lstYemekYanında.Items.Add("Karışık Sebzeli Mantar Dolması");
            lstYemekYanında.Items.Add("Fırında Kaşarlı Patates");
            #endregion

            #region İçecek Listesi
            lstİcecekler.Items.Add("Su");
            lstİcecekler.Items.Add("Limonata");
            lstİcecekler.Items.Add("Kase Ayran");
            lstİcecekler.Items.Add("Cola Cola");
            lstİcecekler.Items.Add("Türk Kahvesi");
            lstİcecekler.Items.Add("Çay");
            lstİcecekler.Items.Add("Nescafe");
            lstİcecekler.Items.Add("Americano");
            lstİcecekler.Items.Add("Soğuk Kahve");
            lstİcecekler.Items.Add("Ihlamur");
            lstİcecekler.Items.Add("Fanta");
            lstİcecekler.Items.Add("Ice Tea");
            lstİcecekler.Items.Add("Meyve Suyu(Şeftali)");
            lstİcecekler.Items.Add("Meyve Suyu(Kayısı)");
            lstİcecekler.Items.Add("Meyve Suyu(Karışık)");
            lstİcecekler.Items.Add("Sprite");
            lstİcecekler.Items.Add("Sıcak Çikolata");
            lstİcecekler.Items.Add("Nane Limon");
            #endregion

            #region Tatlı Listesi
            lstTatlılar.Items.Add("Çikolatalı Puding");
            lstTatlılar.Items.Add("Aşure");
            lstTatlılar.Items.Add("İrmik Helvası");
            lstTatlılar.Items.Add("Kazandibi");
            lstTatlılar.Items.Add("Tulumba Tatlı");
            lstTatlılar.Items.Add("Şöbiyet");
            lstTatlılar.Items.Add("Kadayıf");
            lstTatlılar.Items.Add("Şekerpare");
            lstTatlılar.Items.Add("Revani");
            lstTatlılar.Items.Add("Baklava");
            #endregion
        }
        int fiyatBilgisi;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region Yemekleri Listeye Ekleme ve Fiyatlandırma
            if (lstSuluYemekler.SelectedIndex != -1)
            {
                lstSiparişler.Items.Add(lstSuluYemekler.SelectedItem);
                lstSuluYemekler.ClearSelected();
                fiyatBilgisi += 30;
                lblTutar.Text = "Toplam Tutar: " + fiyatBilgisi;
            }
            if (lstAnaYemekler.SelectedIndex != -1)
            {
                lstSiparişler.Items.Add(lstAnaYemekler.SelectedItem);
                lstAnaYemekler.ClearSelected();
                fiyatBilgisi += 30;
                lblTutar.Text = "Toplam Tutar: " + fiyatBilgisi;
            }
            if (lstAraYemekler.SelectedIndex != -1)
            {
                lstSiparişler.Items.Add(lstAraYemekler.SelectedItem);                
                lstAraYemekler.ClearSelected();
                fiyatBilgisi += 30;
                lblTutar.Text = "Toplam Tutar: " + fiyatBilgisi;
            }
            if (lstYemekYanında.SelectedIndex != -1)
            {
                lstSiparişler.Items.Add(lstYemekYanında.SelectedItem);                
                lstYemekYanında.ClearSelected();
                fiyatBilgisi += 30;
                lblTutar.Text = "Toplam Tutar: " + fiyatBilgisi;
            }
            if (lstİcecekler.SelectedIndex != -1)
            {
                lstSiparişler.Items.Add(lstİcecekler.SelectedItem);                
                lstİcecekler.ClearSelected();
                fiyatBilgisi += 30;
                lblTutar.Text = "Toplam Tutar: " + fiyatBilgisi;
            }
            if (lstTatlılar.SelectedIndex != -1)
            {
                lstSiparişler.Items.Add(lstTatlılar.SelectedItem);                
                lstTatlılar.ClearSelected();
                fiyatBilgisi += 30;
                lblTutar.Text = "Toplam Tutar: " + fiyatBilgisi;
            }
            #endregion
        }

        
        private void btnListeSil_Click(object sender, EventArgs e)
        {
            #region Siparişler Listesinden Değer Silme
            lstSiparişler.Items.Remove(lstSiparişler.SelectedItem);
            fiyatBilgisi -= 30;
            lblTutar.Text = "Toplam Tutar: " + fiyatBilgisi;
            #endregion
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            #region Sipariş Tamamlama
            MessageBox.Show("Toplam Sipariş Tutarınız: "+fiyatBilgisi+"\nSiparişinizi" +
            " Kat Görevlisi En Kısa Sürede Getirecektir.","Siparişiniz Tamamlandı",
            MessageBoxButtons.OK,MessageBoxIcon.Information);
            #endregion
        }
        #region Kapatma
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
