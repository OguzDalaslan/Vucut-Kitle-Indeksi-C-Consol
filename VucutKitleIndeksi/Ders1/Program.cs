using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double boy, kilo, bdki;
            Console.WriteLine("Boyunuzu Metre Cinsinden Giriniz:");
            boy =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilonuzu Kg olarak Giriniz");
            kilo = Convert.ToDouble(Console.ReadLine());
            bdki = kilo / (boy * boy);
            Console.WriteLine("Beden Kitleniz:{0}", bdki);
            Console.ReadKey();

        }
    }
}
