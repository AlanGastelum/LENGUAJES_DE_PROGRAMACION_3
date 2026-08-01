using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables//
            string nombre;
            string edad;
            string fechaNac;
            string carrera;

            Console.WriteLine("Bienvenido a UMI/Universidad Coppel");
            Console.WriteLine("\nIngresa los datos que se te piden:");
            Console.WriteLine("\nNombre completo: ");
            nombre = Console.ReadLine();
            Console.WriteLine("\nEdad: ");
            edad = Console.ReadLine();
            Console.WriteLine("\nFecha de nacimiento (DD/MM/AAAA): ");
            fechaNac = Console.ReadLine();
            Console.WriteLine("\nCarrera a la que desea entrar: ");
            carrera = Console.ReadLine();

            Console.WriteLine("\n\nGracias " + nombre + " por formar parte de UMI/Universidad Coppel. \nBienvenid@ a la carrera de " + carrera + ".");
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.WriteLine("\nDatos ingresados: ");
            Console.WriteLine("Nombre: " + nombre + ".");
            Console.WriteLine("Edad: " + edad + ".");
            Console.WriteLine("Fecha de nacimiento: " + fechaNac + ".");
            Console.WriteLine("Carrera asignada: " + carrera + ".");
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
