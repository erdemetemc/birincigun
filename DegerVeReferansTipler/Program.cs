﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30
            Console.WriteLine(sayi1); // 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; // array koyduğumuz zaman bu işlem sayilar1 in çıkışı sayılar ikinin değerlerine eşit oluyor.
            sayilar2[0] = 999;
            // sayilar1[0]  ?? 999

            Console.WriteLine(sayilar1[0]); //999
            Console.WriteLine(sayilar1[1]);
            Console.WriteLine(sayilar1[2]);
        }
    }
}
