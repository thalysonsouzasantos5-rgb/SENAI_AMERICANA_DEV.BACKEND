using System;
try
{
    //Entrada de dados
    double a, b, c;
    Console.Write("Digite o valor do lado A: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor do lado B: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor do lado C: ");
    c = double.Parse(Console.ReadLine());
    //Verifica se os lados formam um triângulo
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Os lados formam um triângulo.");
    }
    else
    {
        Console.WriteLine("Os lados não formam um triângulo.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}