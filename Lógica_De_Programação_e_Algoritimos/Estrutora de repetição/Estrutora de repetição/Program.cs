using System;

try
{
    //Entrada de dados
    Console.Write("Digite a quantidade de visitantes: ");
    double quantidade = double.Parse(Console.ReadLine());

    Console.Write("Digite a altura minima permitida(em cm): ");
    double alturaMinima = double.Parse(Console.ReadLine());

    Console.Write("Digite a altira máxima permitida(em cm): ");
    double alturaMaxiama = double.Parse(Console.ReadLine());

    int contador = 0;

    //Prtocessamento de dados
    for (int i = 1; i <= quantidade; i++)
    {
        Console.Write($"Digite a altura do visitante {i} (em cm): ");
        double alture = double.Parse(Console.ReadLine());

        if (alture >= alturaMinima && alture <= alturaMaxiama)
        {
            contador++;
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Total de pessoas que podem andar na montanha-russa: {contador}");
}

catch
{
    Console.WriteLine("Valor inválido. Digite somente números");
}