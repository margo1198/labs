using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new JuniorDeveloper("Junior");
            Project pr1 = dev.Create();

            dev = new MidleDeveloper("Midle");
            Project pr2 = dev.Create();
            dev = new SenjorDeveloper("Senjor");
            Project pr3 = dev.Create();
            Console.ReadLine();
        }
    }
}
