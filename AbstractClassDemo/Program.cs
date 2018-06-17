using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var koyun = new Koyun();
            koyun.BeslenmeTipi();

            var timsah = new Timsah();
            timsah.BeslenmeTipi();

            Console.ReadKey();
        }
    }
}
