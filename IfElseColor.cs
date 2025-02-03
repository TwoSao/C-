
namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Eneter color: ");
            string userInput = Console.ReadLine();

            if (userInput == "")
            {
                Console.WriteLine("Choose another colors: red, blue, green, white.");
            }
            else
            {
                if (userInput == "red")
                {
                    Console.WriteLine("You choose red.");
                }
                else if (userInput == "blue")
                {
                    Console.WriteLine("You choose blue.");
                }
                else if (userInput == "green")
                {
                    Console.WriteLine("You choose green.");
                }
                else if (userInput == "white")
                {
                    Console.WriteLine("You choose white.");
                }
                else
                {
                    Console.WriteLine($"Color '{userInput}' dont color. Pls,chose red, blue, green or white.");
                }
            }
        }
    }
}
