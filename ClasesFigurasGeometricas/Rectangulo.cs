using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFigurasGeometricas
{
    class Rectangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Rectangulo()
        {

        }
        public Rectangulo(int bas,int alt)
        {
            this.Base = bas;
            this.Altura = alt;
        }

        public double CalcularArea(int bas, int alt)
        {
            double area = 0;
            area = bas *alt;
            return area;
        }
    }
}
