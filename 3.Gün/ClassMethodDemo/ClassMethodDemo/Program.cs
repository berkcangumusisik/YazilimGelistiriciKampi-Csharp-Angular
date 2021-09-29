using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.MusteriAdi = "Berkcan";
            musteri1.MusteriSoyadi = "Gümüşışık";
            musteri1.MusteriDogumTarihi = 1999;
            musteri1.MusteriDogumYeri = "Ankara";


            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriAdi = "Şevval";
            musteri2.MusteriSoyadi = "Baydemir";
            musteri2.MusteriDogumTarihi = 2000;
            musteri2.MusteriDogumYeri = "Kayseri";


            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = 3;
            musteri3.MusteriAdi = "Nurana";
            musteri3.MusteriSoyadi = "Jumageldiyeva";
            musteri3.MusteriDogumTarihi = 2001;
            musteri3.MusteriDogumYeri = "Türkmenistan";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            foreach (var musteri in musteriler)
            {
                musteriManager.Add(musteri);
                musteriManager.Update(musteri);
                musteriManager.Delete(musteri);
                Console.WriteLine("---------------------------------");
            }


        }
    }
}
