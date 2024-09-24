using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] faturamentoDiario = new double[] { 1000, 1500, 2000, 2500, 3000, 1200, 1800, 0, 1500, 2200, 3000, 3500, 4000, 0, 1800 };
        var faturamentoValido = faturamentoDiario.Where(valor => valor > 0).ToArray();

        double menorFaturamento = faturamentoValido.Min();
        double maiorFaturamento = faturamentoValido.Max();
        double mediaMensal = faturamentoValido.Average();
        int diasSuperiorMedia = faturamentoValido.Count(valor => valor > mediaMensal);

        Console.WriteLine("{1} Menor faturamento: R$ " + menorFaturamento.ToString("F2") + ",");
        Console.WriteLine("{2} Maior faturamento: R$ " + maiorFaturamento.ToString("F2") + ",");
        Console.WriteLine("{3} Número de dias com faturamento superior à média: " + diasSuperiorMedia + ",");
    }
}
