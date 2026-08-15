try
{
    //Entrada de dados
    Console.Write("Digite o valor de A: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o valor de B: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o valor de C:");
    double c = Convert.ToDouble(Console.ReadLine());
    // processamento de dados
    if (a < b + c && b < a + c && c < b + c)
    {
        double perimetro = a + b + c;
        Console.WriteLine($"perimetro = {perimetro:F1}");
    }
    else
    {
        double area = (a + b + c) / 2;
    }
}
catch
{
    Console.WriteLine("Degite somente os numeros!");
}