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