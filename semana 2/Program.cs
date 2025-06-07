using System;

// Clase para representar un círculo
class Circulo
{
    private double radio;

    // Constructor que recibe el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Calcula el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Calcula el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase para representar un rectángulo
class Rectangulo
{
    private double largo;
    private double ancho;

    // Constructor que recibe largo y ancho
    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    // Calcula el área del rectángulo
    public double CalcularArea()
    {
        return largo * ancho;
    }

    // Calcula el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (largo + ancho);
    }
}

class Program
{
    static void Main()
    {
        // Crear un círculo con radio 5
        Circulo c = new Circulo(5);
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        // Crear un rectángulo con largo 4 y ancho 6
        Rectangulo r = new Rectangulo(4, 6);
        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}
