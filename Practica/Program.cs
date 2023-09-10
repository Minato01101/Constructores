using Practica.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona("Javier" , 20, "H");
            Persona persona3 = new Persona("Javier" , 20, "H", 40, 1.70);

            Console.WriteLine(persona1);
            Console.WriteLine(persona2);
            Console.WriteLine(persona3);
        }
    }
}
