using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExcepcionesWhile
{
    class DivisorNegativoException: Exception
    {
        public DivisorNegativoException(string message) : base(message){ } // el base llama al constructor de la clase Padre
    }

    class ManejoExcepcionesWhile
    {
        static void Main(string[] args)
        {
            int divisor = 0;
            bool esValido = false;

            while (!esValido)
            {
                try
                {
                    
                    Console.WriteLine("Introduce el divisor");
                    string? input = Console.ReadLine(); // ? se usa para indicar que la variable puede ser nula

                    if(string.IsNullOrEmpty(input))
                    {
                        // throw es una palabra reservada que se usa para lanzar una excepción en C#
                        throw new ArgumentNullException("El valor introducido no puede ser nulo o vacío");
                        // mensaje personalizado de excepción

                    }

                    divisor = int.Parse(input);

                    if (divisor < 0)
                    {
                        // crear una propia excepcion
                        throw new DivisorNegativoException("El divisor no puede ser negativo");
                    }

                    int resultado = Dividir(10, divisor);
                    Console.WriteLine($"El resultado de la división es: {resultado}");
                    // si llega aquí es porque no ha habido excepción
                    esValido = true;

                }
                    catch (ArgumentNullException ex)
                    { 
                        Console.WriteLine(ex.Message);
                    }
                    catch(DivisorNegativoException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Error: El valor introducido no es un número válido");
                    }
                    catch(DivideByZeroException)
                    {
                        Console.WriteLine("Error: No se puede dividir por cero");
                    }
            }


       
        }

        static int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
    } // fin de la clase ManejoExcepcionesWhile
}
