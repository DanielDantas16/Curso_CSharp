namespace Ex009

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string resultado;

            if (num % 2 == 0)
            {
                resultado = ("O número digitado {0} ele é par ");
            }
            else
            {
                resultado = (" número digitado {0} ele é impar ");
            }
            Console.WriteLine(resultado, num);
        }
    }
}
