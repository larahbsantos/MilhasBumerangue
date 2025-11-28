double percentualBonus, percentualRetorno;
int pontosAtransferir;
int pontosAReduzirOigem, pontosAAcrescentarDestino;

Console.WriteLine("---Milhas Bumerangue---\n");

Console.Write("Percentual de bônus....: ");
percentualBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Percentual de retorno....: ");
percentualRetorno = Convert.ToDouble(Console.ReadLine());

Console.Write("Pontos a tansferir....: ");
pontosAtransferir = Convert.ToInt32(Console.ReadLine());

pontosAReduzirOigem = Convert.ToInt32(pontosAtransferir - (percentualRetorno / 100) * pontosAtransferir);
pontosAAcrescentarDestino = Convert.ToInt32(pontosAtransferir + (percentualBonus /100) * pontosAtransferir);

Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem......: {pontosAReduzirOigem}");
Console.WriteLine($"Pontos a acrescentar no destino...: {pontosAAcrescentarDestino}");