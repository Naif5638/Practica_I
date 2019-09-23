using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldSalario, pIncremento, newSalario;
            Console.WriteLine("Programa que calcula el nuevo salario");
            Console.Write("Ingrese el salario anterior: ");
            oldSalario = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el porciento incrementado al salario: ");
            pIncremento= double.Parse(Console.ReadLine());

            newSalario = oldSalario * (1 + (pIncremento / 100));

            Console.WriteLine("Gracias al aumento del {0}% su nuevo salario es {1}", 
                pIncremento, 
                newSalario);

            Console.ReadKey();
        }
    }
}
