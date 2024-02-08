using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyUnity
{
    internal class Tabuada
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int n = 0;

            Console.WriteLine("Tabuada de um número");
            Console.Write("Informe um número: ");

            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);

            Multiplicar(n);
        }

        static void Multiplicar(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1} = {2}", n, i, (n * i));
            }
            Console.ReadKey();
        }
    }
}
