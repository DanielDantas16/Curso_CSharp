namespace Exercicios008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a velocidade percorrida: ");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            if (velocidade > 80)
            {
                double multa = (velocidade - 80) * 7.0;
                Console.WriteLine("Você foi mutado em R${0} " , multa);
            }
            else
            {
                Console.WriteLine("Você esta na velocidade adequada, parabéns!");
            }
        }
    }
}
