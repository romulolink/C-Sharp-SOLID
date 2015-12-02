using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomAnimais
{
    abstract class MamiferoBase  : AnimalBase
    {

        public override void Nascer()
        {
            base.Nascer();
            Console.WriteLine("Um mamífero nasceu.");
        }

    }
}
