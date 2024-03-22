using static CSharp.DataValidation;
namespace CSharp.Calculations
{
    internal class PaintCalculator
    {
        private class PaintGallons
        {
            private const short ONE_GALLON = 350; // Square Feet
            private readonly float area;
            private readonly float gallons;

            public PaintGallons(string _roomType)
            {
                if (_roomType == "rectangular")
                {
                    float length = ValidatedNumber("Length: ");
                    float width = ValidatedNumber("Width: ");
                    area = length * width;
                }
                else if (_roomType == "round")
                {
                    float radius = ValidatedNumber("Radius: ");
                    area = (float)(Math.PI * radius);
                }
                else if (_roomType == "l-shaped")
                {
                    float length1 = ValidatedNumber("Length of the first rectangle: ");
                    float width1 = ValidatedNumber("Width of the first rectangle: ");
                    float area1 = length1 * width1;

                    float length2 = ValidatedNumber("Length of the second rectangle: ");
                    float width2 = ValidatedNumber("Width of the second rectangle: ");
                    float area2 = length2 * width2;

                    area = area1 + area2;
                }

                gallons = (float)Math.Ceiling(area / ONE_GALLON);
                string plurality = gallons <= 1 ? "gallon" : "gallons";
                Display(plurality);
            }

            private void Display(string plurality)
            {
                Console.WriteLine($"You will need to purchase {gallons} {plurality} of paint to cover {area:F0} square feet.");
            }
        }

        public static void Main7()
        {
            Console.WriteLine("[1] Square/Rectangular");
            Console.WriteLine("[2] Round");
            Console.WriteLine("[3] L-Shaped");
            float choice = ValidatedNumber("Enter your room type: ", _min: 1, _max: 3);
            if (choice == 1)
                _ = new PaintGallons("rectangular");
            else if (choice == 2)
                _ = new PaintGallons("round");
            else if (choice == 3)
                _ = new PaintGallons("l-shaped");
        }
    }
}
