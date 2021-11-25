using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Berkcan");
            names.Add("Şevval");
            names.Add("Nurana");
            names.Add("Mete");
            names.Print();
            Console.WriteLine(names.Count);
        }
    }
}
