using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
       // private object konutKrediManager;
       //Method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başburu bilgileri değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
            //foreach (var loggerService in loggerService)
            //{
            //    loggerService.Log();
            //}
            //konutKrediManager.Hesapla();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
