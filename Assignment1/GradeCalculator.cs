class GradeCalculator
{
    static void Main()
    {

while (true)
{
    Console.Write("Enter your grade (0-100) or type x to exit: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "x")
    {
        Console.WriteLine("Exiting program... Bye!");
        break;
    }

    // Try convert the input to a number
    if (int.TryParse(input, out int grade))
    {
        if (grade >= 90)
            Console.WriteLine("Your grade is: A");
        else if (grade >= 80)
            Console.WriteLine("Your grade is: B");
        else if (grade >= 70)
            Console.WriteLine("Your grade is: C");
        else if (grade >= 60)
            Console.WriteLine("Your grade is: D");
        else
            Console.WriteLine("Your grade is: F");
    }
    else
    {
        Console.WriteLine("Invalid input! Please enter a number or 'x' to exit.");
    }

    Console.WriteLine(); // for spacing
}
    }
}