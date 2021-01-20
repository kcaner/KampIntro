using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type syfety = tip güvenliği   yazım kurallarını eanlatmak için kullanılır.
            
            //Do not repeat yourself = Kendini tekrarlama
            //Değer tututcu,Alias (kategoriEtiketi)
            string kategoriEtiketi = "Katagori"; //metinsel ifadeler terk tırnalkla yapmıyoruz C# ta "" ile yapılmalıdır.
            int ogrenciSayisi = 32000;           //int = sayısal verileri tutmak için kullanırım.
            double faizOrani = 1.45;                     //ondalıklı sayımızı double ile tutabiliriz.
            bool sistemeGirisYapmısMı = true;   //sisteme giriş yapmış nmı yapmamış mı = True ya da false  şeklinde verebilirim.(boolean)
                                                //sistemeGirişYapmiMiBiBak                //sisteme giriş yapmamışsa false yani else kısmı çalışır.True ise if kısmı çalışır.
                                                //gerçek hayatta true false kısmı dış bir kaynaktan gelir.

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
           
            }
            else
            {
                Console.WriteLine("Değişmedi Butunu");
            }



            if (sistemeGirisYapmısMı== true)
            {
                //<button> Kullanıcı ayrları <button>  normalde olacak olan budur.
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }


            Console.WriteLine(kategoriEtiketi);

        }
    }
}
