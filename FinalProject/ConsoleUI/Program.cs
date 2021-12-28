using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}

/*
 * Abstract içine soyut nesneleri, Concrete içineyse somut nesneleri ekliyoruz.
 * Public bu classa da diğer katmanların ulaşmasını sağlar.
 * IEntity implement eden class bir veritabanı tablosudur.
 *
 */