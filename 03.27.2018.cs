/*Kolleksiyonlar konusunu bu gün işliyoruz.. */

/*kolleksiyon sınıfını kullanmak için ; using System.Collection eklenmeli */

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
            Console.WriteLine("Terim Sayısı : "+al.Count);
            // Dizilerdeki lenght'e benzer. Count terim sayısını verir (Count bir metot değildir parantez açılmaz !)
            Console.WriteLine("Kapasitesi : "+al.Capacity); // kapasitesini görme (kaç kb yer tutuyor ramda)
            Console.WriteLine("-------------------------------");
        }
        static void Main(string[] args)
        {
            ArrayList al; // (Ayrılan alan dinamiktir)
            al = new ArrayList(); // diye tanımlayabiliriz
           // ArrayList al1 = new ArrayList(); // yada böyle tanımlayabiliriz.
            al.Add(5); // Add her eklediğini arkasına ekleyerek gider
            al.Add(5.3d);
            al.Add("Prog");
            al.Add('Y');
            al.Add(true);
            al.Insert(2, "ders"); // Insert araya ekleme yapar ( dizilerdeki gibi 0dan başlar !!)
            yaz(al);
            al.Remove("ders"); //ArrayListin içerisinden bir değer silmek için kullanılır.
            yaz(al);
            al.RemoveAt(1); //Remove ismini belirttiğin nesneyi silerken RemoveAt indisini belirttiğini siler.
            yaz(al);
            al.TrimToSize(); // TrimToSize sildiğimiz kısımları(yerlerinde null değer kalır silince) kırpar yok eder.
            yaz(al);
            al.Reverse(); // diziyi ters çevirir
            yaz(al);
            //al.Clear(); // ArrayListin tamamını siler
            yaz(al);
            al.Clone(); // Bir datasetin, yığının , kolleksiyonun kopyasını çıkartır(kendi tipinden) çıkartılmış kopyayı başka bir yere atabiliriz.
            // al.Contains(5); // ArrayList şu değeri içeriyormu diye arar true yada false değer döndürür.
            Console.WriteLine(al.Contains(5));
            //al.IndexOf("y");// içerisinde geçiyoru diye arar sırasını gösterir.
            Console.WriteLine();
            /*
            al.Add(5);
            al.Add(15);
            Console.WriteLine(al[0]);
            Array list tıpkı dizi gibi çalışabilir içindeki indis karakterden değer yazdırabiliriz.
             */
        }
    }
}

/*bir metota parametre olarak bir array list gönderiyoruz içindeki çift değerleri döndürsün ve başka bir array liste atsın(array list ile)*/

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
        static ArrayList dondur(ArrayList al)
        {
            ArrayList ald = new ArrayList();
            foreach(object o in al)
            {
                if (Convert.ToInt32(o) % 2 == 0) ald.Add(o);
            }
            return ald;
        }
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();
            Random r = new Random();
            for (int i = 1; i < 11; i++)
                al1.Add(r.Next(20));
            yaz(al1);
            ArrayList al2 = dondur(al1);
            yaz(al2);
            
            /*önemli bunlar (örnekten ayrı)*/
            ICollection ic = (ICollection)al2.Clone(); // farklı tipte olsaydı al2'yi ICollection'a cast ederdik
            al1.AddRange(al2); // Addrange ICollection (interface) ister ArrayListten ArrayListe işlem yaparken gerek olmaz ama başka tipten olur.
            yaz(al1);
            Console.WriteLine("---------------");
            ICollection ic1 = (ICollection)al2;
            al1.InsertRange(2, ic1);
            yaz(al1);

            ArrayList al3 = new ArrayList(al2);
            ArrayList al4 = new ArrayList((ICollection)al2);
            yaz(al3);

        }
    }
}


