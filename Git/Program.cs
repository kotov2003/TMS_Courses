public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!\n");

        Task1();
    }

    private static void Task1()
    {
        Console.WriteLine($"Welcome to СonsoleСalculator!\n{new String('=', 25)}");

        Console.WriteLine("Enter the first operand: ");
        string? firstOperand = Console.ReadLine();

        Console.WriteLine("Enter the sign of the arithmetic operation: ");
        string? sign = Console.ReadLine();

        Console.WriteLine("Enter the second operand: ");
        string? secondOperand = Console.ReadLine();

        var operand1 = Convert.ToDouble(firstOperand);
        var operand2 = Convert.ToDouble(secondOperand);
        double result = default(double);
        bool IsInputDataError = default;

        switch (sign)
        {
            case "+":
                result = operand1 + operand2;
                break;
            case "-":
                result = operand1 - operand2;
                break;
            case "*":
                result = operand1 * operand2;
                break;
            case "/":
                if (operand2 == 0)
                {
                    Console.WriteLine($"{new String('-', 25)}\nInvalid input data: division by zero is not allowed.");
                    IsInputDataError = true;
                    break;
                }
                else
                    result = operand1 / operand2;
                break;
            case "%":
                result = operand1 % operand2;
                break;
            default:
                break;
        }

        if (!IsInputDataError) Console.WriteLine($"{new String('-', 25)}\nResult: {result}");
    }
}
