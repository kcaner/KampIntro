using System;

namespace Dongular
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüleri birbirini tekrar eden işlemler için kullanırız.Birşeyleri tekrar etmek için kullanıulan yapılardır.

            string kurs1 = "Yazılım Geliştirme Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array = dizi 'lerde tutarız python'da Liste olarak gördük

            //gerçek hayattta kurslarıGetir() ;  diye bir fonksiyon ile dış kaynaktan çağırılmaktadır.
            //döngüde veriler için hepsi içinb tek tek dönülmektedir.

            string[] kurslar = new string[] { "Yazılım Geliştirme Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python","C#" };

            for (int i = 1; i <kurslar.Length ; i++)   //1'den başla şart i<10 küçük olduğu sürece çalış 1 ,1 art.(i+=2 ya da i=i+2 der isek 2 ,2 artar)
                                                        //kursların Lenght i boyunca çalış ne kadar elemanı var ise o kadar çalışacaktır.
            {
                Console.WriteLine(kurslar[i]); //kursların i'ninci elemanını yazdırmak istiyorum.
            }

            Console.WriteLine("For Bitti");

            //dizileri dolaşmada genelde foraech kullanırız.
            foreach (string kurs in kurslar)  //birşey yazdığında menünün açılmasına intens denir.  (convension = yaım kuralı)

            //foraech = dizi temelli yapıları tek tek dönmeye,dolaşmaya yarıyor.

            //kursları (kurslar içerisinde) dolaş, buradaki kursa alias=takma deriz,buradaki kurs her bir elemanı dolaşmak için kullandığımız takma isim.

            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");

        }
    }
}


//Class 'lar = küçük resimin oldurğu kısım.Exelde müşterilerimizi tuttuğumuz bir kısım var .Exelde ; müşteri adı, Tc no doğum yeri
//class 'ları biz brde fazla veri tutabilmek i.in kullanıyoruz.