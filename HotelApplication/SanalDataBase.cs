using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class SanalDataBase
    {
        #region Personel Listesi
        public static List<PersonelBilgi> PersonelBilgiList = new List<PersonelBilgi>()
        {
            new PersonelBilgi
            {
                İsim="Mutlucan",
                Soyisim="Gökçukur",
                Yas=30,
                Deneyim="10 Yıl",
                YabancıDil="İngilizce\nAlmanca\nİspanyolca",
                TelefonNumara=FakeData.PhoneNumberData.GetPhoneNumber(),
                EmailAdres=FakeData.NetworkData.GetEmail("Mutlucan","Gökçukur"),
                PersonelNumara="00030",
                PersonelSifre=0030,
                GorevliOlduguKat="0"
            },
            new PersonelBilgi
            {
                İsim="Mahmut",
                Soyisim="Satici",
                Yas=27,
                Deneyim="6 Yıl",
                YabancıDil="İngilizce\nAlmanca",
                TelefonNumara=FakeData.PhoneNumberData.GetPhoneNumber(),
                EmailAdres=FakeData.NetworkData.GetEmail("Mahmut","Satici"),
                PersonelNumara="00027",
                PersonelSifre=0027,
                GorevliOlduguKat="1"
            },
            new PersonelBilgi
            {
                İsim="Yusuf Üzeyir",
                Soyisim="Kaya",
                Yas=21,
                Deneyim="2 Yıl",
                YabancıDil="İngilizce",
                TelefonNumara=FakeData.PhoneNumberData.GetPhoneNumber(),
                EmailAdres=FakeData.NetworkData.GetEmail("Yusuf Üzeyir","Kaya"),
                PersonelNumara="00021",
                PersonelSifre=0021,
                GorevliOlduguKat="2"
            },
            new PersonelBilgi
            {
                İsim="Muhammet Arda",
                Soyisim="Ünsalan",
                Yas=20,
                Deneyim="1 Yıl",
                YabancıDil="İngilizce",
                TelefonNumara=FakeData.PhoneNumberData.GetPhoneNumber(),
                EmailAdres=FakeData.NetworkData.GetEmail("Muhammet Arda","Ünsalan"),
                PersonelNumara="00020",
                PersonelSifre=0020,
                GorevliOlduguKat="3"
            },
            new PersonelBilgi
            {
                İsim="Serkan",
                Soyisim="Kuruçay",
                Yas=40,
                Deneyim="20 Yıl",
                YabancıDil="İngilizce\nAlmanca\nİspanyolca",
                TelefonNumara=FakeData.PhoneNumberData.GetPhoneNumber(),
                EmailAdres=FakeData.NetworkData.GetEmail("Serkan","Kuruçay"),
                PersonelNumara="00040",
                PersonelSifre=0040,
                GorevliOlduguKat="4"
            }
        };
        #endregion


        #region Müşteri Listesi
        public static List<MusteriBilgi> MusteriBilgiList = new List<MusteriBilgi>();

        public List<MusteriBilgi> MusteriListele()
        {
            Random rnd = new Random();
            for (int i = 1; i < 301; i++)
            {
                MusteriBilgi M1 = new MusteriBilgi();
                M1.İsim = FakeData.NameData.GetFirstName();
                M1.Soyisim = FakeData.NameData.GetSurname();
                M1.TelefonNumara = FakeData.PhoneNumberData.GetPhoneNumber();
                M1.Yas = rnd.Next(20, 80);
                M1.GirisZamanı = FakeData.DateTimeData.GetDatetime();
                M1.EmailAdres = FakeData.NetworkData.GetEmail(M1.İsim, M1.Soyisim);
                M1.OdaNO = i;
                if (i > 0 && i <= 100)
                {
                    M1.BulunduguKat = 0;
                }
                else if(i>100 && i<=200)
                {
                    M1.BulunduguKat = 1;
                }
                else if(i>200 &&i<=300)
                {
                    M1.BulunduguKat = 2;
                }
                MusteriBilgiList.Add(M1);
                
            }
            return MusteriBilgiList;
        }
        #endregion
    }
}
