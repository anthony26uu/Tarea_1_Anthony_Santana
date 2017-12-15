using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPerfecto
{
    public class FuncionNumero
    {
        public void Funcion()
        {
            int suma = 0;
            Console.WriteLine("Digite un numero entero positivo: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    suma = suma + i;
                }
            }
            if (suma == num)
            {
                Console.WriteLine("El numero es perfecto");
            }
            else
            {
                Console.WriteLine("El numero no es perfecto");
            }
            Console.ReadKey();
        }
    }
}
