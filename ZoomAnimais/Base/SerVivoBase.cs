using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomAnimais
{
    abstract class SerVivoBase : IVivedor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; private set; }
        public bool IsVivo { get; private set; }
        public bool IsFromCativeiro { get; set; }

        public void Crescer()
        {
            Peso ++;
            Altura += 0.1M;
            Idade ++;
            
        }

        public virtual void Morrer()
        {
            IsVivo = false;
        }

        public virtual void Nascer()
        {
            Idade = 0;
            IsVivo = true;
        }




    }
}
