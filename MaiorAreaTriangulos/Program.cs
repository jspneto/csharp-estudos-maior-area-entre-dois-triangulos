using System;
using System.Globalization;

namespace MaiorAreaTriangulos;

class Program
{
    static void Main(string[] args)
    {
        Triangulo x, y;

        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X:");
        x.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        y.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double xArea = x.Area();
        double yArea = y.Area();

        Console.WriteLine("Área de X: " + xArea.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y: " + yArea.ToString("F4", CultureInfo.InvariantCulture));
        Console.Write("Maior área: ");

        if (xArea >= yArea)
        {
            Console.WriteLine("X");
        }
        else
        {
            Console.WriteLine("Y");
        }
    }
}