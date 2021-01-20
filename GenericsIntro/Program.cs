using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string> ();//Generic bir class çalkışacağı tipi söylemem gerekiyor.
            isimler.Add("Engin");
            Console.WriteLine("Hello World!");
        }
    }
}

//Count==eleman sayısı
//ew lemek bellete referas oluşturmak demekti.