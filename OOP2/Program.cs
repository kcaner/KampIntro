using System;

namespace OOP2
{
    //OOP= object operation programming
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Sayadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "1111111111";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?"; //Ama benim bir şirketim yok bireyselim



            //Gerçek Müşteri - Tüzel Müşteri bunlar birbirinin yerine asla kullanılamaz.
            //SOLİD 'in L si bunu söylüyor.

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Sayadi = "Demiroğ";
            musteri1.TcNo = "1234567890";
            musteri1.Id = 1;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //**** EpicPen = Hocanın kullandığı sanal kalem programı
           //Musterihem tüzel hem gerçek müsterinin ref nosunu tutabiliyor                         
                                    //Bellekteki bir referans no
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            

               
        }
    }
}
