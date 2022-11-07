using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("I`m studying!\n");
        }
        public virtual void Read()
        {
            Console.WriteLine("I`m reading!\n");
        }
        public virtual void Write()
        {
            Console.WriteLine("I`m writing!\n");
        }
        public virtual void Relax()
        {
            Console.WriteLine("I`m relaxing!\n");
        }
    }
}
