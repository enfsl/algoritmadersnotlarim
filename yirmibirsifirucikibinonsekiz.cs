/*String metotlar */
/*alfabetik sıraya göre sıralama (değişkenden !) */
/*bu metot statik değil sınıf adıyla kullanmadık. */
using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ders";
            int b = a.CompareTo("derslik");
            Console.WriteLine(b);
            Console.WriteLine();
            Console.WriteLine("ders".CompareTo("berber"));
        }
    }
}

/*kullanıcı tarafından girilen bir ifadenin (web adresinin) google.com olup olmadığını bulan metotu yazın*/
using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static bool Webkontrol(string google,string kontrol)
        {
            if (String.Compare(google, 3, kontrol, 0, kontrol.Length) == 0) return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Webkontrol("www.google.com",".google."));
        
        }
    }
}

using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "dersler";
            Console.WriteLine(a.IndexOf('r')); // a değişkeninin içinde r geçiyormu onu arar.
            Console.WriteLine(a.IndexOf("erdem"));
            Console.WriteLine(a.LastIndexOf('e')); // e'yi sondan arar, aramayı sonran arar ama baştan 1-2-3 diye sıralar.
            Console.WriteLine(a.IndexOf('e',2));// e'yi ikiden başlayıp arar
            Console.WriteLine(a.LastIndexOf("er"));

            char[] c = { 'r', 'b', 'c' };
            Console.WriteLine(a.IndexOfAny(c)); //char tipindeki bir dizinin terimini string içinde arar
            Console.WriteLine(a.LastIndexOfAny(c)); //char tipindeki bir dizinin terimini tersten string içinde arar

            Console.WriteLine(a.StartsWith("de"));//startwith; şununla başlıyomu diye kontrol eder

            string b = "    dersler    ";
            Console.WriteLine(b.Trim()+"_"); // metnin başındaki ve sonundaki boşlukları, karakterleri kesmek için kullanılır
            Console.WriteLine(a.Trim(c));

            Console.WriteLine(a.PadRight(10)+"_"); // dolgu yapar (boşluk karakteri ekler) sağına!
            Console.WriteLine(a.PadLeft(10)); // soluna

        }
    }
}
