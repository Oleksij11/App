using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine($"Value: {value}");
        }
    }
}
