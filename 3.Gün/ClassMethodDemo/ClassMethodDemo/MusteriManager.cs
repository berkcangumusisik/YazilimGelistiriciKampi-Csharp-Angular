using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriID + " Numaralı Müşteri Silindi: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriID +" Numaralı Müşteri Güncellendi: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
    }
}
