using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    // Internal significa que solo es accesible desde el mismo ensamblado
    // si quiero compartirlo con otros ensamblados debo usar public
    class EjemploExcepciones
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce el divisor"); // 10
                int divisor = int.Parse(Console.ReadLine()); // "10"
                // FormatException sirve para capturar errores de formato en la conversión de tipos de datos
                
                int resultado = Dividir(10, divisor);

                Console.WriteLine($"El resultado de la división es: {resultado}" );

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El valor introducido no es un número válido");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Error: No se puede dividir por cero");
            }
            finally
            {
                // finally siempre se ejecuta, haya o no haya excepción
               Console.WriteLine("Fin del programa");
            }
            // listado de excepciones en C#
            // https://docs.microsoft.com/es-es/dotnet/api/system.exception?view=net-5.0
        } // fin del método Main

        static int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
    } // fin de la clase EjemploExcepciones
}
