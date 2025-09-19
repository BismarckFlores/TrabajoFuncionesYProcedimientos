using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFuncionesYProcedimientos
{
    internal class Program
    {
        // Ejercicios 1 y 3
        static double CalcularAreaTriangulo(double baseT, double altura)
        {
            double area = (baseT * altura) / 2;
            return area;
        }

        static int VerificaciónNumPar(int num)
        {
            if (num % 2 == 0)
            {
                return 1; // El número es par
            }
            else
            {
                return 0; // El número es impar
            }
        }
    }
}
