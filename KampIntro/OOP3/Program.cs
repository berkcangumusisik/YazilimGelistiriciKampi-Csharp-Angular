using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICrediManager tasitKrediManager = new TasitKrediManager();
            ICrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.MakeAnApplication(konutKrediManager,databaseLoggerService);
            List<ICrediManager> krediler = new List<ICrediManager>(){ihtiyacKrediManager,konutKrediManager,tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
/*
 * Interfaceleri birbirinin alternatifi olan ama kod içeriklerinin farklı olduğu zamanlarda kullanırız.
 */