using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //ProductManager içerisinde çeşitli operasyonlar barındırır. (Ekleme--çıkarma vb.)

    class ProductManager
    {
        //public void Add(Product product)   //Ekleme operasyonu(fonksiyonunu ,Metodunu)
       // {
                            //Bana Product tütründe birşey(product) ver
            public void Add(Product product)//Bana sitring türünde bir ad ver.verilen değeri buraya yazacak.
                                            //Sen bana Product türünde bir şey yollayacaksın ben onu product türünde değişkende tutucam.
            {
            Console.WriteLine(product.ProductName + " eklendi."  );

            //*******void = git güncelle git getir emitr kipiyle yaptığımız işlemlerde kullanılır.

            }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        /*
        public int Topla (int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)//void de return kullanılmaz.

        //******Void'i işlem sonucunda çıkan sonucu ben tekrar kullanmak istediğimde.Program akışında başka bir metod ta ben onu çağırabilirim.
        //*******Void 'te bu yok kayboldu emir yaptı. Bunu da int ile tuttuk.Bunun için biz Return ile döndürdük.
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        */


        /* product.ProductName = "Kamera"; // 101 numaralı adresteki değeri yazdı. 


     public void BiseyYap (int sayi)
     {
         sayi = 99; //main'de ne yazacaktır.

     }

        //}
        */
    }
}

//product managerdaki Add fonksiyonunun product değişkeni o fonksiyon için tutucu bi değer. 
//Yani program.cs'deki product1 Add fonksyonunun product parametresine eşit olur.
