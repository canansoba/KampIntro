using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        { // key,value

            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(456,"harun");
            //Console.WriteLine(ogrenciler.Length);
            ogrenciler.Add(123, "canan");
            Console.WriteLine("****************");
            Console.WriteLine("Listede bulunan öğrenci sayısı : "+ogrenciler.Length);
            Console.WriteLine("****************");
            Console.WriteLine("Öğrenci isimleri" + "\n");
            foreach (var item in ogrenciler.Values)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("****************");
            Console.WriteLine("Öğrenci numaraları" + "\n");
            foreach (var item in ogrenciler.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************");
          



        }
    }
}
