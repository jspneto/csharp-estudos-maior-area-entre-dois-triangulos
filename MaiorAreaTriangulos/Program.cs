using System;
using System.Globalization;

namespace MaiorAreaTriangulos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com as medidas do triângulo X:");
        double xA = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double xB = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double xC = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        double yA = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double yB = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double yC = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double xP = (xA + xB + xC) / 2.0;
        double yP = (yA + yB + yC) / 2.0;

        double xArea = Math.Sqrt(xP * (xP - xA) * (xP - xB ) * (xP - xC));
        double yArea = Math.Sqrt(yP * (yP - yA) * (yP - yB ) * (yP - yC));

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

