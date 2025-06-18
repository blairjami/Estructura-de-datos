using System;

namespace AgendaTelefonica
{
    class Program
    {
        // Definimos la estructura para los contactos
        struct Contacto
        {
            public string Nombre;
            public string Telefono;
            public string Correo;
        }

        static void Main(string[] args)
        {
            const int maxContactos = 100;
            Contacto[] agenda = new Contacto[maxContactos];
            int totalContactos = 0;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== AGENDA TELEFÓNICA ===");
                Console.WriteLine("1. Agregar nuevo contacto");
                Console.WriteLine("2. Mostrar todos los contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (totalContactos < maxContactos)
                        {
                            Console.WriteLine("\n--- Nuevo Contacto ---");
                            Console.Write("Nombre: ");
                            agenda[totalContactos].Nombre = Console.ReadLine();
                            Console.Write("Teléfono: ");
                            agenda[totalContactos].Telefono = Console.ReadLine();
                            Console.Write("Correo: ");
                            agenda[totalContactos].Correo = Console.ReadLine();

                            totalContactos++;
                            Console.WriteLine("\nContacto agregado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("La agenda está llena.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- Lista de Contactos ---");
                        if (totalContactos == 0)
                        {
                            Console.WriteLine("No hay contactos registrados.");
                        }
                        else
                        {
                            for (int i = 0; i < totalContactos; i++)
                            {
                                Console.WriteLine($"\nContacto #{i + 1}");
                                Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                                Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                                Console.WriteLine($"Correo: {agenda[i].Correo}");
                            }
                        }
                        break;

                    case 3:
                        Console.Write("\nIngrese el nombre o teléfono a buscar: ");
                        string busqueda = Console.ReadLine();
                        bool encontrado = false;

                        for (int i = 0; i < totalContactos; i++)
                        {
                            if (agenda[i].Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                                agenda[i].Telefono.Contains(busqueda))
                            {
                                Console.WriteLine($"\nContacto encontrado:");
                                Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                                Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                                Console.WriteLine($"Correo: {agenda[i].Correo}");
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se encontró el contacto.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }
    }
}
