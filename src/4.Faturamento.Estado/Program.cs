namespace _4.Faturamento.Estado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stateBillings = new Dictionary<string, double>()
            {
                {"SP", 67836.43 },
                {"RJ", 36678.66 },
                {"MG", 29229.88 },
                {"ES", 27165.48 },
                {"OUTROS", 19849.53 }
            };

            var total = stateBillings.Values.Sum();

            Console.WriteLine("Percentage of revenue by state:\n");

            foreach (var state in stateBillings)
            {
                double percentage = (state.Value / total) * 100;
                Console.WriteLine($"{state.Key}: {percentage:F2}%");
            }
        }
    }
}
