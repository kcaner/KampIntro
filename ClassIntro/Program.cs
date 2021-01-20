using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            //Kodlama.İO daki kursların bulunduğu kısım.

            Kurs kurs1 = new Kurs();  //(yeni bir class değişkeni oluşturmak için bu tanımlamayı yapıyoruz.) 
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "EnginDemirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();  //(yeni bir class değişkeni oluşturmak için bu tanımlamayı yapıyoruz.) 
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();  //(yeni bir class değişkeni oluşturmak için bu tanımlamayı yapıyoruz.) 
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();  //(yeni bir class değişkeni oluşturmak için bu tanımlamayı yapıyoruz.) 
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //=yorum satırı =comment line or mine
            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + "   " +kurs1.IzlenmeOrani);

            // içinde kurs nesini barındıran kurs arrayı tanımladım.
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 } ;

            //Kurs veri tipi kurs takma isim.
            foreach (var kurs in kurslar) //kurs takma isim burda.forlada yazabilirim.


            {
                Console.WriteLine(kurs.KursAdi + " : "+kurs.Egitmen);
            }



        }
    }

    class Kurs
    {
        //Prob = proberty den gelir. yazdık tab tab yaptık
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }


}
