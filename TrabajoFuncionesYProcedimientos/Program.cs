using System;

namespace TrabajoFuncionesYProcedimientos
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            bool programaCorriendo = true;
            do 
            {
                Console.WriteLine("Porfavor seleccione el ejercicio que desea ejecutar (1-6):");
                Console.WriteLine("\n---Demostración Práctica | Declarar y definir subprogramas en C#---");
                Console.WriteLine("1. Calcular el área de un triángulo.");
                Console.WriteLine("2. Intercambiar dos valores.");
                Console.WriteLine("3. Verificar si un número es par o impar.");
                Console.WriteLine("4. Calcular subtotal, IVA y total a pagar.");
                Console.WriteLine("\n---Lista de ejercicios: Funciones y Procedimientos en C#---");
                Console.WriteLine("5. Contar el número de vocales en una cadena.");
                Console.WriteLine("6. Calcular las ventas del día para una tienda.");
                Console.WriteLine("\n0. Salir del programa.");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ejercicio 1: Calcular el área de un triángulo.");
                        Console.WriteLine("Ingrese la base del triángulo:");
                        double baseT = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del triángulo:");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del triángulo es: {CalcularAreaTriangulo(baseT, altura)}");
                        break;
                    case 2:
                        Console.WriteLine("Ejercicio 2: Intercambiar dos valores.");
                        Console.WriteLine("Ingrese el primer valor (x):");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor (y):");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Intercambiar(ref x, ref y);
                        Console.WriteLine($"Después del intercambio: x = {x}, y = {y}");
                        break;
                    case 3:
                        Console.WriteLine("Ejercicio 3: Verificar si un número es par o impar.");
                        Console.WriteLine("Ingrese un número:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int resultado = VerificaciónNumPar(num);
                        if (resultado == 1)
                        {
                            Console.WriteLine($"El número {num} es par.");
                        }
                        else
                        {
                            Console.WriteLine($"El número {num} es impar.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ejercicio 4: Calcular subtotal, IVA y total a pagar.");
                        Console.WriteLine("Ingrese la cantidad de productos:");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el precio unitario del producto:");
                        decimal precioUnitario = Convert.ToDecimal(Console.ReadLine());
                        CalcularIVAyTotal(cantidad, precioUnitario);
                        break;
                    case 5:
                        Console.WriteLine("Ejercicio 5: Contar el número de vocales en una cadena.");
                        Console.WriteLine("Ingrese una cadena de texto:");
                        string cadena = Console.ReadLine();
                        int numVocales = NumeroDeVocales(cadena);
                        Console.WriteLine($"El número de vocales en la cadena es: {numVocales}");
                        break;
                    case 6:
                        Console.WriteLine("Ejercicio 6: Calcular las ventas del día para una tienda.");
                        validarCantidadClientes(out int cantidadClientes);
                        double totalVentas = VentasDelDia(cantidadClientes);
                        Console.WriteLine($"\nEl total de ventas del día es: {totalVentas:F2}");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        programaCorriendo = false;
                        break;
                }
            } while (programaCorriendo);
        }
      
        // Demostración Práctica | Declarar y definir subprogramas en C#
        // Ejercicios 1
        static double CalcularAreaTriangulo(double baseT, double altura)
        {
            double area = (baseT * altura) / 2;
            return area;
        }
        
        // Ejercicio 2
        // Método para intercambiar dos valores usando ref
        static void Intercambiar(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Ejercicio 3
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

        // Ejercicio 4
        // Procedimiento para calcular subtotal, IVA y total
        public static void CalcularIVAyTotal(int cantidad, decimal precioUnitario)
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

        // Lista de ejercicios: Funciones y Procedimientos en C#
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
                if (vocales.Contains(c.ToString()))
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



