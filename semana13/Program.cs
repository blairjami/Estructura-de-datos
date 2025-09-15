using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Lista que contendrá los títulos de las revistas
        static List<string> catalogo = new List<string>();

        static void Main(string[] args)
        {
            // Agregar al menos 10 títulos al catálogo
            catalogo.Add("National Geographic");
            catalogo.Add("Time");
            catalogo.Add("Forbes");
            catalogo.Add("Nature");
            catalogo.Add("Science");
            catalogo.Add("Sports Illustrated");
            catalogo.Add("Vogue");
            catalogo.Add("People");
            catalogo.Add("Wired");
            catalogo.Add("Reader's Digest");

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Catálogo de Revistas ===");
                Console.WriteLine("1. Buscar revista por título");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        BuscarRevista();
                        break;
                    case 2:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 2);
        }

        // Método para buscar revista en el catálogo
        static void BuscarRevista()
        {
            Console.Write("\nIngrese el título de la revista que desea buscar: ");
            string titulo = Console.ReadLine();

            // Usamos búsqueda iterativa
            bool encontrado = false;
            foreach (string revista in catalogo)
            {
                if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                Console.WriteLine("\nResultado: Encontrado");
            else
                Console.WriteLine("\nResultado: No encontrado");

            Console.WriteLine("\nPresione Enter para volver al menú...");
            Console.ReadLine();
        }
    }
}

