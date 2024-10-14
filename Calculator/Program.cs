namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator sum = new Calculator(10, 20, "+");
            Console.WriteLine($"Sum is {sum.Calculate()}");

            Calculator diff = new Calculator(30, 20, "-");
            Console.WriteLine($"Diff is: {diff.Calculate()}");

            Calculator mult = new Calculator(10, 2, "*");
            Console.WriteLine($"Mult is {mult.Calculate()}");

            Calculator divide = new Calculator(12, 3, "/");
            Console.WriteLine($"Divide is {divide.Calculate()}");
        }
    }    
}


