using System;
using System.Globalization;

namespace MaiorAreaTriangulos.Src;

static class TrianguloExemplos
{
    static public void ExemploGeral()
    {
        Triangulo x = TrianguloAuxiliares.CriarTriangulo();
        Triangulo y = TrianguloAuxiliares.CriarTriangulo();
        Triangulo maiorArea = TrianguloAuxiliares.CompararAreas(x, y);

        Console.WriteLine(x.ExibirArea());
        Console.WriteLine(y.ExibirArea());
        Console.WriteLine($"Triângulo com maior área: {maiorArea.Nome}");
    }

    static public void ExemploSobrecarga()
    {
        Console.WriteLine("Entre com o nome do triângulo:");
        string nome = Console.ReadLine()!;
        Triangulo x = new Triangulo(nome);
        Triangulo y = TrianguloAuxiliares.CriarTriangulo();

        Console.WriteLine();
        Console.WriteLine("Triângulo criado apenas com o nome:");
        Console.WriteLine(x.ToString());
        Console.WriteLine();
        Console.WriteLine("Triângulo criado com todos os atributos:");
        Console.WriteLine(y.ToString());
    }

    static public void ExemploEncapsulamento()
    {
        Console.WriteLine("Entre com o nome do triângulo:");
        string nome = Console.ReadLine()!;
        Triangulo x = new Triangulo(nome);

        Console.WriteLine();
        Console.WriteLine($"Nome: {x.Nome}");
        Console.WriteLine($"Lado A: {x.A.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Lado B: {x.B.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Lado C: {x.C.ToString("F4", CultureInfo.InvariantCulture)}");

        Console.WriteLine();
        Console.Write("Digite um novo nome:");
        nome = Console.ReadLine()!;
        Console.Write("Digite uma nova medida para A: ");
        double a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Digite uma nova medida para B: ");
        double b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Digite uma nova medida para C: ");
        double c = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        x.Nome = nome;
        x.A = a;
        x.B = b;
        x.C = c;

        Console.WriteLine();
        Console.WriteLine("Triangulo atualizado:");
        Console.WriteLine();
        Console.WriteLine(x.ToString());
    }
}