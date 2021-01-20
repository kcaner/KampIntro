using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //intellisens açıldığında açılan hazır kodlar snipped denir
    class Product //Entitiy(VArlık) gibi isimler verilir genellikle.

    {
        //Genelde bu sıralama ile yazılır kodlar.
        public int Id { get; set; } // Bir nesneyi diğerinde ayırmak için kullanılan kimlik (TC) (Ana anahtar =Ayıran Bu)
        public int CategoryId { get; set; } //(Referans anahtarlar.)
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }// (Ürünün birim fiytı)
        public int UnitInStock { get; set; } //(Stok adedi)

        //CRUD Operasyonlar bu tarz veri girişleri.Otomasyon veri tabanı programlama.



    }
}
