/*Vizeden önce tuttuğum notları(dersteki) kendi anlayacağım şekilde bir daha yazarak 
ve ne yaptığını kendime not düşerek tekrardan,
not halinde tutuyorum. */

// Metotlara giriş

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        //metot sınıfın altına tanımlanır
        // burda Toplam diye 2 parametreli bir metot tanımlıyorum.
        // tip - metotunadı(parametreler) şeklinde metot tanımlanır.
        int Toplam(int a, int b)
        {
            int t = a + b;
            return t;
        }
        static void Main(string[] args)
        {
            Program p = new Program(); // static değilse kullanmak için program sınıfından nesne türetiyorum
            Console.WriteLine(p.Toplam(3, 4)); // olarak direk yazdırabilirim veya ;
            int t = p.Toplam(3, 4); // p.Toplamı bir değişkenin içine atarak yazdırabilirim.
            Console.WriteLine(t);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        // metotu static olarak tanımladım 
        // bu yüzden main bloğunda sınıftan nesne türetmem gerekmeyecek
        // static tanımlayarak Faktoriyeli ram'a attım.
        static int Faktoriyel(int a)
        {
            /* önce f diye bir değişken oluşturup içine 1 değerini atıyorum,
             * daha sonra bir döngü kurup i'ye 1 değerini atıyorum, i a'dan küçük ve eşit olduğu sürece
             * bir arttırmasını söylüyorum ve döngünün içine f(1 başta) i ile çarpmasını ve f değişkeninin
              içine atmasını söylüyorum sonra return ile f'i çağırdığım zaman bana metotu kırıp döndürmesini istiyorum.*/
              /* parametre olarak 5 değerini gönderdiğimde ; 
               * 1*=1, 1*=2, 2*=3, 6*=4, ve en son 24*=5 yapıp bana 120 değerini döndürüyor.*/
            int f = 1;
            for (int i = 1; i <= a; i++)
                f *= i;
            return f;
        }
        static void Main(string[] args)
        {
            Console.Write(Faktoriyel(5));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Tek-Çift gibi bir metot yazacaksam bool bir metot tanımlıyorum.
         bool sonuc diye değişken tanımlayarak kontrol ettiğim şeyin yanlış veye doğru olması halinde
         sonuc değişkenine atıyorum.
         eğer a%2 1 rakamına eşitse sonuc değişkenime true değer döndürmesini istiyorum
         değilse sonuc değişkenime, else ile false değeri döndürüyorum.
         ben bu metotu main bloğunda herhangi bir sayının tekmi çiftmi olduğunu bulmasını istediğim ve
         tekrardan çağıracağım için return ile sonuc değişkenini döndürüyorum.*/
        bool Tekcift(int a)
        {
            bool sonuc;
            if (a % 2 == 1) sonuc = true;
            else sonuc = false;
            return sonuc;
        }
        static void Main(string[] args)
        {
            /* program sınıfından p adında bir nesne türetiyorum(çünkü static olarak tanımlamadım metotumu!)
             bu p nesnemi yazdığım metot ile kullanmak içinse türetilmişnesne.metotunismi(parametre) olarak kullanıyorum.
             eğer benim girdiğim a değişkeni modlandığında 1'e eşitse tek yazısını ekrana basıyor değilse çift. */
            Program p = new Program();
            int a = Convert.ToInt32(Console.ReadLine());
            if (p.Tekcift(a)) Console.WriteLine("TEK");
            else Console.WriteLine("ÇİFT");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Yazdığım metot bir değer döndürmeyecekse geriye metotumu tanımlarken "void" kullanıyorum.
         foreach ile (foreach içerisindeki elemanları belli olanları terkar eder)
         (foreach her turda dizinin içindeki terimleri değişkenin içerisine aktarır)
         parametre olarak metota gönderidiğim diziyi ekrana yazdırıyorum.*/
        void Yaz(int[]d)
        {
            foreach(int i in d)
                Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            /*Burda olan olay şu şekilde işliyor;
             * int[] dizi değişkenimin içindeki terimleri yaz metotumun parametresine aktarıyorum
             * yaz metotumun içindeki foreach döngüsü de (dizi değişkenim tamamen d değişkenine aktarıldı)
             * d'yi 0 teriminden itibaren son terimine kadar ekranda alt alta bastırıyor.*/
            int[] dizi = { 1, 2, 3, 4, 5 };
            Program p = new Program();
            p.Yaz(dizi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /* Girilen sayı 20'den küçük ise sayıdan sıfıra kadar ekrana yazdıran metotu yazıyorum.*/
        
         /*Yazdığım metot değer döndürmeyeceği için void kullandım.
          * eğer sayı 20den büyükse metot bloğunu kırıp sonlandırıyorum
          * sayı 20den küçük ise girdiğim sayı döngüye giriyor ve bir defa girdiğim sayıyı ekrana basıp -1
          * azalarak ekrana sayıları yazıyor.*/
        void Sayiyaz(int a)
        {
            if (a > 20) return;
            for(int i = a; i>=0; i--)
                Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            /*Sınıfımdan nesne türetip, kullanıcıdan bir sayı alıyorum, sonra bu sayıyı metotuma gönderiyorum
             o da bana 20'den küçük ise sayı, 0'a eşit olana kadar bir eksilterek sayıları ekrana yazdırıyor.*/
            Program p = new Program();
            int girilen = Convert.ToInt32(Console.ReadLine());
            p.Sayiyaz(girilen);
        }
    }
}

/*static parametresi hakkında ufak bir not; 
static opsiyoneldir, bir metotun önüne static yazılmış ise program çalışır çalışmaz önüne static
yazdığım herşeyi alır ram'e yükler.
static tanımladığım metotlarda sınıflardan nesne türetilmez.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Kuvvet alacağım için metotumu double tanımlıyorum(parametreleri de öyle)
         sonuc değişkenime 1double değerini yüklüyorum, for döngüsü ile, i y'den küçük ve eşit olduğu sürece
         her turda i'yi bir arttırıp, sonuc(başta 1d) ile x değişkenindeki değeri çarpıp sonuc değişkeninin içine
         atıyorum, ve metotumu çağıracağım için return ile geri döndürüyorum.
         */
         /*a=2 b=3 olsun; metotuma a ve b değişkenini gönderdiğim zaman x=a y=b oluyor.
         1*=2, 2*=2, 4*=2 şekline geldiğinde(döngü 3 tur atmış oluyor(1 ile girdi bir arttı 2 oldu, bir arttı 3 oldu))
         i değişkeni 3'e eşit oluyor bu durumda i değişkeni y değişkenine eşit olduğu için for döngüsü sona eriyor
         ve ekrana 8 değerini yazıyor(4*=2)*/
        static double KuvvetAlma(double x, double y)
        {
            double sonuc = 1d;
            for (double i = 1; i <= y; i++)
                sonuc *= x;
            return sonuc;
        }
        static void Main(string[] args)
        {
            /* kullanıcıdan 2 tane değer alıp metotuma(x'in yerine a'yı, y'nin yerine b'yi gönderiyorum) o da bana
             metotta yazdığım işlemleri yapıp return edip gönderiyor.*/
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(KuvvetAlma(a,b));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Parametre olarak gönderilen 2 sayıyı toplayan metotu ve aynı sınıfın içinde, parametre olarak
         gönderilen 3 sayıyı toplayan metotu, static olarak geliştiriyorum*/

        /*Önce iki tane sayıyı toplayan bir metot yazıyorum 2 tane parametre ekliyorum
        * return ile bu sayıları toplayıp dönderiyorum.
        * üç tane sayıyı toplayan metot içinse, 3 tane parametre ekliyorum
        * Topla2 metotumu kullanarak 2 tane sayıyı toplatıp daha sonra üçüncü sayımı toplatıyorum
        * bunu direk return x+y+z olarak da yapabilirim fakat ercan hoca böyle yaptı. */
        static int Topla2(int x, int y)
        {
            return x + y;
        }
        static int Topla3(int x, int y, int z)
        {
            return Topla2(Topla2(x,y),z);
        }
        static void Main(string[] args)
        {
            // sayıları Topla2 ve Topla3 metotuma gönderiyorum, metotum toplayıp bana geri dönderiyor.
            Console.WriteLine(Topla2(3,4));
            Console.WriteLine(Topla3(3,4,11));
        }
    }
}

/* Önemli bir not !!!!
--------------------------------------------------------------------------------------------------------
| Tanımlandığı yer: Static | Kullanıldığı yer: Static | Biçim: Direk(SınıfınAdı.MetotunAdı) |
| Tanımlandığı yer: Static | Kullanıldığı yer: Static Değil | Biçim: Direk(SınıfınAdı.MetotunAdı) |
| Tanımlandığı yer: Static Değil | Kullanıldığı yer: Static | Biçim: Nesne Türet |
| Tanımlandığı yer: Static Değil | Kullanıldığı yer: Static Değil | Biçim: Direk(SınıfınAdı.MetotunAdı) |
---------------------------------------------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /* Object bir metot tanımlayıp, object bir dizinin içindekileri ekrana yazdırıyorum.*
         * önce dizimi array olarak tanımladım, değişkenimi object olarak tanımlayamıyorum direk Array
         * sınıfını dahil ediyorum.*/
        static void Diziyaz(Array dizi)
        {
            foreach(object o in dizi)
                Console.WriteLine(o);
        }
        static void Main(string[] args)
        {
            object[] d = { 1, 2, 3, "ali", "velvela", 1, 2.333};
            Program.Diziyaz(d); // burda nesne türetmedim metot static olsa bile başına sınıf.metotun ismi olarak kullanmak daha iyi
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Kendisine parametre olarak gelen dizideki sayının en küçüğünü bulup döndüren diziyi(programı) yaz*/
        /*metotumu tanımlıyorum parametre olarakta int bir dizi tanımlıyorum.
         bloğun içerisinde k diye bir değişken tanımlayıp içerisine, parametre olarak tanımladığım d dizisinin 0'ıncı terimini
         atıyorum, for döngüsü kurup i'yi sıfırdan başlatıyorum ve şart olarak i küçük ise d dizisinin uzunluğundan,
         döngüye devam etsin diyorum, her turda 1 arttırıyorum.
         eğer d dizisinin i'si k'dan küçük ise, d dizisinin i'sini k'nın içine atıyorum.
         return ile k'yı dönderiyorum.*/
        int KucukBul(int []d)
        {
            int k = d[0];
            for (int i = 0; i <d.Length; i++)
                if (d[i] < k) k = d[i];
            return k;
        }
        static void Main(string[] args)
        {
            /*dizimi tanımlıyorum, sınıftan nesnemi türetiyorum ve ekrana yazdırıyorum.*/
            int[] dizi = { 5, 3, 4, 1, 8 };
            Program p = new Program();
            Console.WriteLine(p.KucukBul(dizi));
        }  
    }
}


/*Bu örneğe birdaha bak...*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Dizideki tek sayıları döndürme*/
        /* metot'u dizi olarak tanımlıyorum, parametre olarakta bir dizi tanımlıyorum, a diye bir değişken oluşturup içine 0 
         * değerini atıyorum. foreach döngüsü ile d dizisinin her terimini 2'e modluyorum kalan 1 ise a'yı 1 arttırıyorum.
         * geri dönecek dizimi tanımlıyorum ve uzunluğunu a değişkenin içindeki değer kadar yapıyorum.
         * s diye bir değişken tanımlayıp içine sıfır değeri atıyorum.
         * bir döngü oluşturup i'yi sıfırdan başlatıp, i d dizisinden küçük olduğu sürece bir arttırıyorum
         * eğer d dizisinin i'si 2'ye modlandığında kalan bir ise geri dönecek dizimin s'nin içine d dizisinin i'sini atıyorum.
         * ve s'i bir arttırıyorum. return ile geri dönecek olan dizimi döndürüyorum.
         */
        int[] dondur(int[]d)
        {
            int a = 0;
            foreach (int i in d)
                if (i % 2 == 1) a++;
            int[] geridonecekdizi = new int[a];
            int s = 0;
            for(int i=0; i<d.Length; i++)
                if(d[i]%2==1)
                {
                    geridonecekdizi[s] = d[i];
                    s++;
                }
            return geridonecekdizi;
        }
        /* ekrana yazdırma metotu yazıyorum, ve d dizisinin terimlerini yazdırıyorum */
        static void yaz(int []d)
        {
            foreach(int i in d)
                Console.WriteLine("{0} ",i);
        }
        static void Main(string[] args)
        {
            /*dizimi tanımlayıp nesne türetiyorum, dd diye bir dizi tanımlayıp içerisine yazdığım metot ile, dizinin tek
             * sayılarını belirlediğim diziyi atıyorum ve ekrana yazdırıyorum.*/
            int[] dizi = { 1, 2, 22, 52, 55, 3, 5, 9, 99, 100 };
            Program p = new Program();
            int[] dd = p.dondur(dizi);
            yaz(dd);
        }  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Değer ve Referans Tip.*/
        /*Değişkenler 2 tiptedir değer ve referans tip.
         *Diziler Referans Tiptedir.
         *Değer tipteki değişkenler işe sokulurken o değeri kopyalar, kopyalanmış değişkende işlem yapar.
         *Referans tipteki değişkenler işleme sokulurken kopyalanmaz üzerinde işlem yapılır.*/

        static void ornek(ref int a)
        {
            a = 20;
        }
        static void Main(string[] args)
        {
            int b = 10; // ilk başta ekrana 10 yazar çünkü değer tipte bir değişken
            Console.WriteLine(b);
            ornek(ref b); // şimdi b değişkenini referans yaptığımız için 20 yazacak
            Console.WriteLine(b);
        }  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*OUT*/
        /*out ile değişkeni referansa çeviririz.
         *out ile tanımladığım deişkenlere ilk değer atamak zorunda değilim.*/
        static void ornek(out int a)
        {
            a = 20;
        }
        static void Main(string[] args)
        {
            int b;
            ornek(out b);
            Console.WriteLine(b);
        }  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*OVERLOAD*/
        /*Her metotun bir imzası vardır.
         Metotun imzasını belirleyen metotun adı, parametrelerinin sayısı ve parametrelerinin tipidir.
         Metotları birbirinden ayıran imzasıdır !*/
        static void test(int a, int b)
        {
            Console.WriteLine("İnt'li metot çalıştı");
        }
        static void test(string a, string b)
        {
            Console.WriteLine("string'li metot çalıştı");
        }
        static void test(float a, float b)
        {
            Console.WriteLine("float'li metot çalıştı");
        }
        static void Main(string[] args)
        {
            test("prog", "ders");
            test(3, 4);
            test(3.45f, 1.2f);
        }  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Overload*/
        /*bilinçsiz tip dönüşümü var int byte'ı kapsadığı için ekranda 2 tane
        int'li metot çalıştı yazısını görüyorum*/
        static void test(int a, int b)
        {
            Console.WriteLine("İnt'li metot çalıştı");
        }
        static void test(byte a, byte b)
        {
            Console.WriteLine("byte'li metot çalıştı");
        }
        static void Main(string[] args)
        {
            test(33, 44);
            test(333, 444);
        }  
    }
}

