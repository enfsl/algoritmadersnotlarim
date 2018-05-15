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