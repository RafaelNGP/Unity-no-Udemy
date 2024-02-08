using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de perguntas
            string[] perguntas =
            {
                "O que tem capa mas n voa?",
                "Sem sair do seu cantinho, eh capaz de viajar ao redor do mundo?",
                "Eh alta quando jovem e baixinha quando velha. Alem disso, eh rapida quando magra e lenta quando gorda. O que eh?"
            };

            //Array de respostas
            string[] respostas =
            {
                "livro",
                "selo",
                "vela"
            };

            string sair = "n";
            while (sair != "s")
            {
                //logica para escolher a pergunta
                Random random = new Random();
                int index = random.Next(0, respostas.Length);
                Console.WriteLine(perguntas[index]);
                string resposta = Console.ReadLine().ToLower();

                if (resposta == respostas[index])
                {
                    Console.WriteLine("Vc acertou!");
                    sair = GameOver();
                }else
                {
                    Console.WriteLine("Que pena, vc errou");
                    sair = GameOver();
                }
                Console.ReadKey();
            }
        }
        static string GameOver()
        {
            Console.WriteLine("Deseja jogar novamente? Responda sair ou quit para encerrar o game");
            string escolha = Console.ReadLine();
            if (escolha.ToLower() == "sair" || escolha.ToLower() == "quit")
            {
                return "s";
            }
            else return "n";
        }
    }
}
