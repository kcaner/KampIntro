using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro // Hoca olsa List'i nasıl yazardı.
{
    class MyList<T>//T=Type (istediğimizi de yazabiliriz). Programcı o anda ne tipte bir değiken verdiyse o olsun.
    {
        T[] items;
       
        public MyList()//ctor tab+tab yaptık konstraktır dedik. //constructor  oldu..
        {
            items = new T[0]; // dediğim anda başlangıç 0 elemanlı olarak new 'lemem lazım 
        }
        public void Add (T item)//item =eleman desemde olur.
        {
            T[] tempArray = items;//T türünde geçici dizi. Geçici olarak bir arkadaşıma verdim.Yeni referasn numaras vermek demek o elemanların uçması demek 
            //uçmasın diye bir geçici array ile tuttum.
            items = new T[items.Length+1];//String listenin elemans sayısını 1 arttırıp eleman ekliyorum.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                
            }

            items[items.Length - 1] = item;
        }
    }
}
