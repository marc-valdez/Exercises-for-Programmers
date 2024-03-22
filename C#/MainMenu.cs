using static CSharp.DataValidation;

namespace CSharp
{
    internal class MainMenu
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                var choices = new List<string>
                {
                    "[1] IPO",
                    "[2] Calculations"
                };
                foreach (var i in choices)
                    Console.WriteLine(i);
                var choice = ValidatedNumber("Enter your choice: ", _min: 1, _max: choices.Count, _sentinel:"EXIT");

                if (choice == null)
                {
                    Console.WriteLine("Thanks for using my program. <3");
                    Environment.Exit(0);
                }

                switch ((int)choice)
                {
                    case 1: Console.Clear(); IPOMenu.Show(); break;
                    case 2: Console.Clear(); CalculationsMenu.Show(); break;
                }
            }
        }
    }
}
