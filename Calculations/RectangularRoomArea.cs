using System;
using static CSharp.DataValidation;

namespace CSharp.Calculations
{
    internal class RectangularRoomArea
    {
        private class Room
        {
            private const float CONVERSION_FACTOR = 0.09290304f;
            private readonly float? length;
            private readonly float? width;
            private float? area;
            private float? converted_area;
            private readonly string unit;

            public Room(string _unit)
            {
                unit = _unit;
                length = ValidatedNumber($"What is the length of the room in {unit}? ");
                width = ValidatedNumber($"What is the width of the room in {unit}? ");
                Calculate();
                Display();
            }

            private void Calculate()
            {
                area = (length * width);
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
            var choice = ValidatedNumber("[1] Feet\n[2] Meters\nEnter your choice: ", _min: 1, _max: 2);
            _ = choice == 1 ? new Room("feet") : new Room("meters");
        }
    }
}
