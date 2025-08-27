using EstruturaClasses;

Veiculo v = new Veiculo();
v.Placa = "ART2036";
v.Potencia = 1.4;
v.Montadora = "FIAT";
v.Ano = 2025;
var lValorLiquido = v.ValorLiquidoAluguel(5000, Veiculo.TipoPessoa.Juridica);

string lMensagem =
    $"Placa: {v.Placa}\n" +
    $"Potência: {v.Potencia}\n" +
    $"Montadora: {v.Montadora}\n" +
    $"Ano: {v.Placa}\n\n" +
    $"Valor líquido do aluguel: {lValorLiquido}";

Console.WriteLine(lMensagem);
Console.ReadKey();
