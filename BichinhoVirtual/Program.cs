using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BichinhoVirtual
{
    internal class Program
    {
        static Bichinho pet;
        static int op;
        static bool playing = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Meu Bichinho Virtual");

            if (File.Exists("dados"))
            {
                pet = Backup.CarregarDados();
                Console.WriteLine("Os dados foram carregados!\n");
            } else
            {
                pet = new Bichinho();
                Console.WriteLine("Vamos criar o seu bichinho!");
                Console.WriteLine("Digite um nome para ele: ");
                pet.setName(Console.ReadLine());

                Console.WriteLine("Qual a comida favorita: ");
                pet.SetComida(Console.ReadLine());

                Console.WriteLine("Salvando...");
                try
                {
                    Backup.SalvarDados(pet);
                    Console.WriteLine("Salvo com sucesso!");
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            // game logic here
            while (playing)
            {
                Console.Clear();
                Console.WriteLine("Stats");
                Console.WriteLine("Nome: {0}\nFome: {1}\nLimpeza: {2}\nFelicidade: {3}\n", pet.getName(), pet.getAlimentado(), pet.getLimpo(), pet.getFeliz());
                Console.WriteLine("O que deseja fazer?\n1) Alimentar\n2) Dar banho\n3) Brincar\n4) Sair");
                string comando = Console.ReadLine();
                try
                {
                    op = Convert.ToInt32(comando);
                } catch (Exception ex)
                {
                    op = 0;
                }
                
                switch(op)
                {
                    case 1: { AlimentarPet(); break; }
                    case 2: { LimparPet(); break; }  
                    case 3: { BrincarPet();  break; }  
                    case 4: { playing = false; break; }  
                }
            }
        }
        static void AlimentarPet()
        {
            Console.WriteLine("Você acabou de dar {0} para {1}", pet.getComida() ,pet.getName());
            pet.setAlimentado(50);
            if (pet.getAlimentado() >= 100) pet.setAlimentadoFULL();
            Console.WriteLine(PetFalando(1));
            Console.ReadKey();
        }

        static void LimparPet()
        {
            Console.WriteLine("Você dá um banho em {0}", pet.getName());
            pet.Limpar();
            Console.WriteLine(PetFalando(2));
            Console.ReadKey();
        }

        static void BrincarPet()
        {
            Console.WriteLine("Você brinca com {0}", pet.getName());
            pet.Brincar();
            Console.WriteLine(PetFalando(3));
            Console.ReadKey();
        }

        static string PetFalando(int modo)
        {
            Random random = new Random();
            switch (modo)
            {
                case 1:
                    {
                        string[] frasesComida = new string[] {
                        "Você é o melhor dono do mundo!",
                        "Que delícia de comida! Estou satisfeito!",
                        "Nham nham nham... Muito obrigado!",
                        "Você cuida tão bem de mim! Sou muito grato!",
                        "Estava com fome, mas agora estou feliz!",
                        "Você sabe do que eu gosto! Amei a refeição!",
                        "Você é muito generoso! Obrigado por me alimentar!",
                        "Que sorte a minha de ter você! Você me alimenta tão bem!",
                        "Hummm... Que gostoso! Você é um ótimo cozinheiro!",
                        "Você me faz tão feliz! Obrigado por me dar comida!"
                    };
                    return frasesComida[random.Next(frasesComida.Length)];
                    }
                case 2:
                    {
                        string[] frasesBanho = new string[] {
                        "Ahh, que refrescante! Obrigado por me dar um banho!",
                        "Você me deixou tão limpinho e cheiroso! Muito obrigado!",
                        "Eu adoro tomar banho com você! Você é muito carinhoso!",
                        "Você me faz sentir tão bem! Obrigado por cuidar de mim!",
                        "Eu estava precisando de um banho! Você é muito atencioso!",
                        "Você me deu um banho tão gostoso! Estou muito feliz!",
                        "Você é o melhor dono do mundo! Obrigado por me dar um banho!",
                        "Que delícia de banho! Você me deixou muito relaxado!",
                        "Você me faz tão feliz! Obrigado por me dar um banho!",
                        "Você é muito gentil! Obrigado por me dar um banho!"
                    };
                        return frasesBanho[random.Next(frasesBanho.Length)];
                    }
                    case 3:
                    {
                        string[] frasesBrincar = new string[] {
                        "Você é tão divertido! Obrigado por brincar comigo!",
                        "Você me faz rir muito! Muito obrigado pela diversão!",
                        "Eu adoro brincar com você! Você é muito animado!",
                        "Você me deixa tão feliz! Obrigado por passar tempo comigo!",
                        "Eu me diverti muito com você! Você é muito criativo!",
                        "Você é o melhor amigo do mundo! Obrigado por brincar comigo!",
                        "Que brincadeira legal! Você me surpreendeu!",
                        "Você é muito inteligente! Obrigado por me ensinar coisas novas!",
                        "Você me faz sentir especial! Obrigado por brincar comigo!",
                        "Você é muito gentil! Obrigado por me dar atenção!"
                    };
                        return frasesBrincar[random.Next(frasesBrincar.Length)];
                    }
            }

            return "Estou confuso...";
        }
    }


}
