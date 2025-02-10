namespace CalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number: ");
            int firstNr = int.Parse(Console.ReadLine()); // string tuleb konvertida int andmetüübiks
            
            Console.WriteLine("Inser calculation type: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            float calculationType = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number: ");
            float secondNr = float.Parse(Console.ReadLine());
            float result = 0;

            switch (calculationType)
            {
                case 1:
                    result = firstNr + secondNr;
                    Console.WriteLine(firstNr + " + " + secondNr + " = " + result);
                    break;
                 case 2:
                     result = firstNr - secondNr;
                     Console.WriteLine(firstNr + " - " + secondNr + " = " + result);
                break;
                    case 3:
                        result = firstNr * secondNr;
                        Console.WriteLine(firstNr + " * " + secondNr + " = " + result);
                    break;
                    case 4:
                        result = firstNr / secondNr;
                        Console.WriteLine(firstNr + " / " + secondNr + " = " + result);
                    break;
                default:
                    break;
            }
        }
    }
}
