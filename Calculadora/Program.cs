// Declaração de Variaveis
Calculadora calculadora;
double raio;

//Entrada de dados
Console.Write("Entre com valor do raio da circunferencia: ");
raio = double.Parse(Console.ReadLine());

//Instanciação do objeto
Calculadora = 
//Processamento de dados
circunferencia = 2 * pi * raio;
volume = (4 * pi * Math.Pow(raio, 3)) / 3;

//Saida de dados
Console.WriteLine($"Circunferencia: {circunferencia:f2}" + $"Volume: {volume:f2}" + $"PI: {pi:f2}");
