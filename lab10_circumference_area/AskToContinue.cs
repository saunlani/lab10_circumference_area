//using System;
//namespace lab10_circumference_area
//{
//    public class AskToContinue
//    {
//        public AskToContinue()
//        {
//            static bool AskToContinue()
//            {
//                bool finalanswer = true;
//                bool keepasking = true;

//                while (keepasking)
//                {
//                    Console.WriteLine("Continue? (y/n):  ");
//                    string response = Console.ReadLine();

//                    if (response.ToLower() != "y" && response.ToLower() != "n")
//                    {
//                        Console.WriteLine("Please enter a valid response.");
//                        continue;
//                    }
//                    else if (response.ToLower() == "y")
//                    {
//                        finalanswer = true;
//                        keepasking = false;
//                    }
//                    else if (response.ToLower() == "n")
//                    {
//                        Console.WriteLine($"You created {Circle.count} Circle objects.");
//                        Console.WriteLine("Goodbye!");
//                        finalanswer = false;
//                        keepasking = false;
//                    }
//                }
//                return finalanswer;
//            }
//        }
//    }
//}
