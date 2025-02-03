namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            operacao();

        }

        static void operacao()
        {

            Console.WriteLine("Informe um número para fazer o calculo: ");
            double adicao1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número para fazer o calculo: ");
            double adicao2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual operação você deseja fazer? +, -, *, /");
            Console.ReadLine();

            

        }
    }
}
