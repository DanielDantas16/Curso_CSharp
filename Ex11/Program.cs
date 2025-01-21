using System.ComponentModel.Design;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu salário: ");
            double salário = Convert.ToDouble(Console.ReadLine());
            double aumento;

            if (salário > 2500)
            {
                aumento = salário * 0.05;
                Console.WriteLine("O seu salário com aumento agora é {0}: ", (aumento + salário));


            }
            else if (salário > 1250)
            {
                aumento = salário * 0.10;
                Console.WriteLine("O seu salário com aumento agora é {0}: ", (aumento + salário));
            }
            else
            {
                aumento = salário * 0.15;
                Console.WriteLine("O seu salário com aumento agora é {0}: ", (aumento + salário));
            }
        }
    }
}
