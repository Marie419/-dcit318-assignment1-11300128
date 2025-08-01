using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter the 3 sides of the triangle (or type x to exit)");

            Console.Write("Side 1: ");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "x")
            {
                Console.WriteLine("Exiting Triangle Type Identifier... Bye!");
                break;
            }

            Console.Write("Side 2: ");
            string input2 = Console.ReadLine();
            if (input2.ToLower() == "x")
            {
                Console.WriteLine("Exiting Triangle Type Identifier... Bye!");
                break;
            }

            Console.Write("Side 3: ");
            string input3 = Console.ReadLine();
            if (input3.ToLower() == "x")
            {
                Console.WriteLine("Exiting Triangle Type Identifier... Bye!");
                break;
            }

            if (double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("This is an Equilateral triangle.");
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                    Console.WriteLine("This is an Isosceles triangle.");
                else
                    Console.WriteLine("This is a Scalene triangle.");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter valid numbers or 'x' to exit.");
            }

            Console.WriteLine(); // spacing
        }
    }
}
