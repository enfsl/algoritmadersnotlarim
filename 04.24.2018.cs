/* Enumeration(Enum)
 * Enum Sabitleri  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace derstekikodlaricalistirma
{
    enum gunler : byte { pazartesi, sali, carsamba, persembe, cuma, cumartesi, pazar};
    enum durum { gecti, kaldi};
    enum notlar : byte { kaldı, basarısız, gecer, orta, iyi, pekiyi}; // dizi gibi düşün 0 kaldı, 1 başarısız, 2 geceri temsil eder.
    class Program
    {
        static void Main(string[] args)
        {
            byte not = Convert.ToByte(Console.ReadLine());
            notlar drm = (notlar)not; // direk notu notlara atamıyoruz cast etmemiz gerekiyor.
            Console.WriteLine(drm);
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
    /*diziyi kullanıcının isteğine göre yan yana yada alt alta yazdıran program, (true false kontrol)*/
    enum bicim : byte { yanyana, altalta};
    class Program
    {
        static void yaz(bool b, Array a)
        {
            if(b==true)
                foreach(object o in a)
                    Console.Write(o+"\t");
            else
                foreach(object o in a)
                    Console.WriteLine(o);
        }
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "ayse", "beyza" };
            yaz(true, isimler);
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
    /*diziyi kullanıcının isteğine göre yan yana yada alt alta yazdıran program, (parametre göndererek yaptık)*/
    enum bicim : byte { yanyana, altalta};
    class Program
    {
        static void yaz(bicim b, Array a)
        {
            if(b==bicim.yanyana)
                foreach(object o in a)
                    Console.Write(o+"\t");
            else
                foreach(object o in a)
                    Console.WriteLine(o);
        }
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "ayse", "beyza" };
            yaz(bicim.yanyana, isimler);
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
    enum renkler : byte { siyah=0, kahve=5, koyukahve, krem=14,beyaz, sari=8 };// koyukahve 6, beyaz 15 olcak

    class Program
    {
        
        static void Main(string[] args)
        {
            renkler renk = (renkler)6;
            Console.WriteLine(renk);
            Console.WriteLine(renkler.sari);// sayı karşılığını görmeyiz.
            byte b = (byte)renkler.sari; // tersten cast edersek sayıyı görürüz
            Console.WriteLine(b);
        }
    }
}