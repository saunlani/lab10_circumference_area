using System;

namespace lab10_circumference_area
{
    class Program
    {

        /* Calculates circles circumference and area
         * displays error for invalid user data
         * results round to nearest 2 decimals
         * prompts user to continue
         * displays goodbye
         * uses a class named Circle to store the data
         * uses value of PI from System.Math Class
         * uses a validator and static methods to validate the data in the app.
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");

            bool RunProgram = true;
            while (RunProgram)
            {
                Console.Write("Please enter a radius:  ");
                string userradchoice = Console.ReadLine();

                if (Validator.NumberChecker(userradchoice) == false)
                {
                    Console.WriteLine("Invalid radius number.");
                    continue;
                }
                else
                {
                    int.TryParse(userradchoice, out int radiusnumber);
                    //calculates circ
                    Console.WriteLine("Circumference:  " + Circle.CalculateFormattedCircumference(radiusnumber));
                    //calculates area
                    Console.WriteLine("Area:  " + Circle.CalculateFormattedArea(radiusnumber));

                    RunProgram = AskToContinue();
                }
            }
        }


        static bool AskToContinue()
        {
            bool finalanswer = true;
            bool keepasking = true;

            while (keepasking)
            {
                Console.WriteLine("Continue? (y/n):  ");
                string response = Console.ReadLine();

                if (response.ToLower() != "y" && response.ToLower() != "n")
                {
                    Console.WriteLine("Please enter a valid response.");
                    continue;
                }
                else if (response.ToLower() == "y")
                {
                    finalanswer = true;
                    keepasking = false;
                }
                else if (response.ToLower() == "n")
                {
                    Console.WriteLine($"You created {Circle.Count} Circle objects.");
                    Console.WriteLine("Goodbye!");
                    finalanswer = false;
                    keepasking = false;
                }
            }
            return finalanswer;
        }
    }
}
