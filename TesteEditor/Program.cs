using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TesteEditor
{
    internal class Program
    {
        static void ExibirTexto(string arquivo)
        {
            try
            {
                string line = "";
                StreamReader sr = new StreamReader(arquivo);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            Console.ReadLine();
        }

        static void GravarTexto(string arquivo, string texto, bool incremento)
        {
            try
            {
                StreamWriter sr = new StreamWriter(arquivo, incremento);
                sr.WriteLine(texto);
                sr.Close();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        static int ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Editor de texto");
            Console.WriteLine("Abrir um arquivo (1)");
            Console.WriteLine("Exibir texto do arquivo (2)");
            Console.WriteLine("Gravar um texto no arquivo (3)");
            Console.WriteLine("Gravar um novo texto no arquivo (4)");
            Console.WriteLine("Sair (5)");
            Console.Write("Opcao:");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            // abrir um arquivo
            // exibir o texto
            // editar o texto ou criar texto do zero

            int op = 0;
            string arquivo = "";
            string texto = "";

            while (op != 5) 
            {
                op = ExibirMenu();

                switch (op)
                {
                    case 1: 
                        Console.Write("Informe o nome do arquivo: ");
                        arquivo = Console.ReadLine();
                        break; 
                    case 2: 
                        ExibirTexto(arquivo);
                        break;
                    case 3:
                        Console.Write("Informe o texto: ");
                        texto = Console.ReadLine();
                        GravarTexto(arquivo, texto, false);
                        break;
                    case 4:
                        Console.Write("Informe o texto: ");
                        texto = Console.ReadLine();
                        GravarTexto(arquivo, texto, true);
                        break;
                }
            }
        }
    }
}
