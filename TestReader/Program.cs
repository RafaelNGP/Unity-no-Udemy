using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // determinando o arquivo a ser aberto
            string arquivo = args[0]; 
            string line = "";
            try
            {
                StreamReader sr = new StreamReader(arquivo);
                line = sr.ReadLine();
                while (line != null )
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            } catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally { Console.WriteLine("Executing finnaly block"); 
            }
        }
    }
}
