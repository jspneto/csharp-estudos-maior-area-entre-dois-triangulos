# Maior Área Entre Dois Triângulos

Projeto de estudo em C# com o objetivo de **calcular e comparar a área de dois triângulos** a partir das medidas de seus lados, utilizando a **fórmula de Heron**.

Este projeto foi desenvolvido de forma incremental, registrando a evolução do código do estilo **procedural** até uma abordagem **orientada a objetos**.

## Conceitos Trabalhados

- Leitura de dados via console
- Estruturação de código em C#
- Introdução à Programação Orientada a Objetos
- Criação de classes e métodos
- Organização e versionamento com Git

## Enunciado do Problema

Ler as medidas dos lados de dois triângulos (X e Y), considerando medidas válidas.

Em seguida:
- Calcular a área de cada triângulo
- Exibir os valores das áreas
- Informar qual triângulo possui a maior área

A área de um triângulo com lados `a`, `b` e `c` é calculada pela **fórmula de Heron**:

```bash
p = (a + b + c) / 2
area = RaizQ(p * (p - a) * (p - b) * (p - c))
```

## Estrutura do Projeto

```bash
|- MaiorAreaTriangulos
   |- MaiorAreaTriangulos.csproj
   |- MaiorAreaTriangulos.sln
   |- Program.cs
   |- Triângulo.cs
```

*(A estrutura pode evoluir conforme o aprendizado avança.)*

## Evolução do Projeto (Tags)

- [**v0.1**][1] — Implementação totalmente procedural
- [**v0.2**][2] — Introdução da classe `Triangulo` com atributos públicos
- [**v0.3**][3] — Criação de método para o cálculo da área do triângulo
- [**v0.4**][4] — Sobrescrita do método `ToString` na classe `Triangulo`
- [**v0.4.1**][5] — Refatoração estrutural e melhoria da representação textual
- [**v0.5**][6] — Introdução de construtor parametrizado

## Objetivo Educacional

Este projeto **não tem como foco a solução final perfeita**, mas sim o processo de aprendizado e a comparação entre abordagens diferentes para o mesmo problema.

Ele serve como material de consulta futura e base para exercícios mais complexos.

[1]: https://github.com/jspneto/csharp-estudos-maior-area-entre-dois-triangulos/tree/v0.1/MaiorAreaTriangulos "v0.1"

[2]: https://github.com/jspneto/csharp-estudos-maior-area-entre-dois-triangulos/tree/v0.2/MaiorAreaTriangulos "v0.2"

[3]: https://github.com/jspneto/csharp-estudos-maior-area-entre-dois-triangulos/tree/v0.3/MaiorAreaTriangulos "v0.3"

[4]: https://github.com/jspneto/csharp-estudos-maior-area-entre-dois-triangulos/tree/v0.4/MaiorAreaTriangulos "v0.4"

[5]: https://github.com/jspneto/csharp-estudos-maior-area-entre-dois-triangulos/tree/v0.4.1/MaiorAreaTriangulos "v0.4"

[6]: https://github.com/jspneto/csharp-estudos-maior-area-entre-dois-triangulos/tree/v0.5/MaiorAreaTriangulos "v0.5"
