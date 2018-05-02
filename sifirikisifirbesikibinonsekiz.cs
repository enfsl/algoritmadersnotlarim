// sınıftan nesne türetmenin farklı bir şekli.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace derstekikodlaricalistirma
{
    class ogrenci
    {
       public string ad;
       public string soyad;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci o = new ogrenci(); // nesne türettik
            o.ad = "emre";
            o.soyad = "nefesli";
            // şu şekilde de türetip kullanabiliriz 

            ogrenci o1 = new ogrenci()
            {
                ad = "veli",
                soyad = "kara"
            };
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
    class Kure
    {
        public double r; //yarıçap
        public double pi = 3d; // belirtmediğimiz zaman 3 alacak
        public double Alan()
        {
            return 4 * pi * Math.Pow(r, 2); // 4.p.r.2 formül
        }
        public double Hacim()
        {
            return 4 * pi * Math.Pow(r, 3) / 3;  // 4.pi.r.3 /3
        }
        public void yaz()
        {
            Console.WriteLine("******* Küre Bilgileri *******");
            Console.WriteLine("Yarıçap : {0}",r);
            Console.WriteLine("Pi : {0}", pi);
            Console.WriteLine("Yarıçap : {0}", Alan()); // metot bunlar o yüzden() açıp kapadık.
            Console.WriteLine("Hacim : {0}", Hacim());
            Console.WriteLine("************************");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kure k1 = new Kure();
            k1.yaz();
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
    class Kure
    {
        public double r; //yarıçap
        public double pi = 3d;
        public double Alan()
        {
            return 4 * pi * Math.Pow(r, 2); // 4.p.r.2 formül
        }
        public double Hacim()
        {
            return 4 * pi * Math.Pow(r, 3) / 3;  // 4.pi.r.3 /3
        }
        public void yaz()
        {
            Console.WriteLine("******* Küre Bilgileri *******");
            Console.WriteLine("Yarıçap : {0}",r);
            Console.WriteLine("Pi : {0}", pi);
            Console.WriteLine("Yarıçap : {0}", Alan()); // metot bunlar o yüzden() açıp kapadık.
            Console.WriteLine("Hacim : {0}", Hacim());
            Console.WriteLine("************************");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kure k1 = new Kure();
            k1.yaz();
            Kure k2 = new Kure();
            k2.r = 2;
            k2.pi = 3.14d;
            Console.WriteLine(k2.Alan());
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
    class Cember
    {
        public double r;
        public double pi = 3d;
        public void rBelirle(double yc)
        {
            // kullanıcı - girdiği zaman sonucumuz eksi çıkmasın diye
            if (yc <= 0) yc = Math.Abs(yc);
            r = yc;
        }
        public double Cevre()
        {
            return 2 * pi * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.rBelirle(-3); // artık -3 bile girse kullanıcı onu mutlak değer olarak + ya çevirecek
            Console.WriteLine(c1.Cevre());
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
    class Cember
    {
        private double r;
        public double pi = 3d;
        public void rBelirle(double yc)
        {
            // kullanıcı - girdiği zaman sonucumuz eksi çıkmasın diye
            if (yc <= 0) yc = Math.Abs(yc);
            r = yc;
            //veya
            /*
             * yc = Math.Abs(yc);
             * r=yc; şeklinde kullansak daha iyi olur ( daha hızlı çalışır)
             */
        }
        public double Cevre()
        {
            return 2 * pi * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.rBelirle(-2); // artık -3 bile girse kullanıcı onu mutlak değer olarak + ya çevirecek
            Console.WriteLine(c1.Cevre());
        }
    }
}

/*Litaratürde bu işleme kapsülleme denir. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace derstekikodlaricalistirma
{
    class Cember
    {
        private double r;
        private double pi = 3d;
        public void rBelirle(double yc)
        {
            // kullanıcı - girdiği zaman sonucumuz eksi çıkmasın diye
            if (yc <= 0) yc = Math.Abs(yc);
            r = yc;
            //veya
            /*
             * yc = Math.Abs(yc);
             * r=yc; şeklinde kullansak daha iyi olur ( daha hızlı çalışır)
             */
        }
        public void piBelirle(double p)
        {
            if (pi < 3 || pi >= 3.15) pi = 3d;
        }
        public double Cevre()
        {
            return 2 * pi * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.rBelirle(-2); // artık -3 bile girse kullanıcı onu mutlak değer olarak + ya çevirecek
            c1.piBelirle(2.14);
            Console.WriteLine(c1.Cevre());
        }
    }
}