using System;

namespace birincigun
{
    class Program
    {
        static void Main(string[] args)
        {   //Console.WriteLine (" Kategori " ) bu çıktı almaya yarıyor. 
            string kategoriEtiketi = "Kategori";
            string egitmenEtiketi = "Eğitmen";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            double ucukSayilar = 1500000000000000000;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            { 
                Console.WriteLine("Azalış Butonu"); 
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Dolar Değişmedi Butonu");
            }
           
            bool sistemeGirisYapmisMi = false;


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");


            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu ");
            }           
            Console.WriteLine(kategoriEtiketi);


            

        }
    }
}
