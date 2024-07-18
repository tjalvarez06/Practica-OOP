using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP.Class
{
    public class Triangulo : Figura
    {
        public double baseTriangulo;
        public double alto;

        public Triangulo(double baseTriangulo, double alto)
        {
            this.baseTriangulo = baseTriangulo;
            this.alto = alto;
        }

        public override double CalcularArea()
        {
            double Restriangulo = baseTriangulo * alto / 2;
            return Restriangulo;
        }
    }
}
