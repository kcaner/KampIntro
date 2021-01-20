using System;

namespace OOP1
{
    class Program
    {
        //Burası main'im
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5,
               ProductName="Kalem",UnitPrice=35};//Bu şekilde de bir tanımlama ve ürün ekleyebiliriz.


            //ProductManager productManager = new ProductManager(); //Bu bir örneklemedir.Product Manager türünde product manager.

            //PascalCase     //camelCase(Class değişken ismi)
            //case sensitive (Büyük küçük harf duyarlı)

            //Stack                             //Heap
            ProductManager productManager = new ProductManager();    //101 Bellek adresi
            productManager.Add(product1); // (product değişkenini yolla)
            Console.WriteLine(product1.ProductName); //Değeri "Kamera"

            /*
            productManager.Topla2(3, 6);

            int toplamaSonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamaSonucu*2); // (productManager.Topla(3, 6)*2) byle de yazabilirim.

            */

           /* int sayi = 100;
            productManager.BiseyYap(sayi);//(direkt 100 yazdı.Class a yollamadı)
            Console.WriteLine(sayi); //Değeri 100

            //int, double,bool ... değer tip(genelde saysallar)Atamalar değeri üzerinden olur ve orada bağlantsını keser 
            //diziler,class, abstract class,interface... referanas tip...(atamalar, atamanın numarsı ile yapılır bellekteki adresi ile yani)
           */


            //ref out anahtarı.

        }
    }
}
//Classlar İçerisinde operasyoın 