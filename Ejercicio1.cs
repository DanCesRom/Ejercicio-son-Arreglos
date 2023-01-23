// Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.

using System;

class Add
{
  static void Main(string[] args)
  {
    List<int> lista = new List<int> {};

    for (int x = 0; x <= 9; x++)
    {
        Console.Clear();
        Console.WriteLine("Elige el " + (x+1) + " numero: ");
        lista.Add(Convert.ToInt32(Console.ReadLine()));
    }
    Console.Clear();
    Console.WriteLine("El numero mas alto es el " + lista.Max() + " y se encuentra en la posicion: " +(lista.IndexOf(lista.Max())+1));
  }
}
