using System;
using System.Globalization;

namespace MaiorAreaTriangulos;

class Program
{
    static void Main(string[] args)
    {
        Triangulo x = CriarTriangulo();
        Triangulo y = CriarTriangulo();
        Triangulo maiorArea = CompararAreas(x, y);

        Console.WriteLine(x.ToString());
        Console.WriteLine(y.ToString());
        Console.WriteLine($"Triângulo com maior área: {maiorArea.Nome}.");
    }

    static Triangulo CriarTriangulo()
    {
        Triangulo triangulo = new Triangulo();
        
        Console.WriteLine("Entre com os dados do triângulo:");
        Console.Write("Nome: ");
        triangulo.Nome = Console.ReadLine()!;
        Console.Write("Lado A: ");
        triangulo.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado B: ");
        triangulo.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado C: ");
        triangulo.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        return triangulo;
    }

    static Triangulo CompararAreas(Triangulo t1, Triangulo t2)
    {
        double st1 = t1.Area();
        double st2 = t2.Area();
        
        if (st1 >= st2)
        {
            return t1;
        }
        else
        {
            return t2;
        }
    }
}