using System;
using System.Collections.Generic;

public class MiLista<T>
{
    private List<T> elementos = new List<T>();

    public void Agregar(T item)
    {
        elementos.Add(item);
        Console.WriteLine($"Elemento '{item}' agregado.");
    }

    public void Eliminar(T item)
    {
        if (elementos.Remove(item))
        {
            Console.WriteLine($"Elemento '{item}' eliminado.");
        }
        else
        {
            Console.WriteLine($"Elemento '{item}' no encontrado.");
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("Elementos en la lista:");
        foreach (var item in elementos)
        {
            Console.WriteLine(item);
        }
    }
}

internal class Program
{
    private static void Main()
    {
        MiLista<int> listaEnteros = new MiLista<int>();
        listaEnteros.Agregar(10);
        listaEnteros.Agregar(20);
        listaEnteros.Mostrar();
        listaEnteros.Eliminar(10);
        listaEnteros.Mostrar();

        // Pausa la consola para ver los resultados
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}