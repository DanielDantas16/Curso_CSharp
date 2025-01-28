namespace VetordeFrutas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = {"Maçã", "Banana", "Melão", "Abacaxi", "Morango", "Uva", "Pêra"};
            double[] preco = {10.90, 16.69, 7.00, 9.99, 4.50, 19.00, 12.80};

            string primeiraFrutaAlfabetica = frutas.Min();
            Console.WriteLine("A primeira fruta em ordem alfabética é: " + primeiraFrutaAlfabetica);

            string ultimaFrutaAlfabetica = frutas.Max();
            Console.WriteLine("A ultima fruta em ordem alfabética é: " + ultimaFrutaAlfabetica);


            double menorPreco = preco.Min();
            Console.WriteLine("A fruta de menor valor é: R$" + menorPreco);
            double maiorPreco = preco.Max();
            Console.WriteLine("A fruta de maior valor é: R$" + maiorPreco);

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("A fruta é {0} e ela custa R${1} " , frutas[i], preco[i]);
            }
        }
    }
}
