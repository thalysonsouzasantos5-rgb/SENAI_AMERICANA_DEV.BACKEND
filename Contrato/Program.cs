using Contrato;

empresa SENAI = new empresa("Roberto Mange", "Clodoado");
SENAI.RegistrarContratoFuncinario(10, 50);

Console.WriteLine(SENAI);

SENAI = null;

Console.WriteLine(SENAI);
Console.WriteLine();