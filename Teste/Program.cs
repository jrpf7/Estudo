Imposto iss = new ISS();
Imposto icms = new ICMS();

Orcamento orcamento = new(1000);
CalculadorDeImpostos calculadorDeImpostos = new();

calculadorDeImpostos.RealizaCalculo(orcamento, iss);

Console.ReadLine();
