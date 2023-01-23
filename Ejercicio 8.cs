//Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números negativos hay.

using System;

class Add
{
  static void Main(string[] args)
  {
    List<int> lista = new List<int> {};
    int cant = 0;

    for (int x = 0; x <= 9; x++)
    {
        Console.Clear();
        Console.WriteLine("Elige el " + (x+1) + " numero: ");
        int y = Convert.ToInt32(Console.ReadLine());
        lista.Add(y);
        
        if (y<0)
        {
          cant++;
        }
        
    }

    Console.Clear();
    Console.WriteLine("La cantidad de numero negativo son: " + cant);
  

  } 
}