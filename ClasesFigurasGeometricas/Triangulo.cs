using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFigurasGeometricas
{
    class Triangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Triangulo()
        {

        }

        public Triangulo(int bas, int alt)
        {
            this.Base = bas;
            this.Altura = alt;
        }

        public double CalcularArea(int bas, int alt)
        {
            double area = 0;
            area = bas * alt/2;
            return area;
        }
    }
}
