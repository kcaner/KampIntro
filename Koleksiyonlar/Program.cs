using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)  //*******  Ctrl+ K(komment) ,ctrl+c(uncomment), geri almak için    Ctrl+ K(komment) ,Ctrl+U (Yorum satırı yapma ve geri alma)
        {
            ////stack                 heap
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            ////Arrayler oluşturdusğumuz sınırlar içerisinde çalışmaktadır.

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];  //new dediğimiz anda bellekte yeni bir adres oluşur 5 elemanlı bom boş bir array oluştu.1,2,3, vb atamadım sadece 5 inci indexi atadım.
            //isimler[4] = "İlker"; //new demek yeni referasns  adresi demek önceki adresleri kaybederim.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

           // List<string> isimler2 = new List<string> ();      //Yukarıya kütüphaneyi ekledim yandaki amülden  sınıftaki List'i kullanmak için.
            //String arrayı değilde string listesi
             
            List<string> isimler2 = new List<string> {"Engin", "Murat" , "Kerem","Halil" } ;
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //(Koleksiyonlarda array 'ler gibi değerleri kaybetmemizi engelleyecek bir alt yapı var.)
            //Array'da yeni sınıf oluşturduğumda önceki değerler kayboluyordu ve ekeleyemiyrdum. Bunun için LİST kullandım.



        }
    }
}
