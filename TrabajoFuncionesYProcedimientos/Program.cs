using System;

namespace TrabajoFuncionesYProcedimientos
{
    internal class Program
    {
        // Método para intercambiar dos valores usando ref
        static void Intercambiar(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Procedimiento para calcular subtotal, IVA y total
        static void CalcularIVAyTotal(int cantidad, decimal precioUnitario)
        {
            decimal subtotal = cantidad * precioUnitario;
            decimal iva = subtotal * 0.15m;   // IVA del 15%
            decimal total = subtotal + iva;

            Console.WriteLine($"\nCantidad: {cantidad}");
            Console.WriteLine($"Precio unitario: {precioUnitario:F2}");
            Console.WriteLine($"Subtotal: {subtotal:F2}");
            Console.WriteLine($"IVA (15%): {iva:F2}");
            Console.WriteLine($"Total a pagar: {total:F2}");
        }
    }
}



