using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._1__Input_Processing_and_Output.Printing_Quotes
{
    internal class PrintingQuotes
    {
        // Create a program that prompts for a quote and an author.
        // Display the quotation and author as shown in the example output.
        static void Main2() // Rename to Main() to run
        {
            Console.Write("What is the quote? ");
            string quote = Console.ReadLine();

            Console.Write("Who said it? ");
            string speaker = Console.ReadLine();

            /*
            • Use a single output statement to produce this output,
              using appropriate string-escaping techniques for quotes.
            • If your language supports string interpolation or string
              substitution, don’t use it for this exercise. 
              Use string concatenation instead.
            */
            Console.Write(speaker + " says, " + quote);
            Console.WriteLine();
        }
    }
}
