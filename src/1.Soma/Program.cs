namespace _1.Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int soma = 0;
            int indice = 13;

            while (k < indice)
            {
                k++;
                soma = soma + k;
                Console.Write(soma + ", ");
            }

            Console.WriteLine($"The final result, after processing: {soma}");
        }
    }
}
