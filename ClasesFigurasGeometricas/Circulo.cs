using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFigurasGeometricas
{
    class Circulo
    {
        
        public int Radio { get; set; }

        public Circulo()
        {

        }

        public Circulo(int radio)
        {
            this.Radio = radio;
        }        

        public double CalcularArea(int radio)
        {
            double area = 0;            
            const double Pi = 3.14159;
            area = Pi * (radio * radio);
            return area;
        }
    }
}
