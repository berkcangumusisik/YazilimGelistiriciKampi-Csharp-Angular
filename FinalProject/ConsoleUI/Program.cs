using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40,100))
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