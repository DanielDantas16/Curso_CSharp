namespace TesteTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.WriteLine("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triângulo.");
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triangulo.");
            }
        }
    }
}
