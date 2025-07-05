using System;

class Nodo
{
    public int dato;
    public Nodo siguiente;

    public Nodo(int dato)
    {
        this.dato = dato;
        this.siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    public void AgregarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo temp = cabeza;
            while (temp.siguiente != null)
                temp = temp.siguiente;
            temp.siguiente = nuevo;
        }
    }

    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.siguiente;
            actual.siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }
        cabeza = anterior;
    }

    public void Mostrar()
    {
        Nodo temp = cabeza;
        while (temp != null)
        {
            Console.Write(temp.dato + " ");
            temp = temp.siguiente;
        }
        Console.WriteLine();
    }
}

class Programa
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.AgregarFinal(10);
        lista.AgregarFinal(20);
        lista.AgregarFinal(30);
        lista.AgregarFinal(40);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}
