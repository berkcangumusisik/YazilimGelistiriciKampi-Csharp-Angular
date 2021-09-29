using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            
            Product urun2 = new Product();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { urun1, urun2 };

            //type safety - Tip Güvenliği
            foreach (var product in products)
            {
                Console.WriteLine(product.UrunAdi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("--------------Metotlar---------------");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(urun1);
            sepetManager.Add(urun2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Add2("Elma", "Yeşil Armut", 12,9);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12,8);
            
        }
    }
}

/* METOTLAR
 - Tekrar tekrar kullanmamızı sağlar
 - Don't repeat Yourself- DRY - Kendini tekrar etme
 - Eğer ortak kodlar varsa birer metot haline getir.
 - Kod yazarken clean code olmasına dikkat et.
 - C# ve Java gibi dillerde temel yapılar metotlar ile yazılır.
 - Class sonunda manager varsa operasyon tutar.
 - Encapsulation kapsülleme işlemi ayrı ayrı yazılacak kodu düzene sokmaktır.
 */