//Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.

using System;

class Add
{
  static void Main(string[] args)
  {
    List<decimal> lista = new List<decimal> {};

    List<decimal> lista2 = new List<decimal> {};

    int z = 0;

    for (int x = 0; x <= 9; x++)
    {
        Console.Clear();
        Console.WriteLine("Elige el " + (x+1) + " numero: ");
        Decimal y = Convert.ToDecimal(Console.ReadLine());
        lista.Add(y);

        for (int i = 1; i < (y + 1); i++)
        {
          if (y % i == 0)
          {
            z++;
          }
        }

        if (z != 2)
        {
          lista2.Add(0);
        }

        else
        {
          lista2.Add((lista[x]));
        }
        z = 0;
    }
    
    Console.Clear();
    Console.WriteLine("El numero primo mas alto es el " + lista2.Max() + " y se encuentra en la posicion: " +(lista.IndexOf(lista2.Max())+1));

  } 
}