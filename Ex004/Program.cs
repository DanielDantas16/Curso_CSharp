namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float resposta;

            Console.WriteLine("Digite um número");

            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número");

            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = num1 - num2;
            Console.WriteLine("A subtração de {0} - {1} = {2}", num1, num2, num3);

            num3 = num1 + num2;
            Console.WriteLine("A adição de {0} + {1} = {2}", num1, num2, num3);

            num3 = num1 * num2;
            Console.WriteLine("A multiplicação de {0} * {1} = {2}", num1, num2, num3);

            resposta = num1 / num2;
            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num2, resposta);

            resposta = num1 % num2;
            Console.WriteLine("O resto da divisão de {0} % {1} = {2}", num1, num2, resposta);

            float num4 = 35f;
            resposta = num1 / num4;

            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num4, resposta);
        }
    }
}
