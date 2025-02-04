namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contagem(1, 10, 1);
            contagem(10, 0, 2);
            Escrever("Agora é a sua vez de fazer a contagem");
            Console.WriteLine("Digite o inicio da contagem: ");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o fim da contagem: ");
            int fim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o passo da contagem: ");
            int passo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            contagem(ini, fim, passo);
        }

        static void contagem(int i, int f, int p)
        {
            Escrever($"Contagem de {i} até {f} de {p} em {p}.");

            if (p < 0)
            {
                p *= -1;
            }
            if (i < f)
            {
                int cont = i;
                while (cont <= f)
                {
                    Console.Write(cont + " ");
                    Thread.Sleep(500);
                    cont += p;
                }
                Console.WriteLine("Fim!");
            }
            else {
                int cont = i;
                while (cont >= f) { 
                Console.Write(cont + " ");
                    Thread.Sleep(500);
                    cont -= p;
                }
                Console.WriteLine("Fim!");












            }
        }

        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new string('=', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine($"{ textoCentralizado}");
            Console.WriteLine(linha);
        }
    }
}
