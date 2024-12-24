using System;
using System.Collections.Generic;

public class DiccionarioGenerico<TKey, TValue>
{
    private Dictionary<TKey, TValue> diccionario = new Dictionary<TKey, TValue>();

    public void Agregar(TKey clave, TValue valor)
    {
        if (!diccionario.ContainsKey(clave))
        {
            diccionario.Add(clave, valor);
            Console.WriteLine($"Elemento agregado: [{clave}] = {valor}");
        }
        else
        {
            Console.WriteLine($"La clave '{clave}' ya existe en el diccionario.");
        }
    }

    public void Eliminar(TKey clave)
    {
        if (diccionario.Remove(clave))
        {
            Console.WriteLine($"Elemento con clave '{clave}' eliminado.");
        }
        else
        {
            Console.WriteLine($"La clave '{clave}' no existe en el diccionario.");
        }
    }

    public void MostrarElementos()
    {
        if (diccionario.Count > 0)
        {
            Console.WriteLine("Elementos en el diccionario:");
            foreach (var elemento in diccionario)
            {
                Console.WriteLine($"[{elemento.Key}] = {elemento.Value}");
            }
        }
        else
        {
            Console.WriteLine("El diccionario está vacío.");
        }
    }
}

internal class Program
{
    private static void Main()
    {
        DiccionarioGenerico<int, string> diccionario = new DiccionarioGenerico<int, string>();

        // Agregar elementos al diccionario
        diccionario.Agregar(1, "Manzana");
        diccionario.Agregar(2, "Banana");
        diccionario.Agregar(3, "Cereza");

        // Mostrar elementos
        diccionario.MostrarElementos();

        // Eliminar un elemento
        diccionario.Eliminar(2);

        // Mostrar elementos después de eliminar
        diccionario.MostrarElementos();

        // Pausa la consola para ver los resultados
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}