using terreno;
string continuar = "s";
string parar = "n";
while (continuar == "s")
{
    try
    {
        //Entrada de dados
        Console.Write("Digite a largura do terreno: ");
        Terreno.largura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do terreno: ");
        Terreno.comprimento = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do metro quadrado: ");
        Terreno.valor = Convert.ToDouble(Console.ReadLine());

        //Processamento de dados
        Console.WriteLine($"Area do terreno = {Terreno.CalcularArea()}");
        Console.WriteLine($"Preço do terreno = {Terreno.CalcularPreço()}");

    }
    catch
    {
        Console.WriteLine("Digite somente números!");
        
        Console.WriteLine("Você deseja digita continuar!(s/n)");
        continuar  = Console.ReadLine();
                
        if (continuar == "s")
        {
            Console.WriteLine("Digite o número que deseja!");
        }
        else 
        {
            parar = "n";
            Console.WriteLine("Você não decidiu não continuar!");
            break;
        }
        break;
    }
}
