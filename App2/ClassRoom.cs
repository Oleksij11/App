using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class ClassRoom
    {
        public Pupil[] Pupils { get; set; } = new Pupil[4];

        public ClassRoom()
        {

        }
        public ClassRoom(params Pupil[] pupil)
        {
            Pupils = pupil;
        }

        public void Print()
        {
            foreach (var p in Pupils)
            {
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine("~~~~~~~~~~~~~~~~\n");
            }
        }
    }
}
