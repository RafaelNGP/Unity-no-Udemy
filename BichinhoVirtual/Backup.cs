using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BichinhoVirtual
{
    internal class Backup
    {
        public static void SalvarDados(Bichinho pet)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream("dados", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, pet);
            }
        }

        public static Bichinho CarregarDados()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("dados", FileMode.Open, FileAccess.Read))
            {
                try
                {
                    Bichinho carregado = (Bichinho)formatter.Deserialize(stream);
                    return carregado;
                } catch (Exception ex)
                {   
                    Console.WriteLine("Falha ao carregar o arquivo.");
                    Console.WriteLine(ex.Message);
                } 
                return null;
            }
        }
    }
}