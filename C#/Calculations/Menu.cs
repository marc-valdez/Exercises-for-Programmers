using CSharp.Calculations;
using System;
using System.Collections.Generic;
using static CSharp.DataValidation;

namespace CSharp
{
    internal class CalculationsMenu
    {
        public static void Show()
        {
            while(true)
            {
                Console.Clear();
                var choices = new List<string>
                {
                    "[1] Area of a Rectangular Room",
                    "[2] Pizza Party",
                    "[3] Paint Calculator",
                    "[4] Self-Checkout",
                    "[5] Determining Compound Interest"
                };
                foreach (var i in choices)
                    Console.WriteLine(i);
                var choice = ValidatedNumber("Enter your choice: ", _min: 1, _max: choices.Count, _sentinel: "BACK", _action: "go back");

                if (choice == null)
                    break;

                switch ((int)choice)
                {
                    case 1: Console.Clear(); RectangularRoomArea.Main5(); break;
                    case 2: Console.Clear(); PizzaParty.Main6(); break;
                    case 3: Console.Clear(); PaintCalculator.Main7(); break;
                    case 4: Console.Clear(); SelfCheckout.Main8(); break;
                    case 5: Console.Clear(); CompoundInterest.Main9(); break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
