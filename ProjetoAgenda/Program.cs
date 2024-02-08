using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    internal class Program
    {
        static Contact AdicionarContato()
        {
            Console.WriteLine("Qual o nome do contato?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o email do contato?");
            string email = Console.ReadLine();
            return new Contact(nome, email);
        }
        static void AlterarContato()
        {
            Console.Clear();
            Console.WriteLine("Carregando lista de contatos... (aperte novamente para continuar)\n");
            MostrarContato();
            Console.WriteLine("\nQual ID do contato que deseja alterar?");
            int id = Convert.ToInt32(Console.ReadLine());
            if (listaContatos.Count > id)
            {
                Console.WriteLine("Qual sera o novo nome?");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual sera o novo email?");
                string email = Console.ReadLine();
                listaContatos[id] = new Contact(nome, email);
            } else
            {
                Console.WriteLine("O id apresentado não é válido.");
                Console.ReadKey();
            }
        }
        static void ExcluirContato()
        {
            Console.Clear();
            Console.WriteLine("Carregando lista de contatos... (aperte novamente para continuar)\n");
            MostrarContato();
            Console.WriteLine("Qual ID do contato que deseja excluir?");
            int id = Convert.ToInt32(Console.ReadLine());

            if (listaContatos.Count() > id)
            {
                listaContatos.RemoveAt(id);
            }
            else
            {
                Console.WriteLine("O id apresentado não é válido.");
                Console.ReadKey();
            }
        }
        static void MostrarContato()
        {
            if (listaContatos.Count == 0)
            {
                Console.WriteLine("A lista esta vazia");
            }

            foreach (Contact c in listaContatos)
            {
                if (listaContatos[posLista] != null)
                {
                    Console.WriteLine("ID: {0} - Nome: {1} - Email: {2}", posLista, c.getNome(), c.getEmail());
                    posLista++;
                }
            }
            Console.ReadKey();
            posLista = 0;
        }

        static void LocalizarContatoEmail()
        {
            if (listaContatos.Count > 0)
            {
                Console.WriteLine("Qual o email que deseja procurar? ");
                string email = Console.ReadLine();

                foreach (Contact c in listaContatos)
                {
                    if (!string.IsNullOrEmpty(c.getEmail()))
                    {
                        if (c.getEmail().Contains(email))
                        {
                            Console.WriteLine("nome: {0} - email: {1}", c.getNome() , email);
                            
                        }
                    }
                }
                Console.ReadKey();
            }            
        }

        static int ExibirMenu()
        {
            int op = 0;
            Console.Clear();
            Console.WriteLine("Agenda Modo Console");
            Console.WriteLine("Exibir dados - 1");
            Console.WriteLine("Inserir contato - 2");
            Console.WriteLine("Alterar contato - 3");
            Console.WriteLine("Excluir contato - 4");
            Console.WriteLine("Localizar contato - 5");
            Console.WriteLine("Sair - 6");
            Console.Write("Opção: ");
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
            } catch {
                op = 0;
            }
            return op;
        }
        
        static List<Contact> listaContatos = new List<Contact>();
        static int posLista = 0;


        static void Main(string[] args)
        {
            int op = 0;
            if (File.Exists("dados.txt"))
            {
                listaContatos = BackupAgenda.RestaurarDados("dados.txt");
            }

        while (op != 6)
            {
                op = ExibirMenu();
                switch (op)
                {
                    case 1:
                        MostrarContato();
                        break;
                    case 2:
                        listaContatos.Add(AdicionarContato());
                        break;
                    case 3:
                        AlterarContato();
                        break;
                    case 4:
                        ExcluirContato();
                        break;
                    case 5:
                        LocalizarContatoEmail();
                        break;
                    case 0:
                        break;
                }
            }
            BackupAgenda.SalvarDados(listaContatos, "dados.txt");
        }
    }
}
