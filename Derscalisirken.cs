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