using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Berkcan";
            customer1.LastName = "Gümüşışık";
            customer1.ID = 1;
            customer1.TCNo = "12345678910";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.ID = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new CoorporateCustomer();
            Customer customer4 = new IndividualCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
/*
 * Classlar içerisinde operasyon ya da özellik tutarlar.Eğer operasyon tutuyorsa özellik tutamaz. Özellik tutuyorsa  operasyon tutamaz.
 * Bir nesnede bir değeri kullanmak zorunda değilsen soyutlama hatası yapıyorsun demektir.
 * Gerçek Müşteri - Tüzel müşteri birbirinin yerine kullanılamaz.
 * Inheritance yapınca miras verdiğimiz her sınıfın referansını tutar.
 */