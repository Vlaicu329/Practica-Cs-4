using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Este programa determina si el segundo numero es par o impar tras una comprobación entre ambos");
        Console.WriteLine("Ingreseun primer numero:");
        var x = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un segundo número:");
        var y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            Console.WriteLine("El primr numero es mayor que el segundo numero.");
        }
        else if (x < y)
        {
            Console.WriteLine("El primer numero es menor que el segundo numero.");
        }
        else
        {
            Console.WriteLine("Los dos números son iguales.");
        }

        if (y % 2 == 0)
        {
            Console.WriteLine("El segundo número es par.");
        }
        else
        {
            Console.WriteLine("El segundo número es impar.");
        }
    }
}