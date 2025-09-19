using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFuncionesYProcedimientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        // Ejercicio 4
        public static int NumeroDeVocales(string cadena)
        {
            // Contador de vocales
            int contador = 0;

            // Definición de vocales a considerar
            string vocales = "aeiouAEIOU";

            // Recorremos cada carácter de la cadena
            foreach (char c in cadena)
            {
                if (vocales.Contains(c))
                {
                    // Si el carácter es una vocal, incrementamos el contador
                    contador++;
                }
            }

            // Devolvemos el número total de vocales encontradas
            return contador;
        }

        // Ejercicio 10
        // Procedimiento para validar la cantidad de clientes
        public static void validarCantidadClientes(out int cantidadClientes)
        {
            // Validamos que la cantidad de clientes sea mayor a 0
            do
            {
                Console.WriteLine("\nDigite la cantidad de clientes atendidos en el día (debe ser mayor a 0):");
                cantidadClientes = Convert.ToInt32(Console.ReadLine());
            } while (cantidadClientes <= 0);
        }
        // Función para validar el monto de venta
        public static double validarMontoVenta()
        {
            double montoVenta;
            do
            {
                // Validamos que el monto de venta sea mayor a 0
                montoVenta = Convert.ToDouble(Console.ReadLine());
            } while (montoVenta <= 0);
            return montoVenta;
        }
        // Función para calcular las ventas del día
        public static double VentasDelDia(int cantidadClientes)
        {
            double totalVentas = 0;

            // Recorremos la cantidad de clientes para registrar sus ventas
            for (int i = 0; i < cantidadClientes; i++)
            {
                Console.WriteLine($"\nDigite el monto de la venta del cliente {i + 1} (debe ser mayor a 0):");
                // Sumamos el monto validado al total de ventas
                totalVentas += validarMontoVenta();
            }
            return totalVentas;
        }
    }
}
