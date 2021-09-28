using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {

            Products product1 = new Products();
            product1.ProductID = 1;
            product1.ProductName = "Iphone 13 128 GB Cep Telefonu";
            product1.ProductPrice = "11.999 TL";

            Products product2 = new Products();
            product2.ProductID = 2;
            product2.ProductName = "Xiaomi Redmi 9t 128 Gb Akıllı Telefon Gri";
            product2.ProductPrice = "2.899 TL";

            Products product3 = new Products();
            product3.ProductID = 3;
            product3.ProductName = "Samsung Galaxy A52 128 Gb Akıllı Telefon Siyah";
            product3.ProductPrice = "4.399 TL";

            Products[] product = new Products[] { product1, product2, product3 };


            //For Döngüsü

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(" Ürün Numarası: " + product[i].ProductID + " Ürün Adı: " + product[i].ProductName + " Fiyat: " + product[i].ProductPrice);
            }

            Console.WriteLine("------------------------");

            foreach (var urun in product)
            {
                Console.WriteLine(" Ürün Numarası: " + urun.ProductID + " Ürün Adı: " + urun.ProductName + " Fiyat: " + urun.ProductPrice);
            }


            Console.WriteLine("----------------------");

            int productNumber = 0;
            while (productNumber < product.Length)
            {
                Console.WriteLine(" Ürün Numarası: " + product[productNumber].ProductID + " Ürün Adı: " + product[productNumber].ProductName + " Fiyat: " + product[productNumber].ProductPrice);
                productNumber++;
            }
        }

    }


    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
    }
}
