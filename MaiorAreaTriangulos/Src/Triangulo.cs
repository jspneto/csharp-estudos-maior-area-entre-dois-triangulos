using System;
using System.Globalization;

namespace MaiorAreaTriangulos.Src;

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

    public Triangulo(string nome) : this(nome, 3.0, 4.0, 5.0) { }

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            if (value != null && value.Length >= 3)
            {
                _nome = value;
            }
        }
    }

    public double A
    {
        get
        {
            return _a;
        }

        set
        {
            if (value > 0.0)
            {
                _a = value;
            }
        }
    }

    public double B
    {
        get
        {
            return _b;
        }

        set
        {
            if (value > 0.0)
            {
                _b = value;
            }
        }
    }

    public double C
    {
        get
        {
            return _c;
        }

        set
        {
            if (value > 0.0)
            {
                _c = value;
            }
        }
    }

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