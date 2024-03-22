namespace CSharp
{
    public static class DataValidation
    {
        public static T? ValidatedNumber<T>(string _prompt, string _sentinel, string _action = "end", T? _min = null, T? _max = null) where T : struct, IComparable<T>
        {
            while (true)
            {
                Console.Write(_sentinel != null ? $"{_prompt.Remove(_prompt.Length - 2)} (or type '{_sentinel}' to {_action}): " : _prompt);
                string? userInput = Console.ReadLine();

                if (userInput != null && _sentinel != null && userInput.Equals(_sentinel, StringComparison.CurrentCultureIgnoreCase))
                    return null;

                try
                {
                    T? number = (T?)Convert.ChangeType(userInput, typeof(T));

                    if ((_min == null || Comparer<T?>.Default.Compare(_min.Value, number) <= 0) && (_max == null || Comparer<T?>.Default.Compare(_max.Value, number) >= 0))
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine($"! Error: Input out of range. [{_min}-{_max}]");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("! Error: Input is Not-a-Number. Please try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("! Error: Input is too large or too small.");
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("! Error: Invalid type conversion.");
                }
            }
        }

        public static T ValidatedNumber<T>(string _prompt, T? _min = null, T? _max = null) where T : struct, IComparable<T>
        {
            while (true)
            {
                Console.Write(_prompt);
                string? userInput = Console.ReadLine();

                if (userInput == null)
                    return default;

                try
                {
                    T number = (T)Convert.ChangeType(userInput, typeof(T));

                    if ((_min == null || Comparer<T>.Default.Compare(_min.Value, number) <= 0) && (_max == null || Comparer<T>.Default.Compare(_max.Value, number) >= 0))
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine($"! Error: Input out of range. [{_min}-{_max}]");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("! Error: Input is Not-a-Number. Please try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("! Error: Input is too large or too small.");
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("! Error: Invalid type conversion.");
                }
            }
        }
    }
}
