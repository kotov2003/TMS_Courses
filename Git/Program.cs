public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!\n");

        Task1();
        Task2();
        Task3();
    }

    private static void Task1()
    {
        Console.WriteLine($"\n{new String('=', 55)}\nWelcome to Task1!\n{new String('=', 55)}");

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
                    Console.WriteLine($"{new String('-', 55)}\nInvalid input data: division by zero is not allowed.\n{new String('-', 55)}\n");
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

        if (!IsInputDataError) Console.WriteLine($"{new String('-', 55)}\nResult: {result}\n{new String('-', 55)}\n");
    }

    private static void Task2()
    {
        Console.WriteLine($"\n{new String('=', 55)}\nWelcome to Task2!\n{new String('=', 55)}");

        Console.WriteLine("Enter any numnber between 0 and 100: ");
        int guessNumber = Convert.ToInt32(Console.ReadLine());

        if (51 <= guessNumber && guessNumber <= 100)
            Console.WriteLine($"{new String('-', 55)}\nResult: the entered number belongs to [51 - 100]\n{new String('-', 55)}\n");
        else if (36 <= guessNumber && guessNumber <= 50)
            Console.WriteLine($"{new String('-', 55)}\nResult: the entered number belongs to [36 - 50]\n{new String('-', 55)}\n");
        else if (15 <= guessNumber && guessNumber <= 35)
            Console.WriteLine($"{new String('-', 55)}\nResult: the entered number belongs to [15 - 35]\n{new String('-', 55)}\n");
        else if (0 <= guessNumber && guessNumber <= 14)
            Console.WriteLine($"{new String('-', 55)}\nResult: the entered number belongs to [0 - 14]\n{new String('-', 55)}\n");
        else
            Console.WriteLine($"{new String('-', 55)}\nResult: the entered number does not belong to any of the number ranges: [0 - 14] [15 - 35] [36 - 50][50 - 100]\n{new String('-', 55)}\n");

    }

    private static void Task3()
    {
        Console.WriteLine($"\n{new String('=', 55)}\nWelcome to Task3!\n{new String('=', 55)}");
        Console.WriteLine("Enter any word from the \"Weather\" topic: ");

        string? searchWord = Console.ReadLine();
        string searchResult = default;
        bool isNothingFound = default;

        switch (searchWord)
        {
            case "дождь":
                searchResult = "rain";
                break;
            case "облачно":
                searchResult = "cloudy";
                break;
            case "температура":
                searchResult = "temperature";
                break;
            case "давление":
                searchResult = "pressure";
                break;
            case "дождик":
                searchResult = "shower";
                break;
            case "влажность":
                searchResult = "humidity";
                break;
            case "холодно":
                searchResult = "cold";
                break;
            case "жара":
                searchResult = "heat";
                break;
            case "ветер":
                searchResult = "wind";
                break;
            case "туман":
                searchResult = "fog";
                break;
            default:
                Console.WriteLine($"{new String('-', 55)}\nResult: no translation for this word\n{new String('-', 55)}\n");
                isNothingFound = true;
                break;
        }

        if (!isNothingFound) Console.WriteLine($"{new String('-', 55)}\nResult: {searchResult}\n{new String('-', 55)}\n");
    }
}
