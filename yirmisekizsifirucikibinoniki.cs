/* iki tane array list gönderiyoruz kesişimi bulup bir array liste döndüren metotu yazınız.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static void yaz(ArrayList al)
        {
            foreach(object o in al)
                Console.Write(o+" ");
            Console.WriteLine();
        }
        static ArrayList kesisim(ArrayList al1, ArrayList al2)
        {
            ArrayList ald = new ArrayList();
            foreach (object o in al1)
                if (al2.Contains(o) == true) ald.Add(o);
            return ald;
        }
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();
            ArrayList al2 = new ArrayList();
            Random r = new Random();
            for (int i = 1; i < 16; i++)// tek for ile 2 tane random tutturmak pek doğru değildir işlemci çalışma mantığı ile aynı sayıları tutma olasılığı vardır.
            {
                al1.Add(r.Next(20));
            }
            for (int i = 1; i < 16; i++)
            {
                al2.Add(r.Next(20));
            }
            yaz(al1); 
            yaz(al2);
            ArrayList alk = kesisim(al1, al2);
            yaz(alk);

        }
    }
}