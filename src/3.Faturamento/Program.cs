using System.Text.Json;

namespace _3.Faturamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "wwwroot", "faturamento.json");
            string fileString = File.ReadAllText(filePath);

            var billing = JsonSerializer.Deserialize<List<Faturamento>>(fileString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            var daysWithInvoicing = billing?.Where(i => i.Valor > 0).ToList() ?? [];

            var lowestValue = daysWithInvoicing.Min(d => d.Valor);
            var biggestValue = daysWithInvoicing.Max(d => d.Valor);
            var average = daysWithInvoicing.Average(d => d.Valor);
            var daysAboveAverage = daysWithInvoicing.Count(d => d.Valor > average);

            Console.WriteLine($"Lowest billing value: {lowestValue:F2}");
            Console.WriteLine($"Highest billing value: {biggestValue:F2}");
            Console.WriteLine($"Days with above average revenue: {daysAboveAverage}");
        }
    }
}
