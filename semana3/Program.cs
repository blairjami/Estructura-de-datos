﻿using System;

namespace RegistroEstudiante
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }

        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] telefonos = new string[3];
            telefonos[0] = "0991234567";
            telefonos[1] = "0987654321";
            telefonos[2] = "022345678";

            Estudiante estudiante = new Estudiante(
                1,
                "Cristopher Blair",
                "Jami Sambachi",
                "Quito, Ecuador",
                telefonos
            );

            estudiante.MostrarDatos();
            Console.ReadKey();
        }
    }
}
