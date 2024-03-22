using static CSharp.DataValidation;

namespace CSharp.Calculations
{
    internal class CompoundInterest
    {
        class Interest
        {
            private readonly double principalAmount, annualRate, goal;
            private readonly byte yearsInvested, timesCompounded;

            public Interest(string _method)
            {
                if (_method == "predict")
                    principalAmount = ValidatedNumber("What is the principal amount? ");
                else if (_method == "invest")
                    goal = ValidatedNumber("What is your goal amount? ");

                annualRate = ValidatedNumber("What is the rate? ") / 100;
                yearsInvested = ValidatedNumber("What is the number of years? ");
                timesCompounded = ValidatedNumber("What is the number of times the interest is compounded per year? ");

                double incrementalFactor = 1 + (annualRate / timesCompounded);
                byte exponent = (byte)(timesCompounded * yearsInvested);
                double compound = Math.Pow(incrementalFactor, exponent);

                if (_method == "predict")
                    goal = principalAmount * compound;
                else if (_method == "invest")
                    principalAmount = goal / compound;
                Display(_method);
            }

            public void Display(string _method)
            {
                if (_method == "predict")
                    Console.WriteLine($"${principalAmount:F2} invested at {annualRate * 100}% for {yearsInvested} years" +
                                      $" compounded {timesCompounded} times per year is ${goal:F2}.");
                else if (_method == "invest")
                    Console.WriteLine($"To get ${goal}, given the annual rate is {annualRate * 100}% for {yearsInvested} years" +
                                      $" compounded {timesCompounded} times per year.");
                    Console.WriteLine($"You need to invest a principal amount of ${principalAmount:F2}.");
            }
        }

        public static void Main9()
        {
            Console.WriteLine("[1] I want to know how much money I'll get after my investment period.");
            Console.WriteLine("[2] I want to know how much money I'll need to invest to reach a certain goal.");
            var choice = ValidatedNumber("Pick an option: ", _min: 1, _max: 2);
            _ = choice == 1 ? new Interest("predict") : new Interest("invest");
        }
    }
}
