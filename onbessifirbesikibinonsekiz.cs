using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace derstekikodlaricalistirma
{
    class Cember
    {
        private double gpi;
        public double pi
        {
            get
            {
                return gpi;
            }
            set
            {
                gpi = Math.Abs(value);
            }
        }

        private double yc;
        public double r
        {
            get
            {
                return yc;
            }
            set
            {
                yc = Math.Abs(value); // yc negatif olmayacak
            }
        }
        public Cember()
        {
            gpi = 3.14d;
        }
        public Cember(double pi, double r)
        {
            this.pi = pi; //pi'yi özellik olan pi'nin içine at
            this.r = r;
        }
        public double Cevre()
        {
            return 2 * gpi * yc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.r = 2;
            Console.WriteLine(c1.Cevre());
            Cember c2 = new Cember(3, 4);
            Console.WriteLine(c2.Cevre());
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
        private double gpi;
        public double pi
        {
            get
            {
                return gpi;
            }
            set
            {
                gpi = Math.Abs(value);
            }
        }

        private double yc;
        public double r
        {
            get
            {
                return yc;
            }
            set
            {
                yc = Math.Abs(value); // yc negatif olmayacak
            }
        }
        public Cember()
        {
            gpi = 3.14d;
        }
        public Cember(double pi, double r)
        {
            this.pi = pi; //pi'yi özellik olan pi'nin içine at
            this.r = r;
        }
        public double Cevre()
        {
            return 2 * gpi * yc;
        }
        public static double operator +(Cember c3, Cember c4) // + operatorüne yeni bir özellik ekledik
        {
            return c3.Cevre() + c4.Cevre(); // artık 2 nesneyi toplatabiliyoruz.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.r = 2;
            Console.WriteLine(c1.Cevre());
            Cember c2 = new Cember(3, 4);
            Console.WriteLine(c2.Cevre());
            double d = c1 + c2;
            Console.WriteLine(d);
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
        private double gpi;
        public double pi
        {
            get
            {
                return gpi;
            }
            set
            {
                gpi = Math.Abs(value);
            }
        }

        private double yc;
        public double r
        {
            get
            {
                return yc;
            }
            set
            {
                yc = Math.Abs(value); // yc negatif olmayacak
            }
        }
        public Cember()
        {
            gpi = 3.14d;
        }
        public Cember(double pi, double r)
        {
            this.pi = pi; //pi'yi özellik olan pi'nin içine at
            this.r = r;
        }
        public double Cevre()
        {
            return 2 * gpi * yc;
        }
        public static double operator +(Cember c3, Cember c4) // + operatorüne yeni bir özellik ekledik
        {
            return c3.Cevre() + c4.Cevre(); // artık 2 nesneyi toplatabiliyoruz.
        }
        public static double operator -(Cember c3, Cember c4) // + operatorüne yeni bir özellik ekledik
        {
            return c3.Cevre() - c4.Cevre(); // artık 2 nesneyi toplatabiliyoruz.
        }
        public static bool operator >(Cember c3,Cember c4) 
        //bool olduğu için tersi overloadlı halinide yazmamız gerekiyor.
        {
            if (c3.Cevre() > c4.Cevre()) return true;
            else return false;
        }
        public static bool operator <(Cember c3, Cember c4)
        {
            if (c3.Cevre() < c4.Cevre()) return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.r = 2;
            Console.WriteLine(c1.Cevre());
            Cember c2 = new Cember(3, 4);
            Console.WriteLine(c2.Cevre());
            double d = c1 + c2;
            Console.WriteLine(d);
            if (c1>c2) Console.WriteLine("1.Çevre büyük");
            else Console.WriteLine("1.Çevre büyük değil");
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
        private double gpi;
        public double pi
        {
            get
            {
                return gpi;
            }
            set
            {
                gpi = Math.Abs(value);
            }
        }

        private double yc;
        public double r
        {
            get
            {
                return yc;
            }
            set
            {
                yc = Math.Abs(value); // yc negatif olmayacak
            }
        }
        public Cember()
        {
            gpi = 3.14d;
        }
        public Cember(double pi, double r)
        {
            this.pi = pi; //pi'yi özellik olan pi'nin içine at
            this.r = r;
        }
        public double Cevre()
        {
            return 2 * gpi * yc;
        }
        public static double operator +(Cember c3, Cember c4) // + operatorüne yeni bir özellik ekledik
        {
            return c3.Cevre() + c4.Cevre(); // artık 2 nesneyi toplatabiliyoruz.
        }
        public static double operator -(Cember c3, Cember c4) // + operatorüne yeni bir özellik ekledik
        {
            return c3.Cevre() - c4.Cevre(); // artık 2 nesneyi toplatabiliyoruz.
        }
        public static bool operator >(Cember c3,Cember c4) 
        //bool olduğu için tersi overloadlı halinide yazmamız gerekiyor.
        {
            if (c3.Cevre() > c4.Cevre()) return true;
            else return false;
        }
        public static bool operator <(Cember c3, Cember c4)
        {
            if (c3.Cevre() < c4.Cevre()) return true;
            else return false;
        }
        public override string ToString()
        //c#'ın var olan bir metotunu değiştirirsek bunu c#'a override ile bildiriyoruz.
        {
            return "Çemberin Çevresi = " + Cevre();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.r = 2;
            Console.WriteLine(c1);
            Cember c2 = new Cember(3, 4);
            Console.WriteLine(c2);
            double d = c1 + c2;
            Console.WriteLine(d);
            if (c1>c2) Console.WriteLine("1.Çevre büyük");
            else Console.WriteLine("1.Çevre büyük değil");
        }
    }
}


// Kalıtım Miras konularına da bak bu dönem işleyemedik.