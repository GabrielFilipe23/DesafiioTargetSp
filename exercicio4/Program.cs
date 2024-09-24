using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double totalFaturamento = faturamentoPorEstado.Values.Sum();
        var estados = faturamentoPorEstado.Keys.ToArray();
        var valores = faturamentoPorEstado.Values.ToArray();

        Console.WriteLine("Faturamento total: R$ {0:F2}", totalFaturamento);
        Console.WriteLine("Porcentagem do faturamento de cada estado:");

        for (int i = 0; i < estados.Length; i++)
        {
            double porcentagem = (valores[i] / totalFaturamento) * 100;
            Console.WriteLine("{0}: {1:F2}%", estados[i], porcentagem);
        }
    }
}
