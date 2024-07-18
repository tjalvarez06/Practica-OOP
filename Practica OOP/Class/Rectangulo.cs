using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP.Class
{
    public class Rectangulo : Figura
    {
        public double ancho;
        public double alto;

        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public override double CalcularArea()
        {
            double Resrectangulo = ancho * alto;
            return Resrectangulo;
        }
    }
}
