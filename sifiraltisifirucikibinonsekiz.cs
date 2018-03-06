/*İndis bulma */

using System;

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
                    gdds[s]=d[i];
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