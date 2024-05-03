using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntoFilaPilha
{
    internal class NumeroFila : Numero
    {
        NumeroFila? proximo;

        public NumeroFila(int num) : base(num)
        {
            proximo = null;
        }

        public void SetProximo(NumeroFila proximo)
        {
            this.proximo = proximo;
        }

        public NumeroFila? GetProximo()
        {
            return proximo;
        }
    }
}
