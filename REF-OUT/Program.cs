using System;

namespace REF_OUT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*değer tiplerde verinin değeri fonksiyona direk gönderilir. 
             Eğer metodun içerisinde değişken değeri ile ilgili bir değişim yapılırsa 
             orjinal değer etkilenmez. Referans (REF) metodu ile gönderildiğinde ise
             değişken üzerinde yapılan tüm değişikliklerden verinin orjinal değeri etkilenir.
             */
            /* REF ve OUT farkı 
            Refde mutlaka değişkenin değeri olması gerekli ama 
             Out da böyle bir zorunluluk yok.*/
            /*OUT da değişkene ilk değer atanmasının bir anlamı yoktur.
             Fonksiyon içerisinde mutlaka onun değeri belirlenmelidir.*/
            int a = 20;
            int b = 100;
            int c = 120;
            int d = 10;
            int e;
            int f = 200;
            var result = Cross(ref a, b);
            Console.WriteLine(result);
            Console.WriteLine("A'nın referans değer görünümü"+"="+a);
            var result2 = Divide(c,d);
            Console.WriteLine(result2);

            var result3 = Add(out e, f);
            Console.WriteLine(result3);
            Console.WriteLine("E'nin referans değer görünümü" + "=" + e);
        }

        static int Cross(ref int a, int b)
        {
            a = 30;
            return a * b;

        }

        static int Divide (int c, int d)
        {
            return c / d;
        }

        static int Add(out int e, int d)
        {
            e = 50;
            return e + d;
        }

    }
}
