using System;
using System.Globalization;

namespace MaiorAreaTriangulos;

class Triangulo
{
    
    private string _nome;
    private double _a;
    private double _b;
    private double _c;
    
    public Triangulo(string nome, double a, double b, double c)
    {
        if (nome != null && nome.Length >= 3)
        {
            _nome = nome;
        }
        else
        {
            _nome = "XYZ";
        }
        
        _a = a;
        _b = b;
        _c = c;
    }

    public string GetNome()
    {
        return _nome;
    }

    public void SetNome(string nome)
    {
        if (nome != null && nome.Length >= 3)
        {
            _nome = nome;
        }
    }

    public double GetA()
    {
        return _a;
    }

    public void SetA(double a)
    {
        if (a > 0.0)
        {
            _a = a;
        }
    }

    public double GetB()
    {
        return _b;
    }

    public void SetB(double b)
    {
        if (b > 0.0)
        {
            _b = b;
        }
    }

    public double GetC()
    {
        return _c;
    }

    public void SetC(double c)
    {
        if (c > 0.0)
        {
            _c = c;
        }
    }

    public Triangulo(string nome) : this(nome, 3.0, 4.0, 5.0) { }

    public double Area()
    {
        double p = (_a + _b + _c) / 2.0;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    public string ExibirArea()
    {
        return $"Área de {_nome}: {Area().ToString("F4", CultureInfo.InvariantCulture)} ua";
    }

    public override string ToString()
    {
        return $"Triângulo {_nome}\n"
            + "Lados: "
            + $"{_a.ToString("F4", CultureInfo.InvariantCulture)} uc, "
            + $"{_b.ToString("F4", CultureInfo.InvariantCulture)} uc, "
            + $"{_c.ToString("F4", CultureInfo.InvariantCulture)} uc\n"
            + $"Área: {Area().ToString("F4", CultureInfo.InvariantCulture)} ua";
    }
}