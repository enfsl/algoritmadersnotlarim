/*  SINIFLAR   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace derstekikodlaricalistirma
{
    class ornek
    {
        int b; //sınıfın içinde değişken tanımlarsam bu bir özelliktir.
        static void yaz()
        {
            Console.WriteLine("toplam : ");
        }
        public static int topla(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ornek.yaz diye çağıramazsın, çağırmak için erişimin olması gerek.
            // Public / Piravete 
            Console.WriteLine(ornek.topla(4,5)); // toplayı public belirttiğim için direk kullandım.

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace derstekikodlaricalistirma
{
    class  insan
    {
        public string ad; // public yazarak başka yerde kullanmaya erişim verdim.
        public string soyad;
        public int kilo;
        public int dogumyili;
        public int yas()
        {
            return 2018 - dogumyili;
        }
        public void Yaz()
        {
            Console.WriteLine("Ad soyad : {0} {1}",ad,soyad);
            Console.WriteLine("Kilo : " + kilo);
            Console.WriteLine("Yaşınız : "+yas());
            Console.WriteLine("-------------");
        }
           
    }
    class Program
    {
        static void Main(string[] args)
        {
            insan kisi1 = new insan(); // static olmadığı için nesne türettim.
            kisi1.ad = "emre";
            kisi1.soyad = "nefesli";
            kisi1.kilo = 70;
            kisi1.dogumyili = 1999;
            int yas = kisi1.yas();
            kisi1.Yaz();
        }
    }
}