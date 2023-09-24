decimal custoEnerg, custoMes; 
double tmpDiario, consumo;

Console.Clear();

Console.WriteLine("--- Custo de energia ---\n");

Console.Write("Consumo do aparelho (em kWh/mês)...: ");
tmpDiario = Convert.ToDouble(Console.ReadLine());

Console.Write("Horas de uso por dia...............: ");
consumo = Convert.ToDouble(Console.ReadLine());

Console.Write("Custo da energia (em R$/kWh).......: ");
custoEnerg = Convert.ToDecimal(Console.ReadLine());

custoMes = Convert.ToDecimal(consumo * tmpDiario) * custoEnerg;

Console.WriteLine($"\nCusto estimado: {custoMes:C}");