using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number for the dividend:");
        string firstInput = Console.ReadLine();

        Console.WriteLine("Enter a number for the divisor:");
        string secondInput = Console.ReadLine();

        HandleDivision(firstInput, secondInput);

        Console.WriteLine("Program finished. Press any key to exit.");
        Console.ReadKey();
    }

    static void HandleDivision(string a, string b)
    {
        try
        {
            // Convert the strings into integers
            int numA = int.Parse(a);
            int numB = int.Parse(b);

            // Perform the division
            int answer = numA / numB;

            Console.WriteLine($"{numA} divided by {numB} equals {answer}");
        }
        catch (FormatException)
        {
            Console.WriteLine("That input wasn’t a valid number. Please enter whole numbers only.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Oops! Division by zero isn’t allowed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number you entered is way too big or too small for an integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something unexpected happened: {ex.Message}");
        }
    }
}
