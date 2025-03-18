

namespace Adivinhação.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Adivinhacao.Menu();

                int totaltentativas = Adivinhacao.OpcaoDeDificuldade();
                int numeroSecreto = Adivinhacao.geradorDoNumeroSecreto();
                Adivinhacao.lacoderepeticao(totaltentativas, numeroSecreto);


                bool opcaoContinuar = Adivinhacao.opcaoContinuar();
                if (opcaoContinuar == true)
                    break;



            }
        }
    }
}