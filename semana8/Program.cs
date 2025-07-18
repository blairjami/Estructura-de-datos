using System;
using System.Collections.Generic;

namespace NavegadorWeb
{
    class Navegador
    {
        private Stack<string> historial;

        public Navegador()
        {
            historial = new Stack<string>();
        }

        public void VisitarPagina(string url)
        {
            historial.Push(url);
            Console.WriteLine($"Visitando: {url}");
        }

        public void Retroceder()
        {
            if (historial.Count <= 1)
            {
                Console.WriteLine("No hay páginas anteriores para retroceder.");
                return;
            }

            historial.Pop();
            Console.WriteLine($"Retrocediendo a: {historial.Peek()}");
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("\n--- Historial Actual ---");
            foreach (string pagina in historial)
            {
                Console.WriteLine(pagina);
            }
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Navegador navegador = new Navegador();
            string entrada;

            Console.WriteLine("Simulación del botón 'Atrás' de un navegador web");

            while (true)
            {
                Console.WriteLine("\n1. Visitar página");
                Console.WriteLine("2. Retroceder");
                Console.WriteLine("3. Mostrar historial");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        Console.Write("Ingrese la URL: ");
                        string url = Console.ReadLine();
                        navegador.VisitarPagina(url);
                        break;

                    case "2":
                        navegador.Retroceder();
                        break;

                    case "3":
                        navegador.MostrarHistorial();
                        break;

                    case "4":
                        Console.WriteLine("Cerrando navegador...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
