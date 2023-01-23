//Leer 10 números enteros, almacenarlos en un arreglo y determinar en 
//qué posición se encuentra el número primo con mayor cantidad de dígitos pares.

using System;

class Add
{
  static void Main(string[] args)
  {
    List<decimal> lista = new List<decimal> {};

    List<int> Contador = new List<int> {};

    int z = 0;
    int w = 0;

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
          Contador.Add(0);
        }
        else
        {
          int count = Convert.ToInt32(y);
          while (count>=10)
          {
            count/=10;
            if (count%10 == 2 || count%10 == 4 || count%10 == 6 || count%10 == 8)
            {
              w++;
            }
          }
          Contador.Add(w);
          w=0;
        }
        z = 0;
    }
    Console.Clear();
    int posicion = Contador.Max();
    Console.WriteLine("El numero primo con mas digitos pares es " + (lista[Contador.IndexOf(posicion)]) +  " y se encuentra en la posicion: " + (Contador.IndexOf(posicion)+1));
  } 
}