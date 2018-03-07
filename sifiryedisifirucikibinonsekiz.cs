/*out ile değişkeni referans yapma
out kullanırken değişkene ilk değer atamak zorunda değiliz*/
using System;

namespace Application
{
    class Program
    {
        static void ornek(out int a)
        {
            a=20;
        }
        static void Main(string[] args)
        {
            int b;
            // b=10;
            //Console.WriteLine(b);
            ornek(out b);
            Console.WriteLine(b);
        }
    }
}

/* OVERLOAD - İMZA ÖRNEĞİ*/
using System;

namespace Application
{
     class Ornek
    {
        static void Test(int a,int b)
        {
            Console.WriteLine("int'li metot çalıştı");
        }
        static void Test(string a, string b)
        {
            Console.WriteLine("string'li metot çalıştı");
        }
        static void Test(float a, float b)
        {
            Console.WriteLine("float'li metot çalıştı");
        }
        static void Main(string[] args)
        {
            Test("prog", "derSs");
            Test(3, 4);
            Test(3.45f, 1.2f);
        }
    }
}