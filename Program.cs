using System;

namespace Metodlar
{
    class Program
    {
        public static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Ad = "elma";
            urun1.Aciklama = "meyve";
            urun1.Fiyat = 5;

            Urun urun2 = new Urun();
            urun2.Ad = "armut";
            urun2.Aciklama = "meyve";
            urun2.Fiyat = 8;

            Urun urun3 = new Urun();
            urun3.Ad = "kiraz";
            urun3.Aciklama = "meyve";
            urun3.Fiyat = 9;

            Console.WriteLine(urun1.Ad+" "+ urun1.Aciklama+" "+ urun1.Fiyat+" ");

            Urun[] urunler = new Urun[] {urun1,urun2,urun3 };
            foreach (var urunum in urunler)
            {
                Console.WriteLine(urunum.Ad);
                Console.WriteLine(urunum.Aciklama);
                Console.WriteLine(urunum.Fiyat);
                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("----------------Metodlar---------------");

            SepetManeger sepetManeger = new SepetManeger();

            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);
            sepetManeger.Ekle(urun3);
            sepetManeger.Ekle(urun3);

            sepetManeger.Ekle2("elma", "kırmızı",12);
            sepetManeger.Ekle2("armt", "mor", 12);
            sepetManeger.Ekle2("karpuz", "yesil", 12);






        }
    }
}
