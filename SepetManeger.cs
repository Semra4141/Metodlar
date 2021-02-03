using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManeger
    {

        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi"+ " " +urun.Ad);
        }
        public void Ekle2(string urunAdi, string UrunAciklama, double fiyat)
        {
            Console.WriteLine("sepete eklendi" + " " + urunAdi);
        }
    }
}