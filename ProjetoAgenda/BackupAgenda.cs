using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    internal class BackupAgenda
    {
        public static String nomeArquivo = "dados.txt";

        public static void SalvarDados(List<Contact> contacts, string nomeArquivo)
        {
            // Cria um objeto BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            // Cria um stream para escrever no arquivo
            using (FileStream stream = new FileStream(nomeArquivo, FileMode.Create, FileAccess.Write))
            {
                // Serializa a lista de contatos e escreve no stream
                formatter.Serialize(stream, contacts);
            }
        }

        // Método para carregar a lista de contatos de um arquivo de texto
        public static List<Contact> RestaurarDados(string fileName)
        {
            // Cria um objeto BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            // Cria um stream para ler do arquivo
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                // Desserializa o stream e converte em uma lista de contatos
                return (List<Contact>)formatter.Deserialize(stream);
            }
        }
    }
}
