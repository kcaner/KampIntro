using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //cs C# tan gelmektedir 
            //3' ü birlikte bir classtır aslında. 
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };


            Urun urun1 = new Urun(); //Buna calssın örneği denir. (ürün türünde ürün1)
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler) //İn urünler dediğinde benim ürünler dizimin her bir elemanını tek tek gez.
                //urun aslında döngümn süslü paratez ürün sayim kadar döner urun yerine x de desen olabilmektedir.Alamlı olsun diye urun dedik.
                //neden Urun diyoruz çünkü C# type-safe  ürün güvelidir. Ben ne ile çalışıcam.var desen de olur Urun clasını yakalar.

            {
                //Web sitesinde 
                //li=liste elemanı
                //<li> buraya bir ürün yazıyor. </li>

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }


            //Encupsulationkapsülleme) Stokadedinin metod olarak girilmesidir.Bir class oluşturarak girilmesidir.Ayrı ayrı yazacağın bir şeyi bir kapsüle sğdırıyorsun.

            Console.WriteLine("-------------Metotlar----------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //Bunların hepsiş başka sayfalardki sepete ekle butonu . Başka sayfalarda sen bunu çağırıyorsun.
           
            sepetManager.Ekle2("Armut", "Yeşil elma" , 12 ,15); // tüm sayfalar patladı sen stok adedini de girince her yeri tek tek değiştirmen gerekmektedir.
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);


        }
    }
}

//Metotlar bize tekrar ekrar kullanılabilen bir ortam sağlamaktadır.
//Do not repeat yorself - DRY - Clean Code - Best Practice = doğru uygulama teknikleri


