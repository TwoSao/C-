
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Suvalised värvid!");

        // Генератор случайных чисел
        Color c = (Color)(new Random()).Next(0, 5);
        switch (c)
           {
            case Color.Red:
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Red");
                break;

            case Color.Red:
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Green");
                break;

            case Color.Red:
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("White");
                break;

            case Color.Red:
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Blue");
                break;

            case Color.Red:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Yellow");
                break;
        }









        Random random = new Random();
        int randomNumber = random.Next(1, 6); // Случайное число от 1 до 5

        switch (randomNumber)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valitud värv on Punane (Red).");
                break;
            case 2:
                Console.ForegroundColor foregroundColor = ConsoleColor.Green;
                Console.WriteLine("Valitud värv on Roheline (Green).");
                break;
            case 3:
                Console.ForegroundColor foregroundColor1 = ConsoleColor.Blue;
                Console.WriteLine("Valitud värv on Sinine (Blue).");
                break;
            case 4:
                Console.ForegroundColor foregroundColor2 = ConsoleColor.White;
                Console.WriteLine("Valitud värv on Valge (White).");
                break;
            case 5:
                Console.ForegroundColor foregroundColor3 = ConsoleColor.Yellow;
                Console.WriteLine("Valitud värv on Oranž (Orange).");
                break;
        }
    }
}