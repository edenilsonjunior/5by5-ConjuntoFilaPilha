using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntoFilaPilha
{
    internal abstract class Numero
    {
        int num;

        public Numero(int num)
        {
            this.num = num;
        }

        public int getNum()
        {
            return num;
        }

        public override string? ToString()
        {
            return num.ToString();
        }
    }
}
