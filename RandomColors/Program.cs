
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Suvalised värvid!");

        // Генератор случайных чисел
        Random random = new Random();
        int randomNumber = random.Next(1, 6); // Случайное число от 1 до 5

        switch (randomNumber)
        {
            case 1:
                ConsoleColor consoleColor = ConsoleColor.Red;
                Console.WriteLine("Valitud värv on Punane (Red).");
                break;
            case 2:
                consoleColor = ConsoleColor.Green;
                Console.WriteLine("Valitud värv on Roheline (Green).");
                break;
            case 3:
                consoleColor = ConsoleColor.Blue;
                Console.WriteLine("Valitud värv on Sinine (Blue).");
                break;
            case 4:
                consoleColor = ConsoleColor.Magenta;
                Console.WriteLine("Valitud värv on Valge (White).");
                break;
            case 5:
                consoleColor = ConsoleColor.Yellow;
                Console.WriteLine("Valitud värv on Oranž (Orange).");
                break;
        }
    }
}