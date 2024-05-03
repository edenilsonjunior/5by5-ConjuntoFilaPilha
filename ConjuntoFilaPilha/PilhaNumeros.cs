using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntoFilaPilha
{
    internal class PilhaNumeros
    {
        NumeroPilha? topo;
        int tamanho;

        public PilhaNumeros()
        {
            topo = null;
            tamanho = 0;
        }

        public void Push(NumeroPilha aux)
        {
            if (IsEmpty())
            {
                topo = aux;
            }
            else
            {
                aux.SetAnterior(topo);
                topo = aux;
            }

            tamanho++;
        }

        public NumeroPilha? Pop()
        {
            NumeroPilha? removido = null;

            if (!IsEmpty())
            {
                removido = topo;
                topo = topo.GetAnterior();

                tamanho--;
            }
            removido.SetAnterior(null);
            return removido;
        }

        public int GetTamanho()
        {
            return tamanho;
        }

        public bool IsEmpty()
        {
            return topo == null;
        }

        public void Print()
        {

            if (IsEmpty())
            {
                Console.WriteLine("-->Pilha vazia!");
            }
            else
            {
                NumeroPilha aux = topo;

                while (aux != null)
                {
                    Console.WriteLine($"--> {aux}");
                    aux = aux.GetAnterior();
                }
            }
        }

        public bool Contains(int num)
        {
            NumeroPilha aux = topo;

            while (aux != null)
            {
                if(aux.getNum() == num)
                {
                    return true;
                }
                aux = aux.GetAnterior();
            }

            return false;
        }
    }
}
