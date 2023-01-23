//Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos 
//números de los almacenados en dicho arreglo comienzan en dígito primo

using System;

class Add
{
  static void Main(string[] args)
  {
    List<int> lista = new List<int> {};
    int w = 0;

    for (int x = 0; x <= 9; x++)
    {
        Console.Clear();
        Console.WriteLine("Elige el " + (x+1) + " numero: ");
        int y = Convert.ToInt32(Console.ReadLine());
        lista.Add(y);

        while (y>=10)
        {
          y/= 10;
        }
        if (y == 2 || y == 3 || y == 5 || y == 7 )
        {
          w++;
        }
    }
    
    Console.Clear();
    Console.WriteLine("La cantidad de numeros que empiezan por digito primo son: " + w);

  } 
}