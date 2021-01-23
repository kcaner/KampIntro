using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //public void BasvuruYap()

        //Method injection-Sadece soyut halleri var ben onları injecte ettim 
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Çeşitli bilgiler alırız 
            //Başvuran bilgilerini değerlendirme 
            //Bu şekilde yaar isem tüm başvuruları konut kredisi üzerinden hesaplatmış oluruz.
            //Tüm başvuruları KonutKredisine bağımlı hale getirdin.

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            
            krediManager.Hesapla();  //ihtiyac,konut,taşık kredilerinden hangisin gönderir isem onun bellekteki referans numarası çalışır.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
           
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)//Listedeki her bir kredinin hesplamasını yap
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
        

    }
}
