namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Ele é par");

            }
            else
            {
                Console.WriteLine("Ele é impar");
            }
        }
    }
}
