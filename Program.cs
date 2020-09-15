// Author: James Gaddis
// Date: 9/15/2020
// Comments: This C# Console application code demonstrates the use of a For Loop after getting input from a user

using System;

namespace TechProj2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Enter an Integer value between 1 and 25 to execute an interative statement: ");
            /*
                Use the try catch block to validate user input.
                If the user provides bad input, the catch block will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the various interative statemnets and is parsed as an interger
                int value_of_input = int.Parse(input);
                // If the value of user input is between 1 and 25, execute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                    // Here is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    // Paue the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                }
                // If the user does not enter a value between 1 and 25, display a message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);       
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace

