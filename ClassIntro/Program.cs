using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Etem";
            int yas = 25;
            string bosluk = "\n";
            string tab = "\t";
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;


            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);
            Console.WriteLine(bosluk + bosluk);

            Console.WriteLine("Kurs Adı \t Kurs Eğitmeni \t İzlenme Oranı"+ bosluk);
            Console.WriteLine(kurs1.KursAdi + "\t\t" + kurs1.Egitmeni + "\t\t" + kurs1.IzlenmeOrani+ bosluk);
            Console.WriteLine(kurs2.KursAdi + "\t\t" + kurs2.Egitmeni + "\t\t" + kurs2.IzlenmeOrani+ bosluk);
            Console.WriteLine(kurs3.KursAdi + "\t\t" + kurs3.Egitmeni + "\t\t" + kurs3.IzlenmeOrani);

            Console.WriteLine(bosluk + bosluk);
            Console.WriteLine(bosluk + bosluk);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var xKurss in kurslar)
            {
                Console.WriteLine(xKurss.KursAdi+ tab +  xKurss.Egitmeni+ tab + xKurss.IzlenmeOrani);
            }
        
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }    //prob Tab Tab yaptın geldi
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
