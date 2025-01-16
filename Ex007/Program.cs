namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota_final;
            string resultado;

            Console.WriteLine("Digite a nota final do aluno: ");
            nota_final = Convert.ToDouble(Console.ReadLine());

            if (nota_final >= 70)
            {
                resultado = "Aprovado";
                if (nota_final >= 95)
                {
                    resultado = "Aprovado com louvor";
                }
            }
            else if (nota_final >= 45)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
            Console.WriteLine("O aluno ficou {1}.", nota_final, resultado);
        }
    }
}
