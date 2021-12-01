using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void MakeAnApplication(ICrediManager crediManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerinin değerlendirilmesi
            crediManager.Calculate();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
