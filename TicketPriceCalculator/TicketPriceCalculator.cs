using System;

class TicketPriceCalculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter your age (or type x to exit): ");
            string? input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("No input detected. Exiting Ticket Price Calculator... Bye!");
                break;
            }

            if (input.ToLower() == "x")
            {
                Console.WriteLine("Exiting Ticket Price Calculator... Bye!");
                break;
            }

            if (int.TryParse(input, out int age))
            {
                int price = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Your ticket price is: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number or 'x' to exit.");
            }

            Console.WriteLine(); // spacing
        }
    }
}
