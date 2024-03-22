using static CSharp.DataValidation;

namespace CSharp.Calculations
{
    internal class PizzaParty
    {
        private class Pizza
        {
            private static short people;
            private static short pizzas;
            private static short slices;
            private static short pieces;
            private static short leftovers;

            public Pizza(string _method)
            {
                people = ValidatedNumber<short>("How many people? ");
                if (_method == "splitter")
                    Splitter();
                else
                    Buyer();
            }

            private static void Splitter()
            {
                // Input
                pizzas = ValidatedNumber<short>("How many pizzas do you have? ");
                slices = (short)(ValidatedNumber<short>("How many slices per pizza? ") * pizzas);

                // Process
                pieces = (short)(slices / people);
                leftovers = (short)(slices % people);

                // Output
                Console.WriteLine($"{people} people with {pizzas} pizzas");
                if (pieces == 1)
                    Console.WriteLine($"Each person gets 1 piece of pizza.");
                else
                    Console.WriteLine($"Each person gets {pieces} pieces of pizza.");

                if (leftovers == 0)
                    Console.WriteLine("There are no leftovers.");
                else
                    Console.WriteLine($"There are {leftovers} leftover pieces.");
            }
            private static void Buyer()
            {
                // Input
                pieces = ValidatedNumber<short>("How many slices does each person want? ");
                slices = ValidatedNumber<short>("How many slices are there per pizza? ");

                // Process
                var total_slices = people * pieces;
                pizzas = (short)Math.Ceiling((decimal)(total_slices / slices));
                leftovers = (short)(total_slices % people);

                // Output
                Console.WriteLine($"{people} people with {pieces} slices each");
                if (pieces <= 1)
                    Console.WriteLine($"You need to buy 1 full pizza.");
                else
                    Console.WriteLine($"You need to buy {pizzas} full pizzas.");

                if (leftovers == 0)
                    Console.WriteLine("There will be no leftovers.");
                else
                    Console.WriteLine($"There will be {leftovers} leftover pieces.");
            }
        }

        public static void Main6()
        {
            Console.WriteLine("[1] I want to know how many slices each person should get.");
            Console.WriteLine("[2] I want to know how many pizzas I have to buy.");
            sbyte choice = ValidatedNumber<sbyte>("Choose an option: ", _min: 1, _max: 2);
            _ = (choice == 1) ? new Pizza("splitter") : new Pizza("buyer");
        }
    }
}
