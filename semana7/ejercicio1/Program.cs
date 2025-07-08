using System;
using System.Collections.Generic;

class BalanceChecker
{
    /// <summary>
    /// Verifica si una expresión tiene paréntesis, llaves y corchetes balanceados.
    /// </summary>
    public static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Si es un símbolo de apertura, lo apilamos
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es un símbolo de cierre, verificamos si coincide con el del tope
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char tope = pila.Pop();
                if ((c == ')' && tope != '(') ||
                    (c == '}' && tope != '{') ||
                    (c == ']' && tope != '['))
                {
                    return false;
                }
            }
        }

        // Al final, la pila debe estar vacía si todo está balanceado
        return pila.Count == 0;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese una expresión:");
        string expresion = Console.ReadLine();

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}
