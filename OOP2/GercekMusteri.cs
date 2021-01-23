using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Burda Müsteri ebeveyn
    class GercekMusteri :Musteri //individiual ==Gerçek (yani Bireysel)
    {

        public string TcNo { get; set; } //Sayilardan oluşuyor ama neden long ya da string=Şundan dolayı bir veri uzerinde matematiksel islem yapmıyorso onu kullanmıyorsan 
                                         //Ona bir sayı görevi vermiyor isem onu string olarak tutmak daha iyidir.
                                         //Bunları string olarak tutmaz isek Ecxele atmaya çalışltığımızda hata verecektir.
                                         //*****Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsam o nesneye ait değilmiş gibi duruyorsa o alan----
                                         //Demek ki orada hata yapıyorsun, soyutlama hatası yapıyorsun demektir.

        public string Adi { get; set; }
        public string Sayadi { get; set; }
    }
}
