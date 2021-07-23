using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            //Array - Dizi
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java"};

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------");

            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------");

            for (int i = 0; i < kurslar.Length; i ++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("-----------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("Sayfa sonu - footer");

        }
    }
}
/* For Döngüsü İskeleti
 * for (int i = 0; i < length; i++)
   {

    }
 * i = 0 başlangıç değeri
 * i < length şart
 * i++ i değerini bir artır.
 * i += 2 i değerini 2 artırır.
 * 
ARRAY - Diziler
 * Tek tek tanımlamak yerine bir çok veriyi bir arada tutmayı sağlar.
 * C#'ta sayma sıfırdan başlar.
 * .Length eleman sayısını verir.
 * 
 * Foreach yapısı
 * Dizi temelli yapıları döndürmeyi sağlar.
 * Dizilere uygulanır.
 * item takma isim
 * collection dizinin ismi
foreach (var item in collection)
{

}
*/