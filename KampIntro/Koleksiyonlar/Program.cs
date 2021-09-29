using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Berkcan","Engin","Murat","Kerem" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<String> {"Berkcan", "Engin", "Murat", "Kerem" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            



        }
    }
}


/*
 * Arraylar o sınırların dışına çıkamaz.
 * new dediğin zaman yeni bir array oluşur.
 * Diziler genişletilemez.
 * Koleksiyonlarda yeni eleman eklenebilir ve verileri kaybetmeden ekleme yapabiliriz.
 */
