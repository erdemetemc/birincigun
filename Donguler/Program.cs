using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string Kurs2 = "Programlamaya Başlangıç İçin Temel Kurs ";
            string kurs3 = "Java Kursu";
            string bosluk = "\n"; //Console.WriteLine(bosluk) dediğim zaman otomatik satır boşluğu bırakacak
            // \t bir Tab boşluk bırakır
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs ",
                "Java Kursu","Python","C#"};
            // array = dizi [] array demek
            //  array olduğu zaman köşeli kullanmamız gerekiyor
            {
                Console.WriteLine(kurslar[1]);  // hepsini sıralı yazdıramazsın.
                // Sıralı yazdırmak istersen for ( int i şeklinde yazdırmam gerek
                // burda ilk değer i=1 den değil 0 dan başlar. 
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]); //sadece i yazarsak düz sayaç çalışır.
                // kurslar[i] yazarsam kurslar dizisini elemanları i++ kadar yazar
            }
            Console.WriteLine("Boşluk\n");
            for (int i = 0; i < kurslar.Length; i++)
                // isim.Length yazarsak içindekilerin uzunluğu kadar atar
            {
                Console.WriteLine(kurslar[i]);
                Console.WriteLine("\n");  // Bu döngü içerisinde boşluklu yazmamızı sağlar 
                //eğer dışına alırsak sadece bir tane boşluk bırakır
            }
            
            Console.WriteLine("\nSayfa Sonu"); //\n nereye koyarsam ona göre satır boşluğu koyar

            Console.WriteLine(bosluk);

            foreach (string kurs in kurslar)   //bu kısım python daki for x in y mantığı
                // döngüyü tek tek dönebiliyor.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine(bosluk);

                for (int i = 1; i < 10; i++) 
                //+=2 yazarsan 2 2 artar anlamı i++ olan i=i+1 demek i+=2 demek i=i+2 demek 
                // int yerine double yazarsak ve ondalık sayı ekleyerek değerlere ulaşabiliriz
                // <= yazarsak sondaki sayıyı da dahil ediyor 
                {
                Console.WriteLine(i); 
                }
        }
    }
}
