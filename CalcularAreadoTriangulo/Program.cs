namespace CalcularAreadoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo(6,9);
        }
        static void triangulo(double area, double altura) {

            double baseT = (area * altura)/2;
            Console.WriteLine("O resultado do calculo do triângulo é de: " + baseT);


    } }
}
