using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager//base-ebeveyn görevi görür-tek başına birşey ifade etmez
        //interface benim şablonum görevi görüyor.
        //bir interface der ki Eğer biri u interface i kullanırsa o arkadaşım Hesapla metod'unu kullannmak zorunda.
        //Birden fazla metot olabilir.
        //Biz interface leri I harfi ile kullanırız interface olduğunu anlamak için. yoksa hata verir. 
    {
        void Hesapla();
        void BiseyYap();
    

        //İnterfacleri birbirinin aynı olan ama kod içerikleri farklı olan durumlar için kullanırız. 
    }
}
//Örneğin Projemizde Loglama yapmak istiyoruz. Logalama kim ne zamn hangi operasyonu çağırdığıdır.Bir nevi o sistemde olan hareketleri döktüğümüz dökümdür.
//Loglarımızı bir dosyada tutabiliriz.Veri tabanında tutabiliriz.SMS olarak gönderebiliriz.
//SMS göndermek te Loglamanın alternatifidir.
//Hepsinde yapılan işlem Loglamadır.