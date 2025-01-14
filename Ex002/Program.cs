namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = -45;
            float num2 = 4.58f;
            char letra = 'c';
            string nome = "Daniel";
            Console.WriteLine("O número é {0}.", num1);
            Console.WriteLine("O valor é R${0}." ,num2);
            Console.WriteLine("a letra é {0}. ",letra);
            Console.WriteLine("Seu nome é {0}.",nome);
            Console.WriteLine("O número é {0}, " + "o valor é R$ {1}" + " a letra é {2} " + "seu nome é {3}.", num1, num2, letra, nome);
        }

    }
}
