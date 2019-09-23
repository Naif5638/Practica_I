using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_V
{
    class Program
    {
        static void Main(string[] args)
        {
            double cHombre, cMujeres, cEstudiantes;
            Console.WriteLine("Programa que calcula el porcentaje de estudiantes hombre y mujeres");
            Console.Write("Ingrese la cantidad de estudiantes hombres: ");
            cHombre = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantida de estudiantes mujeres: ");
            cMujeres = double.Parse(Console.ReadLine());

            cEstudiantes = cHombre + cMujeres;

            Console.WriteLine("El porcentaje de estudiantes hombres es de un {0}% y el de mujeres de un {1}%",
                Math.Round((cHombre * 100)/cEstudiantes, 2),
                Math.Round((cMujeres * 100)/cEstudiantes,2));

            Console.ReadKey();
        }
    }
}
