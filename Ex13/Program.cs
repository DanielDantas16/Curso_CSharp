using System.Runtime.Serialization;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma, cont;
            soma = cont = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 3 == 0)
                {
                    soma += i;
                    cont++;
                }
            }
            Console.WriteLine("A soma dos {0} valores solicitados é: {1}", cont, soma);
        }
    }
}
