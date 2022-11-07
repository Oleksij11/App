using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class BadPupil: Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"I`m Bad pupil. ");
            base.Study();
        }

        public override void Read()
        {
            Console.WriteLine($"I`m Bad pupil. ");
            base.Read();
        }

        public override void Write()
        {
            Console.WriteLine($"I`m Bad pupil. ");
            base.Write();
        }

        public override void Relax()
        {
            Console.WriteLine($"I`m Bad pupil. ");
            base.Relax();
        }
    }
}
