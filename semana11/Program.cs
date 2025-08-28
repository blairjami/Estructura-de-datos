using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"ojo", "eye"}
    };

    static void Main()
    {
        int opcion = -1;
        while (opcion != 0)
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                TraducirFrase();
            }
            else if (opcion == 2)
            {
                AgregarPalabra();
            }
            else if (opcion == 0)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }

    static void TraducirFrase()
    {
        Console.WriteLine("Ingrese una frase en español:");
        string frase = Console.ReadLine().ToLower();
        string[] palabras = frase.Split(' ');
        string resultado = "";

        foreach (string p in palabras)
        {
            if (diccionario.ContainsKey(p))
            {
                resultado += diccionario[p] + " ";
            }
            else
            {
                resultado += p + " ";
            }
        }

        Console.WriteLine("Traducción: " + resultado);
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en español: ");
        string esp = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en inglés: ");
        string eng = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, eng);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("Esa palabra ya existe en el diccionario.");
        }
    }
}
