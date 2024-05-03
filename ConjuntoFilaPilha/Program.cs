namespace ConjuntoFilaPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaNumeros pilha = new PilhaNumeros();
            FilaNumeros fila = new FilaNumeros();

            Console.WriteLine("======Conjuntos======");

            Console.WriteLine("Populando a pilha: ");
            for (int i = 0; i < 10; i++)
            {
                pilha.Push(new NumeroPilha(ReadInt(i + 1)));
            }

            Console.WriteLine("Populando a fila: ");
            for (int i = 0; i < 10; i++)
            {
                fila.Enqueue(new NumeroFila(ReadInt(i + 1)));
            }

            // Exibicao dos itens e a interseccao deles
            Console.WriteLine("Itens da pilha:");
            pilha.Print();

            Console.WriteLine("=======================");
            Console.WriteLine("Itens da fila:");
            fila.Print();
            
            Console.WriteLine("=======================");
            Interseccao(pilha, fila);
        }

        static void Interseccao(PilhaNumeros pilha, FilaNumeros fila)
        {

            Console.WriteLine("Interseccao da pilha e da fila: ");

            FilaNumeros filaAuxiliar = new();
            int[] numeros = new int[10];
            int indice = 0;

            while (!fila.IsEmpty())
            {
                // Tira um numero da fila
                NumeroFila aux = fila.Dequeue();

                if (pilha.Contains(aux.getNum()))
                {
                    numeros[indice++] = aux.getNum();
                }
                filaAuxiliar.Enqueue(aux);
            }

            while (!filaAuxiliar.IsEmpty())
            {
                fila.Enqueue(filaAuxiliar.Dequeue());
            }

            for(int i = 0; i < indice; i++)
            {
                Console.WriteLine($"--> {numeros[i]}");
            }
        }


        static int ReadInt(int indice)
        {
            Console.Write($"Digite o numero {indice}: ");

            bool resultadoTry = int.TryParse(Console.ReadLine(), out int numero);

            if (resultadoTry)
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Numero inválido!");
                return ReadInt(indice);
            }
        }
    }
}
