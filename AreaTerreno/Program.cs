namespace AreaTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================");
            Console.WriteLine("Calcular a Área do Terreno");
            Console.WriteLine("================");
            Console.WriteLine();

            Console.WriteLine("Digite a largura do terreno(m): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o comprimento do terreno(m): ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(l, c);
        }
        static void area(double largura, double comprimento)
        {
            double a = largura * comprimento;
            Console.WriteLine($"A Área do terreno de {largura} x {comprimento} é de {a:F2}m²");
        }
    }
}
