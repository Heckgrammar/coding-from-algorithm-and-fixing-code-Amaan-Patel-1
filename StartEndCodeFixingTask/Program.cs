using System;

class Program
{
    static void Main()
    {
        bool validChoice = false;
        int difference = -1;

        // Repeat until a valid choice is made
        while (!validChoice)
        {
            Console.Write("Enter a start year: ");
            int startYear = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter an end year: ");
            int endYear = Convert.ToInt32(Console.ReadLine());

            // Check if start year is before end year
            if (startYear >= endYear)
            {
                Console.WriteLine("Start year must be before end year.");
            }
            else if (startYear < 2000)
            {
                // Check if start year is before 2000
                Console.WriteLine("Start year must be 2000 or later.");
            }
            else
            {
                // Calculate the difference if conditions are valid
                difference = endYear - startYear;
                validChoice = true; // Mark valid choice
            }
        }

        // Output the calculated difference
        Console.WriteLine($"The difference is: {difference}");
    }
}
