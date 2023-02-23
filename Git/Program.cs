public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!\n");

        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
    }

    private static void Task1()
    {
        Console.WriteLine($"\n{new string('=', 55)}\nWelcome to Task1!\n{new string('=', 55)}");

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
                    Console.WriteLine($"{new string('-', 55)}\nInvalid input data: division by zero is not allowed.\n{new string('-', 55)}\n");
                    IsInputDataError = true;
                    break;
                }
                else
                {
                    result = operand1 / operand2;
                }
                break;
            case "%":
                result = operand1 % operand2;
                break;
            default:
                break;
        }

        if (!IsInputDataError) Console.WriteLine($"{new string('-', 55)}\nResult: {result}\n{new string('-', 55)}\n");
    }

    private static void Task2()
    {
        Console.WriteLine($"\n{new string('=', 55)}\nWelcome to Task2!\n{new string('=', 55)}");

        Console.WriteLine("Enter any numnber between 0 and 100: ");
        int guessNumber = Convert.ToInt32(Console.ReadLine());

        if (51 <= guessNumber && guessNumber <= 100)
        {
            Console.WriteLine($"{new string('-', 55)}\nResult: the entered number belongs to [51 - 100]\n{new string('-', 55)}\n");
        }
        else if (36 <= guessNumber && guessNumber <= 50)
        {
            Console.WriteLine($"{new string('-', 55)}\nResult: the entered number belongs to [36 - 50]\n{new string('-', 55)}\n");
        }
        else if (15 <= guessNumber && guessNumber <= 35)
        {
            Console.WriteLine($"{new string('-', 55)}\nResult: the entered number belongs to [15 - 35]\n{new string('-', 55)}\n");
        }
        else if (0 <= guessNumber && guessNumber <= 14)
        {
            Console.WriteLine($"{new string('-', 55)}\nResult: the entered number belongs to [0 - 14]\n{new string('-', 55)}\n");
        }
        else
        {
            Console.WriteLine($"{new string('-', 55)}\nResult: the entered number does not belong to any of the number ranges: [0 - 14] [15 - 35] [36 - 50][50 - 100]\n{new string('-', 55)}\n");
        }

    }

    private static void Task3()
    {
        Console.WriteLine($"\n{new string('=', 55)}\nWelcome to Task3!\n{new string('=', 55)}");
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
                Console.WriteLine($"{new string('-', 55)}\nResult: no translation for this word\n{new string('-', 55)}\n");
                isNothingFound = true;
                break;
        }

        if (!isNothingFound) Console.WriteLine($"{new string('-', 55)}\nResult: {searchResult}\n{new string('-', 55)}\n");
    }

    private static void Task4()
    {
        Console.WriteLine($"\n{new string('=', 55)}\nWelcome to Task4!\n{new string('=', 55)}");
        Console.WriteLine("Enter any number for even-odd testing:");

        int numberTocheck = Convert.ToInt32(Console.ReadLine());
        string result;

        if ((numberTocheck % 2) == 0)
        {
            result = "even";
        }
        else
        {
            result = "odd";
        }
        Console.WriteLine($"Method 1: The number is {result}");

        if ((numberTocheck & 1) == 0)
        {
            result = "even";
        }
        else
        {
            result = "odd";
        }
        Console.WriteLine($"Method 2: The number is {result}");
    }

    private static void Task5()
    {
        Console.WriteLine($"\n{new string('=', 55)}\nWelcome to Task5!\n{new string('=', 55)}");

        Console.WriteLine("Enter the first triangle: ");
        string? firstSideValue = Console.ReadLine();

        Console.WriteLine("Enter the second triangle: ");
        string? secondSideValue = Console.ReadLine();

        Console.WriteLine("Enter the third triangle: ");
        string? thirdSideValue = Console.ReadLine();

        var operand1 = Convert.ToDouble(firstSideValue);
        var operand2 = Convert.ToDouble(secondSideValue);
        var operand3 = Convert.ToDouble(thirdSideValue);


        string resultExisting;
        string? resultIsAcute = default;
        double biggestNumber;

        biggestNumber = operand2 > operand1 ? operand2 : operand1;
        biggestNumber = biggestNumber > operand3 ? biggestNumber : operand3;
        //biggestNumber = Math.Max(operand1, Math.Max(operand2, operand3));
        //biggestNumber = new[] { operand1, operand2, operand3 }.Max();

        var isTriangleExist = operand1 + operand2 > operand3 && operand1 + operand3 > operand2 && operand2 + operand3 > operand1;
        var isItAcuteTriangle = Math.Pow(biggestNumber, 2) < (Math.Pow(operand2, 2) + Math.Pow(operand3, 2));

        if (isTriangleExist)
        {
            resultExisting = "triangle exists";
            if (isItAcuteTriangle)
            {
                resultIsAcute = "triangle is acute";
            }
            else
            {
                resultIsAcute = "triangle is not acute";
            }
        }
        else
        {
            resultExisting = "triangle does not exists";
        }

        Console.WriteLine($"Result: {resultExisting}");
        if (isTriangleExist)
        {
            Console.WriteLine($"Result: {resultIsAcute}");
        }
    }

    private static void Task6()
    {
        Console.WriteLine($"\n{new string('=', 55)}\nWelcome to Task6!\n{new string('=', 55)}");

        Console.WriteLine("Enter the first number: ");
        string? firstSideValue = Console.ReadLine();

        Console.WriteLine("Enter the second number: ");
        string? secondSideValue = Console.ReadLine();

        Console.WriteLine("Enter the third number: ");
        string? thirdSideValue = Console.ReadLine();

        Console.WriteLine("Enter the fourth number: ");
        string? foгrthSideValue = Console.ReadLine();

        var op1 = Convert.ToDouble(firstSideValue);
        var op2 = Convert.ToDouble(secondSideValue);
        var op3 = Convert.ToDouble(thirdSideValue);
        var op4 = Convert.ToDouble(foгrthSideValue);
        var isFirstConditionTrue = (op1 <= op2) && (op2 <= op3) && (op3 <= op4);
        var isSecondConditionTrue = (op1 > op2) && (op2 > op3) && (op3 > op4);

        if (isFirstConditionTrue)
        {
            op1 = op2 = op3 = op4;
        }
        else if (isSecondConditionTrue)
        {
        }
        else
        {
            op1 = Math.Pow(op1, 2);
            op2 = Math.Pow(op2, 2);
            op3 = Math.Pow(op3, 2);
            op4 = Math.Pow(op4, 2);
        }

        Console.WriteLine($"Result: \nFirst Number:{op1}\nSecond Number:{op2}\nThird Number:{op3}\nFourth Number:{op4}\n");
    }

    private static void Task7()
    {
        Console.WriteLine($"\n{new string('=', 55)}\nWelcome to Task6!\n{new string('=', 55)}");

        Console.WriteLine("Enter vertical coordinate #1 (number between 1 and 8): ");
        int firstVertValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter horizontal coordinate #1 (number between 1 and 8): ");
        int firstHorValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter vertical coordinate #2 (number between 1 and 8): ");
        int secondVertValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter horizontal coordinate #2 (number between 1 and 8): ");
        int secondHorValue = Convert.ToInt32(Console.ReadLine());


        bool isFirstBlack = (firstVertValue % 2 == 0 && firstHorValue % 2 == 0)|| (firstVertValue % 2 != 0 && firstHorValue % 2 != 0);
        bool isSecondBlack = (secondVertValue % 2 == 0 && secondHorValue % 2 == 0) || (secondVertValue % 2 != 0 && secondHorValue % 2 != 0);

        if (isFirstBlack == isSecondBlack)
        {
            Console.WriteLine($"Result: Fields have the same colour");
            Console.WriteLine($"Result: The horse does not threaten the field");
        }
        else
        {
            Console.WriteLine($"Result: Fields have different colours");
            Console.WriteLine($"Result: The horse threaten the field");
        }
    }
}
