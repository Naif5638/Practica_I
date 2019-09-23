using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado;
            Console.WriteLine("Programa que pide el lado de un Cuadrado y muestra el perimetro");
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine("El perimetros es igual a {0}", lado * 4);
            Console.ReadKey();

        }
    }
}
