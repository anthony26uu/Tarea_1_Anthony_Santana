using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares
{
    public class FuncionNumerosPares
    {
        public void Funcion()
        {

            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
