using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Kampın 1. Gününden Selamlar.");
            Console.WriteLine("Kategoriler");
            Console.WriteLine("Kategoriler");
            Console.WriteLine("Kategoriler");
            Console.WriteLine("Kategoriler");
            string kategoriEtiketi = "Kategoriler";
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);

            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
        }
    }
}


/*
 * Main fonksiyonu içerisinde ne yazıyorsa o çalışır.
 * Console.WriteLine : Ekrana baskı yapmayı sağlar.
 * Console yazılımcılar yoğun olarak kullanır. Nasıl göründüğünden ziyade önce hangi veri geldiğini gösterir.
 * degiskenTuru degiskenAdi = deger ; şeklinde değişkenler oluşturulur.
 * Değişken isimlendirirken camelCase kullanılır .
 * Type Safety: Tip Güvenliği
 * C# ve java gibi diller type safety kısmında python'a göre daha katıdır .
 * String ifadeleri yazarken çift tırnak kullan.
 * Her satırın sonunda ; unutma
 * Değişken tanımlamanın amacı değişeceği zaman çok zaman harcanmasıdır. Eğer bir değişkene atanırsa belki bir satır düzenleme ile yüzlerce satır güncellenir.
 * Do not repeat yourself - kendini tekrar etme.
 * String metinsel ifadeleri tutar.
 * int tam sayıları tutar.
 * double ondalıklı sayıları tutar.
 * Bool true ya da false değerini tutar.
 * if yapısı
 if (sart)
{
    Sart geçerliyse burası çalışır.
}
 * if - else if - else yapısı bir arada çalışmaz. Eğer if doğruysa if , else if doğruysa else if , eğer hiçbiri doğru değilse else çalışır.
 * 
*/