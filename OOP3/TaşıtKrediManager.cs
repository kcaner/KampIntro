using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TaşıtKrediManager : IKrediManager//İnherit ettiğimden Taşıt kredi manager kredimanger daki hesapla fonk. sahip

    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
