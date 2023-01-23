//Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición de del arreglo está el mayor número par leído.

using System;

class Add
{
  static void Main(string[] args)
  {
    List<decimal> lista = new List<decimal> {};

    List<decimal> lista2 = new List<decimal> {};

    for (int x = 0; x <= 9; x++)
    {
        Console.Clear();
        Console.WriteLine("Elige el " + (x+1) + " numero: ");
        lista.Add(Convert.ToDecimal(Console.ReadLine()));
        if (((lista[x])/2)%1 ==0)
        {
          lista2.Add((lista[x]));
        }
        else
        {
          lista2.Add(0);
        }  
    }
    Console.WriteLine("El numero mas alto es el " + lista2.Max() + " y se encuentra en la posicion: " +(lista.IndexOf(lista2.Max())+1));

  } 
}


