using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        { //hepsini komentle controle kc gei al controle cu
            //string[] isimler = new string[] {"Canan", "Harun", "Samet", "Esra"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Canan", "Harun", "Samet", "Esra" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            Console.WriteLine("------");
            //Tüm Listeyi Yazdır
            //isimler2.ForEach(isim => Console.WriteLine(isim));
            //Console.WriteLine("--------");
            //foreach (var isim in isimler2)
            //{
            //    Console.WriteLine(isim);
            //}
            //Listeden istediğin indeksi sil
            //isimler2.RemoveAt(0);
            //isimler2.ForEach(isim => Console.WriteLine(isim));

        }
    }
}
