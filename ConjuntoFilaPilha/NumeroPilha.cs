using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntoFilaPilha
{
    internal class NumeroPilha : Numero
    {

        NumeroPilha? anterior;

        public NumeroPilha(int num) : base(num)
        {
            anterior = null;
        }

        public void SetAnterior(NumeroPilha anterior)
        {
            this.anterior = anterior;
        }

        public NumeroPilha? GetAnterior()
        {
            return anterior;
        }
    }
}
