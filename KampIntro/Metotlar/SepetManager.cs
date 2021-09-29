using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + product.UrunAdi);
        }

        public void Add2(string urunAdi , string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urunAdi);
        }

    }
}
