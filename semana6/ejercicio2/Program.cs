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
            cabeza = nuevo;
        else
        {
            Nodo temp = cabeza;
            while (temp.siguiente != null)
                temp = temp.siguiente;
            temp.siguiente = nuevo;
        }
    }

    public void AgregarInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.siguiente = cabeza;
        cabeza = nuevo;
    }

    public int Contar()
    {
        int count = 0;
        Nodo temp = cabeza;
        while (temp != null)
        {
            count++;
            temp = temp.siguiente;
        }
        return count;
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
    static bool EsPrimo(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static bool EsArmstrong(int num)
    {
        int suma = 0;
        int temp = num;
        int digitos = num.ToString().Length;

        while (temp > 0)
        {
            int digito = temp % 10;
            suma += (int)Math.Pow(digito, digitos);
            temp /= 10;
        }
        return suma == num;
    }

    static void Main()
    {
        ListaEnlazada listaPrimos = new ListaEnlazada();
        ListaEnlazada listaArmstrong = new ListaEnlazada();

        int[] numeros = { 2, 3, 5, 7, 11, 13, 153, 370, 407, 9474 };

        foreach (int num in numeros)
        {
            if (EsPrimo(num))
                listaPrimos.AgregarFinal(num);
            if (EsArmstrong(num))
                listaArmstrong.AgregarInicio(num);
        }

        Console.WriteLine("Cantidad de números primos: " + listaPrimos.Contar());
        Console.WriteLine("Cantidad de números Armstrong: " + listaArmstrong.Contar());

        if (listaPrimos.Contar() > listaArmstrong.Contar())
            Console.WriteLine("La lista de números primos tiene más elementos.");
        else if (listaPrimos.Contar() < listaArmstrong.Contar())
            Console.WriteLine("La lista de números Armstrong tiene más elementos.");
        else
            Console.WriteLine("Ambas listas tienen la misma cantidad de elementos.");

        Console.WriteLine("Números primos:");
        listaPrimos.Mostrar();

        Console.WriteLine("Números Armstrong:");
        listaArmstrong.Mostrar();
    }
}
