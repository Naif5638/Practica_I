using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            double cPesos, vDolar;
            Console.WriteLine("Programa que imprime el cambio de dolares a pesos");
            Console.Write("Ingrese el cantidad en pesos: ");
            cPesos = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del dolar: ");
            vDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("La equivalencia en dolares es igual a {0:C2}", cPesos*vDolar);

            Console.ReadKey();

        }
    }
}
