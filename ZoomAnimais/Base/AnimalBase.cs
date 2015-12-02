using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomAnimais
{
    abstract class  AnimalBase: SerVivoBase, IEmissorBarulho
    {

        public abstract void FazerBarulho();


        public override string ToString()
        {

            return string.Format("Animal : {0} , {1} , {2}, {3}, {4}, {5} ", Nome, Peso, Idade, Altura, IsVivo, IsFromCativeiro); 
        }
    }

  
    
}
