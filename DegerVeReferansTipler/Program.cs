using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = sayi1;
            sayi2 = 65;
            //sayi1 ??  30
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //----Değer tip---
            ///sayialar1[0]  ?  999 muş.
            ///sayısal veri tiplari= int , decimal, float,double,bool(1,0)bool,stack = değer tiplidir.
            ///array,class,interface = bunlar referans tipli olarak karşımıza çıkmaktadır. 
            ///ellekte stack ve heap olarak alan var
            ///değer tip olanlar stack'te geçekleşiyor.sayi 1 ve sayi 2 burda
            ///sayi 1'in değeri eşittir 10 . sayi2'nin değeri eşittir 30.
            ///-------
            ///---Referans tipte---- 
            ///stackte sayilar1 olarak bir değşken tanımladım 
            ///new dediğim anda sayilar 1 için heapte yeni bir alan oluştur ve verieri oraya yaz demek.
            ///Bu ikisinin bağlantısı 
            ///aslında bu hipte bunun bir adresi var bir adres değeri tutuyor.
            ///atıyorum buna 101 diyoruz.heap te yeni bir yer oluştur demek.
            ///sayilar1=sayılar2 dediğin de aslında sayilar1 in referans numarası eşittir sayilar2 ninkine diyorsun.yani 1. adresi 102 yapıyorsun.
            ///artık 101. referans numarası ile bir ilgisi kalmadı.  102. adresi kopyaladı. Bu karşımıza C dilinde poiter olarak çıkar.
            ///101 deki veriler .et core'un garbage collektor dediğimiz çöp toplaycısı onun bir yeri olmadığından bellkete atacaktır.




        }
    }
}
