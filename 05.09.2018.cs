using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace derstekikodlaricalistirma
{
    // Yapıcı metotlar ( constructor metotlar ) sınıftan nesne türettiğin anda
    // yapılmasını istediğin işleri yaptırmak için kullanılan metottur.
    // geriye değer üretmez ve voidle belirtilmez
    // yapıcı metotlar sınıfın adıyla aynıdır.
    class ogrenci
    {
        public ogrenci()
        {
            ono = 5; // nesne türetildiği anda öğrenci numarasına 5 değeri ata
            Console.WriteLine("yapıcı çalıştı");
        }
        public string oad;
        public int ono;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci o1 = new ogrenci();
            Console.WriteLine(o1.ono);
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
    class mat
    {
        public mat (int a,int b)
        {
            Console.WriteLine(a+b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mat m = new mat(3, 5);
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
    class mat
    {
        public mat (int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public mat()
        {
            Console.WriteLine("parametresiz yapıcı");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mat m1 = new mat();
            mat m = new mat(3, 5);
            mat m2 = new mat();

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
    // bu olay sadece yapıcı metotlarda geçerli !!
    class mat
    {
        public mat(int a,int b,int c)
        {
            Console.WriteLine(a+b+c);
        }
        public mat (int d,int e):this(d,e,0) // sınıfa ait 3 yapıcılı metota gönder
        {

        }
        public mat(int f):this(f,0)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mat m1 = new mat(5);
            mat m2 = new mat(5, 7);
            mat m3 = new mat(3, 5, 7);
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
    class ornek
    {
        ornek()
        {
            Console.WriteLine("yapıcı");
        }
        public ornek(int a)
        {
            Console.WriteLine("parametreli yapıcı");
            new ornek();
        }
        /* Başka metotlar olabilir
           ve ornek() burda çağrılabilirdi*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            ornek o = new ornek(5);
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
    class test
    {
        public test()
        {
            Console.WriteLine("yapıcı"); // normaller her nesne türettiğinde çalışıyor
        }
        static test() // static metotlar public olmak zorundadır bu yüzden erişim belirteci belirtilmez
        {
            Console.WriteLine("static yapıcı"); // bir kez çalışır nesneyi türettiğin anda
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test t1 = new test();
            test t2 = new test();
            test t3 = new test();
            test t4 = new test();
            test t5 = new test();

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
    class test
    {
        public static int a = 5;
        public test()
        {
            Console.WriteLine("s olmayan yapıcı");
        }
        static test()
        {
            Console.WriteLine("statik yapıcı");
        }
        public static void yaz()
        {
            Console.WriteLine("huhu");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test.yaz();
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
    // yıkıcı örnek
    // yıkıcı metotun erişim belirteci kullanılmaz
    // void felan belirtilmez
    // yıkıcı metotun adı sınıfın adıyla aynıdır
    // parametre almaz
    // tilda işareti koyulur ~
    class sinif_ornek
    {
        public sinif_ornek()
        {
            Console.WriteLine("yapıcı");
        }
        ~sinif_ornek()
        {
            Console.WriteLine("yıkıcı çalıştı");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            if(1==1)
            {
                sinif_ornek s1 = new sinif_ornek();
            }
            int a = Convert.ToInt32(Console.ReadLine());
        }
    }
}