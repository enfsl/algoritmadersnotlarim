//Enum !

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
/*Enum sabitleri classın üzerinde tanımlanır*/
// byte yazdığımız zaman byte aralığı kadar değer tanımlayabiliyoruz byte=256 int = 4milyon
// enum durum { geçti, kaldi}; şeklinde byte int bir değer vermeden tanımlayabiliriz
// dizi gibi terimleri 0 dan başlar mesela burda 0 pazartesiyi 1 saliyi temsil eder.
    enum gunler : byte { pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar};
    enum durum  { gecti,kaldi};
    enum notlar : byte { kaldi,basarisiz,gecer,orta,iyi,pekiyi}

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayi gir (0-4) : ");
            byte not = Convert.ToByte(Console.ReadLine());
            // notlar drm = not yapmıyoruz ! cast etmemiz gerekiyor.
            notlar drm = (notlar)not;
            Console.WriteLine(drm);
        }
    }
}

/* diziyi kullanıcının isteğine göre alt alta veya yan yana yazan program*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    /* enum sabitimizi tanımlıyoruz, yaz metotu tanımlayıp(void'Li geriye değer
     * döndürmeyeceğiz) bool ve array 
     * değişkenlerimizi parametre giriyoruz, eğer bool değişkenimiz true ise
     * diziyi yan yana boşluk bırakarak yazdırıcak, false ise alt alta yazdırıcak*/
    enum bicim : byte { yanyana,altalta};
    class Program
    {
        static void yaz(bool b, Array a)
        {
            if (b == true)
                foreach(object o in a)
                    Console.Write(o+"\t");
            else 
                foreach(object o in a)
                    Console.WriteLine(o);
        }
        static void Main(string[] args)
        {
            // string dizimizi tanımlayıp, dizinin içine elemanları girdikten sonra
            // yaz metotumuz ile bool değişkenimize değer yollayıp, hangi dizi üzerinde
            // işlem yapacaksak onu yazıyoruz.
            string[] isimler = { "ali", "ayşe", "beyza" };
            yaz(true, isimler);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    enum renkler : byte { siyah=0, kahve=5, koyukahve, krem=14,beyaz,sari=8 };
    class Program
    { 
        static void Main(string[] args)
        {
            // renkler enumundan renk diye nesne türetip içerisine 6 sayısı attık
            // kahve=5'e eşit olduğu için ondan sonra gelecek olan değişken bir arttı
            // ve 6 oldu.
            renkler renk = (renkler)6; 
            Console.WriteLine(renk);
            Console.WriteLine(renkler.sari);
            // tersten cast ederek sari renginin sayi karşılığını görüyoruz.
            byte b = (byte)renkler.sari;
            Console.WriteLine(b);
        }
    }
}


//********************SINIFLAR***********************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalecalismaa
{
    class insan
    {
        public string ad;
        public string soyad;
        public int dogumyili;
        public int yas() // özelliklerde () kullanmıyoruz sadece metotlarda kullanıyoruz.
        {
            return 2018-dogumyili;
        }
        public string sehir;
        public string medenihal;
        public string din;
        public string kangrubu;
        public void yaz()
        {
            Console.WriteLine("ad soyad : {0} {1}",ad,soyad);
            Console.WriteLine("doğum yılı : {0}",dogumyili);
            Console.WriteLine("yaş : "+yas()); // metotları bu şekilde yazdırabiliyorum +metot()
            Console.WriteLine("yaşadığı şehir :{0}",sehir);
            Console.WriteLine("medeni hal : {0}",medenihal);
            Console.WriteLine("kan grubu : {0}",kangrubu);
            Console.WriteLine("din : {0}",din);
            Console.WriteLine("----------------------------------------------------------------");
        }
          
    }
    class Program
    {
        static void Main(string[] args)
        {
            insan kisi1 = new insan();
            kisi1.ad = "emre";
            kisi1.soyad = "nefesli";
            kisi1.dogumyili = 1999;
            kisi1.medenihal = "bekar";
            kisi1.din = "müslüman";
            kisi1.sehir = "yozgat";
            kisi1.kangrubu = "a rh +";
            kisi1.yaz();
            insan kisi2 = kisi1;
            kisi2.ad = "orhan";
            kisi2.dogumyili = 1959;
            kisi2.medenihal = "evli";
            kisi2.kangrubu = "bilinmiyor";
            kisi2.yaz();
            insan kisi3 = kisi2;
            kisi3.ad = "esin";
            kisi3.dogumyili = 1964;
            kisi3.yaz();
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
    class Kure // 
    {
         public double r;
         public double pi = 3d;
         private double Alan()
        {
            return 4 * pi * Math.Pow(r, 2); // kure alan formulu 4*pi*r kare
        }
         private double Hacim()
        {
            return 4 * pi * Math.Pow(r, 3); // kure hacim 4*pi*r küp
        }
         public void yaz()
        {
            Console.WriteLine("küre bilgileri");
            Console.WriteLine("yarıçap : {0}",r);
            Console.WriteLine("pi : {0}",pi);
            Console.WriteLine("alan : {0}",Alan()); // metot olduğu için aç kapa
            Console.WriteLine("hacim : {0}",Hacim());
            Console.WriteLine("---------------------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kure kure1 = new Kure();
            kure1.pi = 3.14d;
            kure1.r = 2;
            kure1.yaz();
            Kure kure2 = new Kure();
            kure2 = kure1;
            kure2.r = 2.5;
            kure2.yaz();
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
            // kullanıcı - girince sonuçta - çıkmasın diye
            yc = Math.Abs(yc);
            r = yc;
            // yarıçapın mutlak değerini alıp r'ye atıyorum.
        }
        public void pBelirle(double p)
        {
            if (pi < 3d || pi >= 3.15d) pi = 3d;
        }
        public double Cevre()
        {
            return 2 * pi * Math.Pow(r, 2); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.rBelirle(-3);
            c1.pBelirle(2);
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
        public double r;
        public double pi = 3d;
        public void rBelirle(double r)
        {
            // kullanıcı - girince sonuçta - çıkmasın diye
            r = Math.Abs(r);
            this.r = r;
            // yarıçapın mutlak değerini alıp r'ye atıyorum.
            // this ben beni çağıran nesneye aitim anlamında kullanılıyor
            // sınıfın içindeki özellikle metotun bir parametresi aynı isimle tanımlanırsa
            // bunları birbirinden ayırt etmek için kullanılır.
            // this.r özellik olan r'i kast ediyor.
        }
        public void pBelirle(double p)
        {
            if (pi < 3d || pi >= 3.15d) pi = 3d;
        }
        public double Cevre()
        {
            return 2 * pi * Math.Pow(r, 2); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cember c1 = new Cember();
            c1.rBelirle(-3);
            c1.pBelirle(2);
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
    class deneme
    {
        public int a
        {
            set
            {
                Console.WriteLine("değer yazıldı");
            }
            get
            {
                Console.WriteLine("değer okundu");
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            deneme d1 = new derstekikodlaricalistirma.deneme();
            d1.a = 5; // birşey attığım zaman özelliğe set etmiş oldum
            Console.WriteLine(d1.a);  // birşey okumak istediğim zaman özellikten get etmiş oldum
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
    class cember
    {
        public double pi = 3d;
        private double yc;
        public double r
        {
            set
            {
                yc = value; // değeri yc'ye at dedim
            }
            get
            {
                return yc; // yc'yi döndür dedim
            }
        }
        public double Cevre()
        {
            return 2 * pi * yc;
        }
        public void yaz()
        {
            Console.WriteLine("Çevre = "+Cevre());
            Console.WriteLine("yarıçap = "+yc);
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            cember c1 = new cember();
            c1.r = 3;
            c1.yaz();
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
    class Diziislem
    {
        private int s1;
        public int adet
        {
            get
            {
                return s1;
            }
        }
        public int Toplam(params int[]dizi)
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
            Diziislem d1 = new Diziislem();
            Console.WriteLine("toplam ="+d1.Toplam(1,2,3,4,5));
            Console.WriteLine("terim sayısı = "+d1.adet);
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
    class ogrenci
    {
        public ogrenci() // yapıcı metotlarda int string gibi tip belirtilmez
        {    // nesne türettiğim anda yapılması gereken işleri yapar değer üretmez voidle belirtilmez
            // yapıcı metotlar sınıfın adıyla aynı olmak zorunda.
            ono = 5;
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
            Console.WriteLine(o1.oad);
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
            set
            {
                if (value < 3d || value >= 3.15d)
                {
                    gpi = 3d;
                }
                else gpi = Math.Abs(value);
            }
            get
            {
                return gpi;
            }
        }
        private double yc;
        public double r
        {
            set
            {
                yc = Math.Abs(value);
            }
            get
            {
                return yc;
            }
        }
        public double cember()
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
            c1.pi = 3.14d;
            Console.WriteLine(c1.cember());
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
                yc = Math.Abs(value);
            }
        }
        public Cember()
        {
            gpi = 3.14d;
        }
        public Cember(double pi,double r)
        {
            this.pi = pi;
            this.r = r;
        }
        public double Cevre()
        {
            return 2 * pi * r;
        }
        public static double operator +(Cember c3,Cember c4)
        {
            return c3.Cevre() + c4.Cevre();
        }
        public static double operator -(Cember c3, Cember c4)
        {
            return c3.Cevre() - c4.Cevre();
        }
        public static bool operator >(Cember c3,Cember c4)
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
        {
            return "çemberin çevresi= " + Cevre();
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
            if (c1 > c2) Console.WriteLine("1.Çevre büyük");
            else Console.WriteLine("1.Çevre büyük değil");
        }
    }
}