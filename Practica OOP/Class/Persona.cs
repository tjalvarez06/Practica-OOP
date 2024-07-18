using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP.Class
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string ciudad;

        public Persona(string nombre, int edad, string ciudad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
        }

        public void InformacionPersona()
        {
            Console.WriteLine($"Su nombre es {nombre}, vive en {ciudad} y tiene {edad} años de edad ");
        }
    }
}
