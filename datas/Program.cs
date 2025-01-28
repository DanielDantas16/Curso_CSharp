namespace datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", " Novembro", "Dezembro" };
            int[] dia = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("O mês de " + meses[i] + " tem " + dia[i] + " dias.");
            }
            string[] semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            foreach (string dias in semana)
            {
                Console.WriteLine(dias);
            }
            Console.WriteLine();
            foreach (string mes in meses)
            {
                Console.WriteLine(mes);
            }
        }
    }
}