namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator sum = new Calculator(10, 20, "+");
            Console.WriteLine($"Sum is ${sum.Calculate()}");

            Calculator diff = new Calculator(30, 20, "-");
            Console.WriteLine($"Diff is: ${diff.Calculate()}");

            Calculator mult = new Calculator(10, 2, "*");
            Console.WriteLine($"Mult is {mult.Calculate()}");

            Calculator divide = new Calculator(13, Math.Pow(111111111, 9999999999999), "/");
            Console.WriteLine($"Divide is ${divide.Calculate()}");
        }
    }    
}


