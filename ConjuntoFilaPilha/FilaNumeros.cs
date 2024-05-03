using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntoFilaPilha
{
    internal class FilaNumeros
    {
        NumeroFila? head;
        NumeroFila? tail;
        int tamanho;

        public FilaNumeros()
        {
            this.head = null;
            this.tail = null;
        }

        public void Enqueue(NumeroFila aux)
        {
            if (IsEmpty())
            {
                head = aux;
                tail = aux;
            }
            else
            {
                tail.SetProximo(aux);
                tail = aux;
            }
            tamanho++;
        }

        public NumeroFila? Dequeue()
        {
            if (!IsEmpty())
            {
                NumeroFila aux = head;

                if (head == tail)
                    head = tail = null;
                else
                    head = head.GetProximo();

                tamanho--;

                return aux;
            }
            return null;
        }

        public int GetTamanho()
        {
            return tamanho;
        }
        public bool Contains(int num)
        {
            NumeroFila aux = head;

            while (aux != null)
            {
                if (aux.getNum() == num)
                {
                    return true;
                }
                aux = aux.GetProximo();
            }

            return false;
        }
        public void Print()
        {

            if (IsEmpty())
            {
                Console.WriteLine("-->Fila vazia!");
            }
            else
            {
                NumeroFila aux = head;

                while (aux != null)
                {
                    Console.WriteLine($"--> {aux}");
                    aux = aux.GetProximo();
                }
            }
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
