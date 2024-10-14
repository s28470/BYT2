namespace Calculator
{
    public class Calculator
    {
        private dynamic a;

        private dynamic b;

        private string operation;

        public Calculator(dynamic a, dynamic b, string operation)
        {

            try
            {
                this.a = Convert.ToDecimal(a);
                this.b = Convert.ToDecimal(b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
                throw;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument is null");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input too large");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot be used" + e.Message);
                throw;
            }
            this.operation = operation;
        }

        public decimal Calculate()
        {
            dynamic result;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b != 0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                    break;
                
                default:
                    Console.WriteLine("No operation");
                    throw new ArgumentException();
            }

            return result;
        }
    }    
}
