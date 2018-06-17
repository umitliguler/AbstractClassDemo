using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Koyun : Hayvan
    {
        public override void BeslenmeTipi()
        {
            Console.WriteLine("Koyun Otobur");
        }
    }
}
