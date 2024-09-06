using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeColecciones
{
    class Colecciones
    {
        static void Main(string[] args)
        {
            // Declaración de un arreglo
            int[] numeros = new int[5]; // Arreglo 5 elementos
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;
            // longitud del arreglo es fija y en este caso es 5
            // numeros[5] = 10; // Error, el arreglo solo tiene 5 elementos

            // for loop "for tradicional"
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            // foreach
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Declaración de una lista son colecciones dinámicas
            List<string> nombres = new List<string>();
            // agregar elementos a la lista
            nombres.Add("Sofia");
            nombres.Add("Catalina");
            nombres.Add("Juan");
            nombres.Add("Pedro");
            nombres.Add("Maria");
            nombres.Add("Margarita");
            nombres.Add("Alfredo");
            // nombres.Add(10); // Error, la lista solo acepta strings

            // foreach
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            List<int> edades = new List<int>();
            edades.Add(20);
            edades.Add(30);
            edades.Add(40);
            // edades.Add("Selenium"); // Error, la lista solo acepta enteros

            foreach (int edad in edades)
            {
                Console.WriteLine(edad);
            }

            // Diccionarios son colecciones de llave-valor
            Dictionary<string, string> paises = new Dictionary<string, string>();
            paises.Add("MX", "México");
            paises.Add("CL", "Chile");
            paises.Add("CO", "Colombia");
            paises.Add("AR", "Argentina");
            paises.Add("PE", "Perú");
            // paises.Add("PE", "Perú"); // Error, la llave ya existe
            paises.Add("BR", "Brasil");
            // paises.Add("BR", "Brasil"); // Error, la llave ya existe
            // Acceder a un valor
            Console.WriteLine(paises["MX"]); // imprimirá México
            Console.WriteLine(paises["CL"]); // imprimirá Chile
            Console.WriteLine(paises["AR"]); // imprimirá Argentina


            Dictionary<string, int> calificaciones = new Dictionary<string, int>();
            calificaciones.Add("Sofia", 60);
            calificaciones.Add("Catalina", 70);
            calificaciones.Add("Juan", 50);
            calificaciones.Add("Pedro", 70);

            Console.WriteLine(calificaciones["Sofia"]); // imprimirá 60
            Console.WriteLine(calificaciones["Catalina"]); // imprimirá 70

            // foreach
            foreach (KeyValuePair<string, int> calificacion in calificaciones)
            {
                Console.WriteLine($"Nombre: {calificacion.Key}, Calificación: {calificacion.Value}");
            }
        }
    }
}
