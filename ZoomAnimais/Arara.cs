﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomAnimais
{
    sealed class Arara : AveBase
    {
        public override void FazerBarulho()
        {
            Console.WriteLine("Grasna.");
        }
    }

}
