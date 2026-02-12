using System;
using System.Globalization;

namespace MaiorAreaTriangulos;

class Triangulo
{
    
    public string Nome;
    public double A;
    public double B;
    public double C;

    public Triangulo(string nome, double a, double b, double c)
    {
        Nome = nome;
        A = a;
        B = b;
        C = c;
    }

    public double Area()
    {
        double p = (A + B + C) / 2.0;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public string ExibirArea()
    {
        return $"Área de {Nome}: {Area().ToString("F4", CultureInfo.InvariantCulture)} ua";
    }

    public override string ToString()
    {
        return $"Triângulo {Nome}\n"
            + "Lados:"
            + $"{A.ToString("F4", CultureInfo.InvariantCulture)} uc, "
            + $"{B.ToString("F4", CultureInfo.InvariantCulture)} uc, "
            + $"{C.ToString("F4", CultureInfo.InvariantCulture)} uc\n"
            + $"Área: {Area().ToString("F4", CultureInfo.InvariantCulture)} ua";
    }
}