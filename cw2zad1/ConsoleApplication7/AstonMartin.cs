using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class AstonMartin : ISamochod
    {
        public AstonMartin()
        { }
        public string WypiszMarke()
        {
            return "Marka Aston Martin.";
        }
        public string WypiszSalon()
        {
            return "Salon w Wąchocku";
        }
    }
}
