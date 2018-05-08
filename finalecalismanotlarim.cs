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

