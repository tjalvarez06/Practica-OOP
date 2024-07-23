using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica_OOP.Class
{
    public class Estudiante : Persona
    {
        private string carrera;
        private string matricula;
       
    
        public Estudiante(string nombre, string fechaNacimiento, string ciudad, string carrera, string matricula)
            : base (nombre, fechaNacimiento, ciudad)
        {
            
            this.carrera = carrera;
            this.matricula = matricula;
          
        }
    
        public void InformacionEstudiante()
        {
            InformacionPersona();
            Console.WriteLine($"Esta estudiando la carrera {carrera} y su matricula es {matricula}");
        }
    }
}
