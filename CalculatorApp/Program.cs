namespace CalculatorApp
{
    public class Program
    {
        public class Calculator
        {
            public int Add(int a, int b) => a + b;
            public int Subtract(int a, int b) => a - b;
        }

        public static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine("=== Simple Calculator ===");
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {calc.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {calc.Subtract(a, b)}");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
