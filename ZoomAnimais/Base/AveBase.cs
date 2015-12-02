using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomAnimais
{
    abstract class AveBase : AnimalBase
    {

        public override void Nascer()
        {
            base.Nascer();
            Console.WriteLine("Uma ave nasceu.");
        }

        public void Voar()
        {
            Console.WriteLine("O animal está voando.");
        }
    }
}
