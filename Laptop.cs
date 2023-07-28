using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        int charge;
        string info;
        public Laptop()
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
            Console.WriteLine("COnnected to Laptop");
            return true;
        }

        public string Display()
        {
            Console.WriteLine("Charging Time: " + charge + " minutes");
            return info;
        }
    }
}