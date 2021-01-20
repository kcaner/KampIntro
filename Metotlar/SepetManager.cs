using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{

    //maneger ,dal vb. ifadeler görürsek bunlar birer operasyon tutuyor demektir.
    class SepetManager
    {
        //pythodaki DEF gibi
        //neming convention = isimlendirme kuralı
        //Bir yerde süslü paretez varsa orada bir fonk. kullaıyor demektir.
        //syntax yazım kuralları.
        //Bir fonksiyon yazdık.

        public void Ekle(Urun urun) //Büyük Urun tipi urun ise aşağıda kullanacağım isimlendirme.fonksiyonun içi boşsa bir işe yaramaz.() içerisindeki paraametere sen
            //ekeleyince ne ekliyorsun parametre(Ürün) ekiyorsun.
        {
            //basitbir Bir fonksiyon(Metot) yazdık. Ekle () fonksiyonu. Örneğin sepete ekle butonu ile eklediğin Sepete Ekle butonu gibi düşünebiliriz. 
            Console.WriteLine("Tebrikler.Sepete eklendi : "+urun.Adi );

          
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urunAdi);
        }

    }
}
