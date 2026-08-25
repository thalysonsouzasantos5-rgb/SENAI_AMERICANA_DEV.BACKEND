//Declaração de variaveis
int turistaNoParque = 0;
int veiculoNoParque = 0;

string movimento = Console.ReadLine();

//Processamento de dados
while (movimento != "Sair")
{
	int turista = Convert.ToInt32(movimento);
    if (movimento == "entrando")
	{
		turistaNoParque += turistaNoParque;
        veiculoNoParque++;
		
	}
	else if (movimento == "voltando")
	{
        turistaNoParque -= turistaNoParque;
        veiculoNoParque--;
		
	}
	movimento = Console.ReadLine();
}
Console.WriteLine($"Turista: {turistaNoParque}");
Console.WriteLine($"Veiculos: {veiculoNoParque}");