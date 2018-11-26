using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int day = 12;
            int month = 03;
            int year = 2013;
            var x = year;

            if ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0))
            {
                Console.WriteLine("Det er skuddår: " + year);
                Console.Read();
            }
        }
    }
}
