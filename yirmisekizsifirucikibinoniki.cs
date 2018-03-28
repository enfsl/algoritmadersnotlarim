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

/* iki tane array list gönderiyoruz kesişimi bulup bir array liste döndüren metotu yazınız.*/
// Farklı sayıları tutsun aynı sayıları tutmasın diye böyle yaptık..

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
            int syc = 0;
            while(syc<16)
            {
                int t = r.Next(20);
                if (al1.Contains(t) == false)
                {
                    al1.Add(t);
                    syc++;
                }
            }
            syc = 0;
            while (syc < 16)
            {
                int t = r.Next(20);
                if (al2.Contains(t) == false)
                {
                    al2.Add(t);
                    syc++;
                }
            }
            yaz(al1); 
            yaz(al2);
            ArrayList alk = kesisim(al1, al2);
            yaz(alk);

        }
    }
}

/*HASHTABLE */

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
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("2017212036", "emre"); // anahtar değer 2017212036
            ht.Add("2017212037", "emre");
            ht.Add("corolla", "toyota");
            ht.Add("yaris", "toyota");
            ht.Add("i30", "hyundai");
            ht["i20"] = "hyundai"; // diye de yazabilirim tıpkı Add gibi ekleme yapar.
            ht["2017212036"] = "aliveli"; //yoksa ekler varsa var olanın değerini değiştirir.
            Console.WriteLine(ht.Count);
            Console.WriteLine(ht.ContainsKey("i30")); // countainkey keylerde arama yapar
            Console.WriteLine(ht.ContainsValue("emre")); // değer kısmında arama yapar.

        }
    }
}

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
        static void yaz(Hashtable ht)
        {
            // hashtablenin keylerini görmek için ICollectionla nesne türetip yapıyoruz.
            ICollection ick = ht.Keys;
            foreach(object o in ick)
                Console.WriteLine(o);
        }
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("2017212036", "emre"); // anahtar değer 2017212036
            ht.Add("2017212037", "emre");
            ht.Add("corolla", "toyota");
            ht.Add("yaris", "toyota");
            ht.Add("i30", "hyundai");
            ht["i20"] = "hyundai"; // diye de yazabilirim tıpkı Add gibi ekleme yapar.
            ht["2017212036"] = "aliveli"; //yoksa ekler varsa var olanın değerini değiştirir.
            yaz(ht);


        }
    }
}

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
        static void yazkey(Hashtable ht)
        {
            // hashtablenin keylerini görmek için ICollectionla nesne türetip yapıyoruz.
            ICollection ick = ht.Keys;
            foreach(object o in ick)
                Console.WriteLine(o);
        }
        static void yazvalue(Hashtable ht)
        {
            // hashtablenin valuelerini görmek için ICollectionla nesne türetip yapıyoruz.
            ICollection icv = ht.Values;
            foreach(object o in icv)
                Console.WriteLine(o);
        }
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("2017212036", "emre"); // anahtar değer 2017212036
            ht.Add("2017212037", "emre");
            ht.Add("corolla", "toyota");
            ht.Add("yaris", "toyota");
            ht.Add("i30", "hyundai");
            ht["i20"] = "hyundai"; // diye de yazabilirim tıpkı Add gibi ekleme yapar.
            ht["2017212036"] = "aliveli"; //yoksa ekler varsa var olanın değerini değiştirir.
            yazkey(ht);
            yazvalue(ht);
        }
    }
}