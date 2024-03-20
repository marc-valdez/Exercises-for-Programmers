using System;
using static CSharp._2__Calculations.DataValidation;

namespace CSharp._2__Calculations.Pizza_Party
{
    internal class PizzaParty
    {
        class PizzaSplitter
        {
            private readonly short people;
            private readonly short pizzas;
            private readonly short slices;
            private readonly short pieces;
            private readonly short leftovers;
            public PizzaSplitter()
            {
                people = (short)ValidatedNumber("How many people? ");
                pizzas = (short)ValidatedNumber("How many pizzas do you have? ");
                slices = (short)(ValidatedNumber("How many slices per pizza? ") * pizzas);
                pieces = (short)(slices / people);
                leftovers = (short)(slices % people);

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
        }

        class PizzaBuyer
        {
            private readonly short people;
            private readonly short pizzas;
            private readonly short slices;
            private readonly short pieces;
            private readonly short leftovers;
            public PizzaBuyer()
            {
                people = (short)ValidatedNumber("How many people? ");
                slices = (short)ValidatedNumber("How many slices are there per pizza? ");
                pieces = (short)(ValidatedNumber("How many slices does each person want? "));
                var total_slices = (short)(people * pieces);
                pizzas = (short)Math.Ceiling((decimal)(total_slices / slices));
                leftovers = (short)(slices % people);

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

        static void Main()
        {
            Console.WriteLine("[1] I want to know how many slices each person should get.");
            Console.WriteLine("[2] I want to know how many pizzas I have to buy.");
            short choice = (short)ValidatedNumber("Choose an option: ", _min: 1, _max: 2, _type: "short");
            if (choice == 1)
                _ = new PizzaSplitter();
            else
                _ = new PizzaBuyer();
        }
    }
}
