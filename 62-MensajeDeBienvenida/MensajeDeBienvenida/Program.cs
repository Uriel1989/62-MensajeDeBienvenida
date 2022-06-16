using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MensajeDeBienvenida
{
    class Program
    {
        static void Main(string[] args)
        {
            MensajeDeBienvenida Extrangero = new MensajeDeBienvenida();

            Console.CursorLeft = 30;
            Console.WriteLine("Ingrese el nombre de una personas y de una ciudad:");
            string Nombre = Convert.ToString(Console.ReadLine());
            string Ciudad = Convert.ToString(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Hola " + Extrangero.NombreDeCiudad(Nombre)+"," + " bienvenido a " + Extrangero.NombreDeCiudad(Ciudad));

            Console.ReadKey();
        }
    }
}
