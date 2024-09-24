using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    public class Faturamento
    {
        public double[] faturamento_diario { get; set; } = Array.Empty<double>();
    }

    static void Main()
    {
        string json;
        try
        {
            json = File.ReadAllText("faturamento.json");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Erro: O arquivo 'faturamento.json' não foi encontrado.");
            return;
        }

        Faturamento? dados = JsonConvert.DeserializeObject<Faturamento>(json);
        
        if (dados?.faturamento_diario == null || !dados.faturamento_diario.Any())
        {
            Console.WriteLine("Erro: Não há dados de faturamento disponíveis.");
            return;
        }

        double[] faturamentoValido = dados.faturamento_diario.Where(valor => valor > 0).ToArray();

        if (!faturamentoValido.Any())
        {
            Console.WriteLine("Erro: Não há faturamento válido para processar.");
            return;
        }

        double menorFaturamento = faturamentoValido.Min();
        double maiorFaturamento = faturamentoValido.Max();
        double mediaMensal = faturamentoValido.Average();
        int diasSuperiorMedia = faturamentoValido.Count(valor => valor > mediaMensal);

        Console.WriteLine("Menor faturamento: R$ {0:F2}", menorFaturamento);
        Console.WriteLine("Maior faturamento: R$ {0:F2}", maiorFaturamento);
        Console.WriteLine("Número de dias com faturamento superior à média: {0}", diasSuperiorMedia);
    }
}
