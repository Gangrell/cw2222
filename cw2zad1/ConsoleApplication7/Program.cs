using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            AstonMartin AM = new AstonMartin();
            RangeRover RR = new RangeRover();
            RollsRoyce RRe = new RollsRoyce();

            Console.WriteLine(AM.WypiszMarke() + " " + AM.WypiszSalon());
            Console.WriteLine(RR.WypiszMarke() + " " + RR.WypiszSalon());
            Console.WriteLine(RRe.WypiszMarke() + " " + RRe.WypiszSalon());
        }
    }
}
