using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ClasesFigurasGeometricas
{
 public static   class LlamadaDeFunciones
    {
        public static void llamarFunacions()
        {
            Circulo c = new Circulo();
            Console.WriteLine(c.CalcularArea(5));
            Cuadrado cu = new Cuadrado();
            Console.WriteLine(cu.CalcularArea(5));
            Rectangulo r = new Rectangulo();
            Console.WriteLine(r.CalcularArea(5, 5));
            Triangulo t = new Triangulo();
            Console.WriteLine(t.CalcularArea(4, 5));
            Console.ReadKey();
        }
    }
}
