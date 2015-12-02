using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomAnimais
{
    abstract class ReptilBase : AnimalBase
    {

        public override void Nascer()
        {
            base.Nascer();
            Console.WriteLine("Um réptil nasceu.");
        }

    }
}