/*ram'de daha az yer tuttuğu için float olarak dönecek*/
using System;

namespace Application
{
    class Ornek
    {
        static void Test(double a,double b)
        {
            Console.WriteLine("double'li metot çalıştı");
        }
        static void Test(float a, float b)
        {
            Console.WriteLine("float'li metot çalıştı");
        }
        static void Main(string[] args)
        {
            Test(3, 4);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Params*/
        /*n adet parametre göndermek için kullanılır*/
        /*Params sonda kullanılmalıdır ! (static void ornek(int a,params int []d) şeklinde*/
        static void ornek(params int[]d)
        {
            Console.WriteLine(d[2]);
        }
        static void Main(string[] args)
        {
            ornek(5, 8, 9);
        }
    }
}

/*buna bak */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Params*/
        /*parametre olarak aldığı n adet sayıyı toplayarak sonucu döndüren
         *metotu yazıp kullanımını gösterin.*/
        static int toplam(params int[]d)
        {
            int t = 0;
            foreach (int i in d)
                t += i;
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(toplam(5,8,9));
            Console.WriteLine(toplam(50, 30, 20));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Overloadlı params örneği*/
        /*eğer 2 tane yerine 3 tane parametre gönderseydim paramslı olan çalışacaktı, 2 tane gönderdiğimde
         en uyumlu int olduğu için o çalıştı.*/
        static void ornek(params int[]d)
        {
            Console.WriteLine("paramslı");

        }
        static void ornek(int a, int b)
        {
            Console.WriteLine("int'li");
        }
        static void Main(string[] args)
        {
            ornek(3, 4,5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derscalısırken
{
    class Program
    {
        /*Recursive metotlar*/
        /*Öz yinelemeli, kendi kendisini çağıran metotlardır
         bir çözüm için geliştirdiğimiz förmül kendi içindeki sorunlara çözüm oluyorsa kullanılır*/
         //Recursive metot ile faktöriyel bulma
         static int Faktoriyel(int a)
        {
            if (a == 1) return 1; // düğüm noktası
            else return a * Faktoriyel(a - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Faktoriyel(5));
        }
    }
}
