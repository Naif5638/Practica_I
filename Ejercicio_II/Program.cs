using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double masa, presion, volumen, temperatura;
            Console.WriteLine("Programa que calcula la masa del aire");
            Console.Write("Introduzca la presión: ");
            presion = double.Parse(Console.ReadLine());
            Console.Write("Introduzca el volumen: ");
            volumen = double.Parse(Console.ReadLine());
            Console.Write("Introduzca la temperatura: ");
            temperatura = double.Parse(Console.ReadLine());

            masa = (presion * volumen) / (0.37 * (temperatura + 460));
            Console.WriteLine("La masa del aire es igual a {0}", masa);
            Console.ReadKey();
        }
    }
}
