using CSharp.IPO;
using static CSharp.DataValidation;

namespace CSharp
{
    internal class IPOMenu
    {
        public static void Show()
        {
            while(true)
            {
                Console.Clear();
                var choices = new List<string>
                {
                    "[1] Counting the Number of Characters",
                    "[2] Printing Quotes",
                    "[3] MadLib",
                    "[4] Retirement Calculator"
                };
                foreach (var i in choices)
                    Console.WriteLine(i);
                var choice = ValidatedNumber("Enter your choice: ", _min: 1, _max: choices.Count, _sentinel: "BACK", _action: "go back");

                if (choice == null)
                    break;

                switch ((int)choice)
                {
                    case 1: Console.Clear(); NumberOfCharacters.Main1(); break;
                    case 2: Console.Clear(); PrintingQuotes.Main2(); break;
                    case 3: Console.Clear(); MadLib.Main3(); break;
                    case 4: Console.Clear(); RetirementCalculator.Main4(); break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
