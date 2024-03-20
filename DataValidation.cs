using System;
namespace CSharp
{
    public static class DataValidation
    {
        public static dynamic ValidatedNumber(string prompt, dynamic _min = null, dynamic _max = null, string _sentinel = null, string _action = "end")
        {
            while (true)
            {
                string user_input;
                if (_sentinel != null)
                {
                    Console.Write(prompt.Remove(prompt.Length - 2) + $" (or type '{_sentinel}' to {_action}): ");
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
                    if (_min == null || _min <= number && _max == null || _max >= number)
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
