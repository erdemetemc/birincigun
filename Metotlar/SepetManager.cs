using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun y)
        {

            Console.WriteLine("Tebrikler. Sepete Eklendi:"+ y.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi:" + urunAdi);
        }
    }
}
