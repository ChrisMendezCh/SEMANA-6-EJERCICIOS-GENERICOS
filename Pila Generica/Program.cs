using System;
using System.Collections.Generic;

public class PilaGenerica<T>
{
    private Stack<T> pila = new Stack<T>();

    public void Apilar(T item)
    {
        pila.Push(item);
        Console.WriteLine($"Elemento '{item}' apilado.");
    }

    public void Desapilar()
    {
        if (pila.Count > 0)
        {
            var elemento = pila.Pop();
            Console.WriteLine($"Elemento '{elemento}' desapilado.");
        }
        else
        {
            Console.WriteLine("La pila está vacía. No se puede desapilar.");
        }
    }

    public void MostrarCima()
    {
        if (pila.Count > 0)
        {
            var cima = pila.Peek();
            Console.WriteLine($"Elemento en la cima: '{cima}'");
        }
        else
        {
            Console.WriteLine("La pila está vacía. No hay elementos en la cima.");
        }
    }

    public void MostrarElementos()
    {
        if (pila.Count > 0)
        {
            Console.WriteLine("Elementos en la pila:");
            foreach (var item in pila)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("La pila está vacía.");
        }
    }
}

internal class Program
{
    private static void Main()
    {
        PilaGenerica<int> pilaEnteros = new PilaGenerica<int>();

        // Operaciones sobre la pila
        pilaEnteros.Apilar(10);
        pilaEnteros.Apilar(20);
        pilaEnteros.Apilar(30);
        pilaEnteros.MostrarElementos();

        pilaEnteros.MostrarCima();

        pilaEnteros.Desapilar();
        pilaEnteros.MostrarElementos();

        // Pausa la consola para ver los resultados
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}