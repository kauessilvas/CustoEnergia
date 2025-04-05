Console.Clear();
double consumptionKwh, hoursPerDay, energyCost, estimatedCost;

Console.Write("Consumo do aparelho (em kWh/mês)...: ");
while (!double.TryParse(Console.ReadLine(), out consumptionKwh) || consumptionKwh < 0)
{
    Console.Write("Entrada Inválida ! Digite o consumo do aparelho (em kWh/mês)...: ");
}
Console.Write("Horas de uso por dia...............: ");
while (!double.TryParse(Console.ReadLine(), out hoursPerDay) || hoursPerDay < 0)
{
    Console.Write("Entrada Inválida ! Digite as horas de uso por dia...............: ");
}
Console.Write("Custo da energia (em R$/kWh).......: ");
while (!double.TryParse(Console.ReadLine(), out energyCost) || energyCost < 0)
{
    Console.Write("Entrada Inválida ! Digite o custo da energia (em R$/kWh).......: ");
}

estimatedCost = consumptionKwh * hoursPerDay * energyCost;
Console.WriteLine($"Custo estimado: {estimatedCost:C}");