//Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posiciones se encuentran los números con más de 3 dígitos

using System;

class Add
{
  static void Main(string[] args)
  {
    int[] lista = new int[10];

    List<int> posicion = new List<int> {};


    for (int x = 0; x <= 9; x++)
    {
      Console.Clear();
      Console.WriteLine("Elige el " + (x+1) + " numero: ");
      lista[x] = Convert.ToInt32(Console.ReadLine());
        
      if (lista[x]>=1000)
      {
        posicion.Add(x+1);
      }
    }

    Console.Clear();

    if (posicion.Count() > 0)
      {
        Console.WriteLine("Los numeros con mas de 3 digitos se ecuentran en las posiciones: ");
        Console.WriteLine(string.Join(",", posicion));
      }
      else
      {
        Console.WriteLine("No hay numeros con mas de 3 digitos en la lista.");
      }
  } 
}