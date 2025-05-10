using System.Text;

namespace _5.String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a text: ");
            var text = Console.ReadLine();
            text = text?.Trim();

            if (text == null || string.IsNullOrEmpty(text))
            {
                Console.WriteLine("You didn't provide a message");
                return;
            }

            var newText = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                newText.Append(text[i]);
            }

            Console.WriteLine(newText);
        }
    }
}
