/*kullanıcı tarafından girilen bir sayıya kadar olan sayıların 
toplamını bulan metotu yazınız*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        int GausRec(int a)
        {
            if (a == 1) return 1;
            else return a + GausRec(a-1);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.GausRec(5));
        }
    }
}

/*kullanıcı tarafından girilen bir sayıya kadar olan 
tek sayıların toplamını bulan metotu yazınız*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        int GausRec(int a)
        {
            if (a == 1) return 1;
            else return a + GausRec(a-2);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.GausRec(2));
        }
    }
}


/*kullanıcı tarafından girilen bir sayıya kadar olan
 tek veya çift sayıların toplamını bulan metotu yazınız*/
 using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        int GausRec(int a)
        {
            if (a == 1) return 1;
            else if (a == 0) return 0;
            else return a + GausRec(a - 2);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.GausRec(10));
        }
    }
}

/*Recursive metotla obeb bulma*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        int ObebKlas(int a,int b)
        {
            if (b == 0) return a;
            else return ObebKlas(b, a % b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.ObebKlas(25, 15));
        }
    }
}

/*Recursive metotla kullanıcı tarafından girilen bir sayının, 
yine kullanıcı tarafından girilen kuvvetini alan metotu yazınız*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        int Kuvvet(int tabankuvvet, int kuvvet)
        {
            if (kuvvet == 0) return 1;
            else return tabankuvvet * Kuvvet(tabankuvvet, kuvvet - 1);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Kuvvet(3, 4));

        }
    }
}

/*daireyi bölen n adet doğrunun oluşturacağı 
en çok daire parçacığı(alan) sayısını bulan metotu yazınız*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        int ParBul(int a)
        {
            if (a == 0) return 1;
            else return a + ParBul(a - 1);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.ParBul(5));
        }
    }
}

/*Opsiyonel Parametreli metot*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static int topla(int a, int b=4) 
//  metot parametresi ayarlarken değişkene ilk değeri yüklüyoruz
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(topla(3, 10));
            Console.WriteLine(topla(3));
        }
    }
}

/*Opsiyonel Parametreli metot 2*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static int topla(int b, int c=15)
        {
            return b+c;
        }
        static string tpl (string s="ders",int a=7,int b=9)
        {
            return s+" " + a + " " + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(topla(3, 10));
            Console.WriteLine(topla(9));
            Console.WriteLine(tpl());
        }
    }
}

/*Opsiyonel Parametreli metot
 */
 using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static int topla(int a = 5, int b=10)
        {
            return a + b;
        }
        static int topla1(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(topla(b:8)); // Named : 8'in hangisine gitmesini istiyorsan onun başına (değişken:) şeklinde yazıyoruz
            Console.WriteLine(topla(b: 5, a: 3));
        }
    }
}