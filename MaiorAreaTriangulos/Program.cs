using System;
using System.Globalization;

namespace MaiorAreaTriangulos;

class Program
{
    static void Main(string[] args)
    {
        Triangulo x, y;

        x = new Triangulo();
        x.Nome = "X";
        y = new Triangulo();
        y.Nome = "Y";

        Console.WriteLine("Entre com as medidas do triângulo " + x.Nome + ":");
        x.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo " + y.Nome + ":");
        y.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine(x.ToString());
        Console.WriteLine(y.ToString());
        Console.Write("Maior área: ");

        if (x.Area() >= y.Area())
        {
            Console.WriteLine(x.Nome);
        }
        else
        {
            Console.WriteLine(y.Nome);
        }
    }
}