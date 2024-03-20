using System;
using static CSharp._2__Calculations.DataValidation;

namespace CSharp._2__Calculations.Area_of_a_Rectangular_Room
{
    internal class RectangularRoomArea
    {
        private class Calculate
        {
            private readonly string unit;
            private readonly double? length;
            private readonly double? width;
            private readonly double? area;
            private readonly double? converted_area;
            private static readonly float CONVERSION_FACTOR = 0.09290304f;

            public Calculate(string _unit) 
            {
                unit = _unit;
                length = ValidatedNumber($"What is the length of the room in {_unit}? ");
                width = ValidatedNumber($"What is the width of the room in {_unit}? ");
                area = (length * width);
                converted_area = _unit == "feet" ? area * CONVERSION_FACTOR : area / CONVERSION_FACTOR;
                PrintDetails();
            }

            public void PrintDetails()
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

        static void Main5()
        {
            short choice = (short)ValidatedNumber("[1] Feet\n[2] Meters\nEnter your choice: ", _min: 1, _max: 2);
            _ = choice == 1 ? new Calculate("feet") : new Calculate("meters");
        }
    }
}
