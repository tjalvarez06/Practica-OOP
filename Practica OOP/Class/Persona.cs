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
    public DateTime fechaNacimiento;
    public string ciudad;

    public Persona(string nombre, string fechaNacimiento, string ciudad)
    {
        this.nombre = nombre;
        this.fechaNacimiento = DateTime.Parse(fechaNacimiento);
        this.ciudad = ciudad;
    }

    public int CalcEdad()
    {
        int edad = DateTime.Now.Year - fechaNacimiento.Year;
        return edad;
    }
    public void InformacionPersona()
    {
        Console.WriteLine($"Su nombre es {nombre}, vive en {ciudad} y tiene {CalcEdad()} años de edad ");
    }
}
}
