using System;

namespace CSharp.IPO
{
    internal class PrintingQuotes
    {
        // Create a program that prompts for a quote and an author.
        // Display the quotation and author as shown in the example output.
        public static void Main2()
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
