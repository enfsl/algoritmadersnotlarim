/*Params kullanım örneği*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static void ornek(params int[] d)
        {
            Console.WriteLine(d[2]);
        }
        static void Main(string[] args)
        {
            ornek(5, 8, 9);
            ornek(5, 3);
        }
    }
}

/*parametre olarak aldığı n adet sayıyı toplayarak sonucu döndüren
metotu yazıp kullanımını gösterin. */
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static int toplam(params int[] d)
        {
            int t = 0;
            foreach (int i in d)
                t += i;
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(toplam(5, 8, 9));
            Console.WriteLine(toplam(5, 3, 33, 44));
        }
    }
}

/* parametre olarak aldığı n adet sayının ilki tekse toplayan, çiftse çarparak
sonucu bulan metotu yazınız. */
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static int toplam(params int[] d)
        {
            int t = 0;
            if(d[0]%2 ==1)
            foreach (int i in d)
                t += i;
            else
            {
                t = 1;
                foreach (int i in d)
                    t *= i;
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(toplam(5, 8, 9));
            Console.WriteLine(toplam(5, 3, 33, 44));
        }
    }
}

/* params kullanırken params en sonda olmalıdır */
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static void ornek(int a,params int[] d)
        {

        }
        static void Main(string[] args)
        {
            ornek(3, 4, 5, 8);
        }
    }
}

/* OVERLOADLI PARAMS ÖRNEĞİ (tamamen uyumlu olan kod daha önce çalıştırılıyor
ornek(3,4) int a , int b için daha uyumlu) (eğer ornek() bir sayı daha fazla
girilseydi "ornek(3,4,5)" gibi paramslı çalışacaktı.*/
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static void ornek(params int[] d)
        {
            Console.Write("paramslı");
        }
        static void ornek(int a, int b)
        {
            Console.Write("intli");
        }
        static void Main(string[] args)
        {
            ornek(3, 4);
        }
    }
}

/*Recursive metot ile faktöriyel bulma */
using System;

namespace derstekikodlaricalistirma
{
    class Program
    {
        static int fkt(int a)
        {
            if (a == 1) return 1; // düğüm noktası
            else return a * fkt(a - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(fkt(5));
        }
    }
}