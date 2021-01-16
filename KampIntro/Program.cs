using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            // Do not repeat yourself
            //string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            //bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butone");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }


            /*if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }*/

            /*Console.WriteLine(kategoriEtiketi);
            Console.WriteLine("--------");
            Console.WriteLine("Kategori");*/

        }
    }
}
