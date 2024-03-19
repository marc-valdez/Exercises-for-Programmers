using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPO.Counting_the_Number_of_Characters
{
    internal class NumberOfCharacters
    {
        /*
        Create a program that prompts for an input string 
        and displays output that shows the input string 
        and the number of characters the string contains.
        */
        static void Main1() // Rename to Main() to run
        {
            Console.Write("What is the input string? ");

            string userInput = Console.ReadLine();

            // If the user enters nothing, state that the user must enter something into the program.
            if (userInput == "")
            {
                Console.WriteLine("Please enter something...");
                Environment.Exit(1);
            }

            /*
            • Be sure the output contains the original string.
            • Use a single output statement to construct the output.
            • Use a built-in function of the programming language to determine the length of the string.
            */
            Console.WriteLine($"{userInput} has {userInput.Length} characters.");
        }
    }
}
