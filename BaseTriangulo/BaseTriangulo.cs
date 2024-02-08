using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramação
{
    internal class BaseTriangulo
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double h = 0;

            Console.WriteLine("Area do triangulo?");
            Console.WriteLine("Qual a base do triangulo?");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a altura do triangulo?");
            h = Convert.ToDouble(Console.ReadLine());

            a = (b * h) / 2;
            Console.WriteLine("A area do triangulo apresentado eh de {0}", a);
            Console.ReadKey();
        }
    }
}
