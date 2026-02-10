using System;
using System.Globalization;

namespace MaiorAreaTriangulos;

class Triangulo
{
    
    public string Nome = "XYZ";
    public double A;
    public double B;
    public double C;

    public double Area()
    {
        double p = (A + B + C) / 2.0;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override string ToString()
    {
        return "Área de " + Nome + ": " + Area().ToString("F4", CultureInfo.InvariantCulture);
    }
}