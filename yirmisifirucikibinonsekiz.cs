/*String metotlar*/
/*kendisine parametre olarak gelen char bir diziyi string olarak döndüren metotu yazınız*/
using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static string ChartoString(char[]c)
        {
            string s = "";
            foreach (char i in c)
                s += i;
            return s;
        }
        static void Main(string[] args)
        {
            char[] c = { 'd', 'e', 'r', 's' };
            string a = ChartoString(c);
            Console.WriteLine(a);
        }
    }
}

/*String metotlar*/
/*kendisine parametre olarak gelen char bir diziyi string olarak döndüren metotu yazınız*/
/*!!PARAMSLI HALİ!!  */
using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static string ChartoString1(char[]c)
        {
            string s = "";
            foreach (char i in c)
                s += i;
            return s;
        }
        static string ChartoString(params char[] c)
        {
            string s = "";
            foreach (char i in c)
                s += i;
            return s;
        }
        static void Main(string[] args)
        {
            char[] c = { 'd', 'e', 'r', 's' };
            string a = ChartoString('p','r','o','g');
            Console.WriteLine(a);
        }
    }
}

/*String metotlar*/
/*kendisine parametre olarak gelen char bir diziyi string olarak döndüren metotu yazınız*/
/*Aşşığda kullanılan "String" bir sınıf değil bir yapı, (tipler yapılardan nesneler sınıflardan türetilir.)*/
/*basit bir şekilde string olarak döndürme işlemleri var aşşağıda.. */
using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static string ChartoString(char[]c)
        {
            string s = "";
            foreach (char i in c)
                s += i;
            return s;
        }
        static void Main(string[] args)
        {
            char[] c = { 'd', 'e', 'r', 's' };
            String s = new String(c);
            Console.WriteLine(s);
            s = new string('-', 25);// kolayca cizgi çekiyorum
            Console.WriteLine(s);
            s = new string(c, 0, 4);// c nin 0'ından başla 4 tanesini al s'in içine at.
            Console.WriteLine(s);
        }
    }
}

/*String Metotlar*/
using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concat: Toplamak birleştirmek (Kendisine parametre olarak gelen n adet stringi birleştirir).
            string s = String.Concat("ali", "veli", "kırkdokuz", "elli");
            Console.WriteLine(s);
        }
    }
}

/*String Metotlar */
/*Concat metotu yazmak */
using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static string Concat(params string[]s)
        {
            string d = "";
            foreach (string i in s)
                d += i;
            return d;
        }
        static void Main(string[] args)
        {
            string s = Concat("ali", "veli", "kırkdokuz", "elli");
            Console.WriteLine(s);
        }
    }
}

/*String Metotlar */
/*alfabetik sıraya göre karşılaştırma*/
using System;
namespace derstekikodlaricalistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Compare("ali", "veli")); // 0, 1, -1 değeri döndürür.
            Console.WriteLine(String.Compare("Ali", "veli"));
            Console.WriteLine(String.Compare("ali", "ali"));
            Console.WriteLine(String.Compare("ali", "ALİ",false));
            Console.WriteLine(String.Compare("ali", "ALİ", true));

        }
    }
}