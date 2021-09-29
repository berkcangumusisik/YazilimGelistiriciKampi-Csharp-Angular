using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Product
    {
        //Property - Özellik
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }
    }
}
