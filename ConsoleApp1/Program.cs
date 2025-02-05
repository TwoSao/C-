    namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coinD = 25.75;
            double earthR = 6378000000;
            double aroundE = 2 * Math.PI * earthR;
            Console.WriteLine("Maa ümbermõõt: " + aroundE);
            double result = aroundE / coinD;
            Console.WriteLine("Ümber maa mahub nii: " + "palju kahe eurosid" + result);


            Console.WriteLine("Hello, World!");
        }
    }
}
