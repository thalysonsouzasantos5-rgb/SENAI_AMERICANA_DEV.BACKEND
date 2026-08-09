try
{
    //Entrada de datos
    double a, b, c, d;
    Console.Write("Digite o valor de a: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor de b: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor de c: ");
    c = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor de d: ");
    d = double.Parse(Console.ReadLine());
    //Processamento de dados
    double total = (a + b + c + d);
    Console.WriteLine("O total é: " + total);
}
catch (FormatException)
{
    Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número válido.");
}
return 0;
{
    while (true)
    {
        Console.WriteLine("Digite 'sair' para encerrar o programa ou pressione Enter para continuar.");
        string input = Console.ReadLine();
        if (input.ToLower() == "sair")
        {
            break;
        }
    }       
}