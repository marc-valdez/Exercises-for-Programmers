using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._1__Input_Processing_and_Output.Retirement_Calculator
{
    // Create a program that determines how many years you have
    // left until retirement and the year you can retire.
    // It should prompt for your current age and the age you want to retire
    // and display the output as shown in the example that follows.
    internal class RetirementCalculator
    {
        // Don't hard-code the current year into your program.
        // Get it from the system time via your programming language.
        static readonly int yearNow = DateTime.Now.Year;
        static int IntValidation(string prompt)
        {
            int value = 0;
            Console.Write(prompt);
            try { value = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("! Error: NaN"); };
            return value;
        }

        static void Main4() // Rename to Main() to run
        {
            int age = IntValidation("What is your current age? ");
            int retirementAge = IntValidation("At what age would you like to retire? ");

            int yearsLeft = retirementAge - age;
            // Handle situations where the program returns a negative
            // number by stating that the user can already retire.
            if (yearsLeft <= 0)
            {
                Console.WriteLine("You can already retire.");
                Environment.Exit(0);
            }

            Console.WriteLine($"You have {yearsLeft} years left until you can retire.");
            Console.WriteLine($"It's {yearNow}, so you can retire in {yearNow + yearsLeft}.");
        }
    }
}
