using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class SmartPhone : IConnectable, IRechargeable, IDisplayable
    {
        int charge;
        string info;
        public SmartPhone()
        {
            charge = 0;
            info = "";
        }
        public int Charge(int minutes)
        {
            charge += minutes;
            return charge;
        }

        public bool Connect()
        {
            Console.WriteLine("Connected to SmartPhone");
            return true;
        }

        public string Display()
        {
            Console.WriteLine("Charging Time: " + charge + " minutes");
            return info;
        }
    }
}