using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            //urun1.StokAdedi = 5;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            //urun2.StokAdedi = 8;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
               /* Console.WriteLine("Ürünün Adı :" + " " + urun.Adi + "\n" + "Ürünün Fiyatı :" + " " + 
                    urun.Fiyati + "\n" + "Ürünün Açıklaması :" + " " + urun.Aciklama);*/
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
                
            }

            Console.WriteLine("---------Metodlar-----------");


            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("------Alttakileri yapmıyoruz-------");
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Karpuz", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}

//dont repeat yourself = DRY - Clean Code - Best Practice 
