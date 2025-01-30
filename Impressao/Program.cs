namespace Impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Daniel Dantas de Almeida");
            Console.WriteLine();
            escreva("Curso C#");
            Console.WriteLine();
            escreva("Olá");
            Console.WriteLine();
        }
        static void escreva(string texto) {
            char caracter = '=';
            int tamanho = texto.Length + 4;
            string linha = new string(caracter, tamanho);
            string textoCentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho);
            Console.WriteLine((linha));
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }
    }
}