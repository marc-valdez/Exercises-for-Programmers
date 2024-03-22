namespace CSharp.IPO
{
    internal class MadLib
    {
        internal string? noun, verb, adjective, adverb;
        internal MadLib() 
        {
            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter a verb: ");
            verb = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            adjective = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            adverb = Console.ReadLine();
        }

        // Create a simple mad-lib program that prompts for a noun,
        // a verb, an adverb, and an adjective
        // and injects those into a story that you create.
        public static void Main3()
        {
            MadLib madlib = new();

            /*
             • Use a single output statement for this program.
             • If your language supports string interpolation or string
               substitution, use it to build up the output.
            */
            Console.WriteLine($"Did you know that a {madlib.adjective} {madlib.noun} can {madlib.adverb} {madlib.verb}? I know! It's crazy!");
        }
    }
}
