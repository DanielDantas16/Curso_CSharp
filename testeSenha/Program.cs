using System.ComponentModel.Design;

namespace testeSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String senha = "123";
            String senhaDigitada;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;
                if (tentativas > 3)
                { break; }

            }while (senha != senhaDigitada);

            if ( senha != senhaDigitada ) {
            Console.Clear() ;
            Console.WriteLine("Senha incorreta! Tentativas: " + tentativas);

                }else
            {
                Console.Clear();
                Console.WriteLine("Senha correta! Tentativas: " + tentativas);
            }
                }
    }
}
