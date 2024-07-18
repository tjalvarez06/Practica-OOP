using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP.Class
{
    public class Circulo : Figura
    {
        public double radio;
        

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            double Rescirculo = Math.PI * radio * radio;
            return Rescirculo;
        }
    }
}
