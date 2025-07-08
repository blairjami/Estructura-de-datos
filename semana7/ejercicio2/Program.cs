using System;
using System.Collections.Generic;

class Torre
{
    public Stack<int> discos = new Stack<int>();
    public string nombre;

    public Torre(string nombre)
    {
        this.nombre = nombre;
    }

    public void MoverDiscoA(Torre destino)
    {
        int disco = discos.Pop();
        destino.discos.Push(disco);
        Console.WriteLine($"Mover disco {disco} desde {nombre} hacia {destino.nombre}");
    }
}

class TorresDeHanoi
{
    /// <summary>
    /// Resuelve el problema de las Torres de Hanoi con movimiento de discos entre torres.
    /// </summary>
    static void Resolver(int n, Torre origen, Torre auxiliar, Torre destino)
    {
        if (n > 0)
        {
            Resolver(n - 1, origen, destino, auxiliar);
            origen.MoverDiscoA(destino);
            Resolver(n - 1, auxiliar, origen, destino);
        }
    }

    static void Main()
    {
        int numDiscos = 3; // Puedes cambiar el número de discos
        Torre origen = new Torre("Origen");
        Torre auxiliar = new Torre("Auxiliar");
        Torre destino = new Torre("Destino");

        // Agregamos los discos en orden descendente (el mayor al fondo)
        for (int i = numDiscos; i >= 1; i--)
        {
            origen.discos.Push(i);
        }

        Resolver(numDiscos, origen, auxiliar, destino);
    }
}
