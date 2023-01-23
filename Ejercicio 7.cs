//Leer 10 números enteros, almacenarlos en un arreglo y determinar a cuánto es igual el promedio entero de los datos del arreglo

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
      int y = Convert.ToInt32(Console.ReadLine());
      lista.Add(y);
    }

    int promedio = lista.Sum()/10;
    Decimal dec = Convert.ToDecimal(lista.Sum())/10;
    Console.Clear();
    Console.WriteLine("El promedio entero de los numeros del arreglo es: " + promedio + "\n");
    Console.WriteLine("El promedio con decimal de los numeros del arreglo es: " + dec);
  }
}