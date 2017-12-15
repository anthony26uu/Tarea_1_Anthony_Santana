using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFigurasGeometricas
{
    class Cuadrado
    {
        public int Lado { get; set; }

        public Cuadrado()
        {

        }
        public Cuadrado(int lado)
        {
            this.Lado = lado;
        }

        public double CalcularArea(int lado)
        {
            double area = 0;            
            area = lado * lado;
            return area;
        }
    }
}
