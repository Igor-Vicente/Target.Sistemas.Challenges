namespace _2.Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number: ");

            if (int.TryParse(Console.ReadLine(), out var number))
            {
                var isFibonacciNumber = CheckIsFibonacciNumber(number);

                if (isFibonacciNumber) Console.WriteLine($"The number {number} belongs to the fibonacci sequence.");
                else Console.WriteLine($"The number {number} doesn't belong to the fibonacci sequence.");
            }
            else
            {
                Console.WriteLine("Invalid number. (Must be integer)");
            }

        }

        public static bool CheckIsFibonacciNumber(int number)
        {
            int a = 0;
            int b = 1;

            while (a <= number)
            {
                if (a == number) return true;

                int temp = a + b;
                a = b;
                b = temp;
            }

            return false;
        }
    }
}
