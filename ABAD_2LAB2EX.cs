using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("WELCOME TO YOUR COMPUTE AVERAGE APP.");

        // Sleep for 1 seconds (100 milliseconds)
        Thread.Sleep(100);

   

        // Another example of using Thread.Sleep in a loop
        for (int i = 6; i > 1; i--)
        {
            Console.WriteLine($"Waiting in ... {i - 1}");
            Thread.Sleep(1000); // Sleep for 1 second (1000 milliseconds)
        }
       

        // Simulating a delay before asking for user input
        Thread.Sleep(100);
        Console.WriteLine("Let's get started with your student number:");

        while (true)
        {
            // You must enter 4-2-3 code
            Console.Write("Enter your student number: ");
            string number = Console.ReadLine();

            if (System.Text.RegularExpressions.Regex.IsMatch(number, @"^\d{4}-\d{2}-\d{3}$"))
            {
                Console.WriteLine("Hello! Kindly enter your grades:");

                // Sleep before asking for grades
                Thread.Sleep(100);
                float mathematics = ReadGrade("MATHEMATICS");
                Thread.Sleep(100);
                float science = ReadGrade("SCIENCE");
                Thread.Sleep(100);
                float history = ReadGrade("HISTORY");
                Thread.Sleep(100);
                float filipino = ReadGrade("FILIPINO");
                Thread.Sleep(100);
                float english = ReadGrade("ENGLISH");

                // Calculate and display average with a delay
                float average = (mathematics + science + history + filipino + english) / 5;
                Thread.Sleep(1000);

                float roundOffValue = (float)Math.Round(average);
                Console.WriteLine($"Your average is {average:F2} and round off to {roundOffValue}"  );

                // Determine pass or fail with a delay
                Thread.Sleep(1000);
                if (average >= 75)
                {
                    Console.WriteLine("Congratulations! You passed!");
                }
                else
                {
                    Console.WriteLine("Sorry, you failed! Try harder!");
                }

                break;
            }
            else
            {
                Console.WriteLine("You entered an invalid student number! Please try again.");
            }
        }
    }

    // Method to read a grade from the user
    static float ReadGrade(string subject)
    {
        while (true)
        {
            Console.Write($"Enter your Grade in {subject}: ");
            string input = Console.ReadLine();

            // Try to parse the input
            if (float.TryParse(input, out float grade))
            {
                return grade;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}