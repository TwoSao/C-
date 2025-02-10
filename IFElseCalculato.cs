namespace IfElseCalulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta esimene number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta teine number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta tehe (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Viga: jagamine nulliga!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Vale tehe!");
                return;
            }

            Console.WriteLine("Tulemus: " + result);
        }
    }
}
