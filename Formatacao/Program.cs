namespace Formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.54821;
            double num2 = 54.83783;

            Console.WriteLine($"{num1:F4}");
            Console.WriteLine($"{num2:N2}");
            Console.WriteLine($"{num1:C2}");
            Console.WriteLine($"{num2:E2}");
            Console.WriteLine($"{num1:P2}");
        }
    }
}
