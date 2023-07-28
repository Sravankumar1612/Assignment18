using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Connect();
            smartPhone.Charge(30);
            smartPhone.Display();

            Laptop laptop = new Laptop();
            laptop.Connect();
            laptop.Charge(60);
            laptop.Display();

            Console.ReadKey();
        }
    }
}