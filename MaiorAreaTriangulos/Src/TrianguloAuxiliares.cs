using System;
using System.Globalization;

namespace MaiorAreaTriangulos.Src;

static class TrianguloAuxiliares
{
    static public Triangulo CriarTriangulo()
    {
        Console.WriteLine("Entre com os dados do triângulo:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Lado A: ");
        double a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado B: ");
        double b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado C: ");
        double c = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Triangulo triangulo = new Triangulo(nome, a, b, c);

        return triangulo;
    }

    static public Triangulo CompararAreas(Triangulo t1, Triangulo t2)
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