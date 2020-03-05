using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParçaAlımOtomasyonu.Ana_Formlar;
using ParçaAlımOtomasyonu.Ürün_İşlemleri;

namespace ParçaAlımTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void AdminGiris()
        {
            string kullanıcıAdı = "admin";
            string Şifre = "1234";
            AdminControl ac = new AdminControl(kullanıcıAdı,Şifre);
        }
        [TestMethod]
        public void SatınAlmaGiris()
        {
            string kullanıcıAdı = "bmunja";
            string Şifre = "1327";
            SatınAlmaControl sac = new SatınAlmaControl(kullanıcıAdı, Şifre);
        }
        [TestMethod]
        public void BirimYetkiliGiris()
        {
            string kullanıcıAdı = "bmunja";
            string Şifre = "1327";
            int bölüm = 3;
            BirimYetkiliControl byc = new BirimYetkiliControl(kullanıcıAdı, Şifre,bölüm);
        }
        [TestMethod]
        public void Zimmetleme()
        {
            int urunid = 7;
            int personelid = 10;
            int adet = 3;
            ZimmetlemeControl zc = new ZimmetlemeControl(urunid,personelid,adet);
        }
        [TestMethod]
        public void AtıkKontrol()
        {
            int urunid = 5;
            int personelid = 5;
            int adet = 1;
            AtıkKontrolControl akc = new AtıkKontrolControl(urunid, personelid, adet);
        }

    }
}
