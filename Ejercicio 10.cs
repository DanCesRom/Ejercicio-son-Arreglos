//Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y 
//determinar cuántos divisores exactos tiene este último número entre los valores almacenados en el arreglo.

using System;

class Add
{
  static void Main(string[] args)
  {
    List<decimal> lista = new List<decimal> {};
    Decimal count = 0;

    for (int x = 0; x <= 9; x++)
    {
      Console.Clear();
      Console.WriteLine("Elige el " + (x+1) + " numero: ");
      Decimal y = Convert.ToDecimal(Console.ReadLine());
      lista.Add(y);
    }

    Console.Clear();
    Console.WriteLine("Elige un numero a dividir: ");
    Decimal numerador = Convert.ToDecimal(Console.ReadLine());

    for (int x = 0; x <= 9; x++)
    {
      if ((numerador%lista[x]) == 0)
      {
        count++; 
      } 
    }
    Console.Clear();
    Console.WriteLine("El Numero " + numerador + " tiene " + count + " divisores exactos");
  }
}