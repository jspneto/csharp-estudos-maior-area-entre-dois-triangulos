using System;
using System.Globalization;

namespace MaiorAreaTriangulos;

class Program
{
    static void Main(string[] args)
    {
        //ExemploGeral();
        ExemploSobrecarga();
    }

    static Triangulo CriarTriangulo()
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
    static void ExemploGeral()
    {
        Triangulo x = CriarTriangulo();
        Triangulo y = CriarTriangulo();
        Triangulo maiorArea = CompararAreas(x, y);

        Console.WriteLine(x.ExibirArea());
        Console.WriteLine(y.ExibirArea());
        Console.WriteLine($"Triângulo com maior área: {maiorArea.Nome}");
    }

    static void ExemploSobrecarga()
    {
        Console.WriteLine("Entre com o nome do triângulo:");
        string nome = Console.ReadLine()!;
        Triangulo x = new Triangulo(nome);

        Triangulo y = CriarTriangulo();

        Console.WriteLine();
        Console.WriteLine("Exemplo de sobrecarga:");
        Console.WriteLine();
        Console.WriteLine(x.ToString());
        Console.WriteLine();
        Console.WriteLine(y.ToString());
    }
}