
using Game;

public class Program
{
    private static int bulls;
    private static int cows;


    static void Main(string[] args)
    {
        string compNumber = "3456";
        Console.WriteLine("Enter the four-digit number:");
        var userNumber = Console.ReadLine();
        var IsSuccess = ValidateUserNumber(userNumber);
        EvaluateInputData(userNumber, compNumber);
    }

    private static void EvaluateInputData(string userNumber, string compNumber)
    {
        var inputNumber = userNumber.ToArray();
        var guessedNumber = compNumber.ToArray();

        //foreach (var item in inputNumber)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine();

        //foreach (var item in guessedNumber)
        //{
        //    Console.WriteLine(item);
        //}

        for (int i = 0; i < 4; i++)
        {
            if (inputNumber[i] == guessedNumber[i])
            {
                bulls += 1;
            }
        }

    }

    public static bool ValidateUserNumber(string userNumber)
    {
        if (!string.IsNullOrEmpty(userNumber) && userNumber.Length < 5 && userNumber.All(char.IsDigit))
        {
            return true;
        }
        else
        {
            throw new WrongFormatException("Password is wrong");
        }
    }
}
