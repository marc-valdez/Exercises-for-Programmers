using System;
namespace CSharp._2__Calculations
{
    public static class DataValidation
    {
        public static dynamic ValidatedNumber(string prompt, short? _min = null, short? _max = null, string _sentinel = null)
        {
            while (true)
            {
                string user_input;
                if (_sentinel != null)
                {
                    Console.Write(prompt.Remove(prompt.Length - 2) + $" (or type '{_sentinel}' to end): ");
                    user_input = Console.ReadLine();
                    if (user_input.Equals(_sentinel, StringComparison.CurrentCultureIgnoreCase))
                        return null;
                }
                else
                {
                    Console.Write(prompt);
                    user_input = Console.ReadLine();
                }

                try
                {
                    float number = Convert.ToSingle(user_input);
                    if ((_min == null) || (_min <= number) && (_max == null) || (_max >= number))
                        return number;
                    else
                        Console.WriteLine($"Input out of range. [{_min}-{_max}]");
                }
                catch (FormatException)
                {
                    Console.WriteLine("! Error: Input is NaN");
                }
            }
        }
    }
}
