using System.Text.RegularExpressions;

namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String genero;
            Console.WriteLine("Digite seu genero: ");
            genero = Console.ReadLine().ToUpper();
           
            while (genero != "F" && genero != "M")
               
            {
                Console.WriteLine("Digite seu genero");
                genero = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Bem-vindos e Bem-vindas ao curso de C#!");

        }    }
}
