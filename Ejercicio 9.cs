//Leer 10 números enteros, almacenarlos en un arreglo y calcular la 
//factorial a cada uno de los números leídos almacenándolos en otro arreglo

using System;

class Add
{
  static void Main(string[] args)
  {
    List<int> lista = new List<int> {};
    List<int> factoriales = new List<int> {};

    int cant = 0;
    int res = 0;

    for (int x = 0; x <= 9; x++)
    {
        Console.Clear();
        Console.WriteLine("Elige el " + (x+1) + " numero: ");
        int y = Convert.ToInt32(Console.ReadLine());
        lista.Add(y);
    }

    Console.Clear();

    for (int x = 0; x <= 9; x++)
    {
        cant = lista[x];
        res = cant;

        while (res>1)
        {
          res-=1;
          cant = cant*(res);
        }
        factoriales.Add(cant);
    }

    Console.WriteLine("Los Factoriales de los numeros dados en el mismo orden son:" + "\n");

    for (int x = 0; x <= 9; x++)
    {
      Console.WriteLine("Los Factoriales de " + lista[x] + " es " + factoriales[x]);
    }
  
  } 
}