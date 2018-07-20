/*out ile değişkeni referans yapma
out kullanırken değişkene ilk değer atamak zorunda değilim*/
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

/*bilinçsiz tip dönüşümü var int byte'ı kapsadığı için ekranda 2 tane
int'li metot çalıştı yazısını görüyorum*/
using System;

namespace Application
{
    class Ornek
    {
        static void Test(int a,int b)
        {
            Console.WriteLine("int'li metot çalıştı");
        }
        static void Test(byte a, byte b)
        {
            Console.WriteLine("byte'li metot çalıştı");
        }
        static void Main(string[] args)
        {
            Test(33,44);
            Test(333,443);
        }
    }
}

/*bilinçsiz tip dönüşümü var
int byte ve short'u kapsadığı için 3'üncüye de int yazdıracak*/
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
        static void Main(string[] args)
        {
            Test(3,4);
            Test("Prog","tek.");
            byte a = 5;
            short b = 10;
            Test(a, b);
        }
    }
}

/*char burda biliçnsizde int'e dönüyor*/
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
        static void Main(string[] args)
        {
            byte a = 5;
            short b = 10;
            Test(a, b);
            Test(3, 'd');
        }
    }
}

/*biliçnsiz tip dönüşümüyle int'i doubleye cast ettik*/
using System;

namespace Application
{
    class Ornek
    {
        static void Test(double a,double b)
        {
            Console.WriteLine("double'li metot çalıştı");
        }
        static void Test(decimal a, decimal b)
        {
            Console.WriteLine("decimal'li metot çalıştı");
        }
        static void Test(float a, float b)
        {
            Console.WriteLine("float'li metot çalıştı");
        }
        static void Main(string[] args)
        {
            Test(3.4d, 4.77d);
            Test(3, 4d);
        }
    }
}

/*ram'de daha az yer tuttuğu için float olarak dönecek*/
using System;

namespace Application
{
    class Ornek
    {
        static void Test(double a,double b)
        {
            Console.WriteLine("double'li metot çalıştı");
        }
        static void Test(float a, float b)
        {
            Console.WriteLine("float'li metot çalıştı");
        }
        static void Main(string[] args)
        {
            Test(3, 4);
        }
    }
}

/*bilinçsiz tip dönüşümü.*/
using System;

namespace Application
{
    class Ornek
    {
        static string topla(string s1, string s2)
        {
            Console.WriteLine("1.metot");
            return s1 + s2;
        }
        static int topla(short a, short b)
        {
            Console.WriteLine("2.metot");
            return a + b;
        }
        static int topla(int a, int b)
        {
            Console.WriteLine("3.metot");
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(topla("Prog.", "tekn."));
            Console.WriteLine(topla(3, 'c'));
            byte a = 3;
            short b = 333;
            Console.WriteLine(topla(a, b));
        }
    }
}