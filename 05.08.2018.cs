using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace derstekikodlaricalistirma
{
    class Deneme
    { 
        public int a
        {
            set // yazma
            {
                Console.WriteLine("değer yazıldı");
            }
            get // okuma 
            {
                Console.WriteLine("değer okundu");
                return 0;
            }
        }
    class Program
    {
        }
        static void Main(string[] args)
        {
            Deneme d1 = new Deneme();
            d1.a = 5; //set
            Console.WriteLine(d1.a); // get
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
        public double pi = 3d;
        private double yc;
        public double r
        {

            set
            {
                yc = value;
            }
            get
            {
                return yc;
            }
        }
        public double Cevre()
        {
            return 2 * pi * yc;
        }
        public void Yaz()
        {
            Console.WriteLine("Çevre = " + Cevre());
            Console.WriteLine("Yarıçap = " + yc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.r = 3;
            c1.Yaz();
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
    // Kendisine parametre olarak gelen n adet sayının toplamını bulan metot bir
    // sınıf olarak yazınız ayrıca sınıf içindeki bir özellik içinden parametre
    // olarak gelen sayı adeti öğrenilebilecek şekilde olmalıdır.
    class DiziIslem
    {
        private int s1;
        public int adet
        {
            get
            {
                return s1;
            }
        }
        public int Toplam(params int[] dizi)
        {
            s1 = dizi.Length;
            int tpl = 0;
            foreach (int i in dizi)
                tpl += i;
            return tpl;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DiziIslem d1 = new DiziIslem();
            Console.WriteLine("toplam = "+d1.Toplam(1,2,3,4,5));
            Console.WriteLine("terim sayısı = "+d1.adet);

        }
    }
}