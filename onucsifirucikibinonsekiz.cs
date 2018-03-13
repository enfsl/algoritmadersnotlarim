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