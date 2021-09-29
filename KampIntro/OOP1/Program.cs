using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product { ID = 2, CategoryID = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


        }
    }
}


/*
 * Referans(Foreign Keyler) 2. sıraya yazılır.
 * CRUD Create , Read, Update, Delete 
 * void : Emir kipinde işlemi yapar. Ekstra bilgi gerekmez.
 * void verilen işlemi yapar ve çalışır.
 * void yerine farklı tür kullanmak bize return ile işlem sonucunda ortaya çıkan formulü kullanmayı sağlar.
 */