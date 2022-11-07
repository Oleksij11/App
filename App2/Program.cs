﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new BadPupil(), new ExcelentPupil(), new GoodPupil());
            classRoom.Print();
        }
    }
}
