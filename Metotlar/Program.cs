using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 25;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun x in urunler) // in urunler ürünler dizisinin tek tek elemanını çağırır
                // x yerine urun yazadabilirsin anlamlı olsun diye yalnız karışmasın diye x yazıyoruz
                // Urun büyükle yazılan Urun tipini çağırıyor var da yazabilirsin
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine(x.StokAdedi);
                Console.WriteLine("------------");
            }


            Console.WriteLine("------------Metotlar-------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);



        }
    }
}
