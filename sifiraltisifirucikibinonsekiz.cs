/*İndis bulma */

using System;

/* İndis bulma da anlamadığım bir yer var
kendim denerken j'yi 10 olarak bıraktım.
 j = 10 , s.lenght'i 12 yaptım
 s[j]'sinin 10'a eşit olmasını sağladım,
 10'uncu karakterin chara eşit olmasını sağladım
 fakat 10'uncu karakteri değil 11'inci karakteri chara eşitlersem
 döndürüyor.*/
namespace Application
{
    class Program
    {
        int indisbul(string s, char c, int i)
        {
         for (int j=i; j<s.Lenght; j++)
            if(s[j]==c) return j;
         return -1;   
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.indisbul("adıyaman", 'a',10));
        }
    }
}

/*dizideki tek sayıları döndürme */

using System;

namespace Application
{
    class Program
    {
        int [] dondur(int[]d)
        {
            int a = 0;
            foreach (int i in d)
                if(i%2==1)a++;
            int[] gdd = new int[a];
            int s=0;
            for(int i=0; i<d.Lenght;i++)
                if(d[i]%2==1)
                {
                    gdd[s]=d[i];
                    s++;
                }
            return gdd;
        }
        static void yaz(int []d)
        {
            foreach(int i in d)
                Console.Write("{0}",i);
        }
        static void Main(string[] args)
        {
            int[] dizi = {1,2,22,52,55,3,5,9,99,100};
            Program p= new Program();
            int[] dd = p.dondur(dizi);
            yaz (dd);
        }
    }
}

/* Değer - Referans tip örneği*/
using System;

namespace Application
{
    class Program
    {
        static void ornek(ref int a)
        {
            a=20;
        }
        static void Main(string[] args)
        {
            int b = 10; // ilk başta ekrana 10 yazar çünkü değer tipte bir değişken
            Console.WriteLine(b)
            ornek(ref b); // şimdi b değişkenini referans yaptığımız için 20 yazacak
            Console.WriteLine(b);
        }
    }
}
