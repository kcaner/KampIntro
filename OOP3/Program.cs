using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TaşıtKrediManager tasitKrediManager = new TaşıtKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Yada şöyle yazabilirdim.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //İnterfacelerde o interfece 'i implemente eden class'ın referansını tutabiliyormuş. 
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TaşıtKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //yukarıdakiler bir açılır panel olsun. 
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //Bu yapılanlar Polimorphism

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager()/*,tasitKrediManager*//*new DataBaseLoggerService()böylede yapabilirsin*/,loggers);
            //Ya da 
            // basvuruManager.BasvuruYap(new EsnafKredisiManager()/*,tasitKrediManager*//*new DataBaseLoggerService()böylede yapabilirsin*/
            //,List<ILoggerService> {new DatabaseLoggerService(),new SmsLoggerService() }  );


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //2/basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            

        }
    }
}
//SOLİD'in O harfi open Close Prensible sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz.
