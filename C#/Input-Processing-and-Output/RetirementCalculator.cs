﻿using static CSharp.DataValidation;
namespace CSharp.IPO
{
    // Create a program that determines how many years you have
    // left until retirement and the year you can retire.
    // It should prompt for your current age and the age you want to retire
    // and display the output as shown in the example that follows.
    internal class RetirementCalculator
    {
        // Don't hard-code the current year into your program.
        // Get it from the system time via your programming language.
        static readonly short yearNow = (short)DateTime.Now.Year;

        public static void Main4() // Rename to Main() to run
        {
            byte age = ValidatedNumber<byte>("What is your current age? ");
            byte retirementAge = ValidatedNumber<byte>("At what age would you like to retire? ");

            byte yearsLeft = (byte)(retirementAge - age);
            // Handle situations where the program returns a negative
            // number by stating that the user can already retire.
            if (yearsLeft <= 0)
            {
                Console.WriteLine("You can already retire.");
                return;
            }

            Console.WriteLine($"You have {yearsLeft} years left until you can retire.");
            Console.WriteLine($"It's {yearNow}, so you can retire in {yearNow + yearsLeft}.");
        }
    }
}
