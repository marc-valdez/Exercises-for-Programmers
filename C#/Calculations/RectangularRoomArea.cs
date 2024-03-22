using static CSharp.DataValidation;

namespace CSharp.Calculations
{
    internal class RectangularRoomArea
    {
        private class Room
        {
            private const double CONVERSION_FACTOR = 0.09290304;
            private readonly double length;
            private readonly double width;
            private double area;
            private double converted_area;
            private readonly string unit;

            public Room(string _unit)
            {
                unit = _unit;
                length = ValidatedNumber<double>($"What is the length of the room in {unit}? ");
                width = ValidatedNumber<double>($"What is the width of the room in {unit}? ");
                Calculate();
                Display();
            }

            private void Calculate()
            {
                area = length * width;
                converted_area = unit == "feet" ? area * CONVERSION_FACTOR : area / CONVERSION_FACTOR;
            }

            private void Display()
            {
                Console.WriteLine($"You entered dimensions of {length} {unit} by {width} {unit}.");
                Console.WriteLine("The area is: ");
                Console.WriteLine($"{area} square {unit}");
                if (unit == "feet")
                    Console.WriteLine($"{converted_area:F0} square meters");
                else
                    Console.WriteLine($"{converted_area:F0} square feet");
            }
        }

        public static void Main5()
        {
            sbyte choice = ValidatedNumber<sbyte>("[1] Feet\n[2] Meters\nEnter your choice: ", _min: 1, _max: 2);
            _ = choice == 1 ? new Room("feet") : new Room("meters");
        }
    }
}
