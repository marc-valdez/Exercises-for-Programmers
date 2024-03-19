import math

# Use a constant to hold the conversion factor.
CONVERSION_FACTOR = 0.09290304


# Revise the program to ensure that inputs are entered as numeric values.
# Don’t allow the user to proceed if the value entered is not numeric.
def ValidatedNumber(prompt, _min=None, _max=None):
    while True:
        user_input = input(prompt)
        try:
            number = float(user_input)
            if (_min is None or _min <= number) and (_max is None or _max >= number):
                return number
            else:
                print(f"Input out of range. [{_min}-{_max}]")
        except ValueError:
            print("! Error: Input is NaN")


class RectangleRoom:
    # Keep the calculations separate from the output.
    def __init__(self, _unit):
        self.length = ValidatedNumber(f"What is the length of the room in {_unit}? ")
        self.width = ValidatedNumber(f"What is the width of the room in {_unit}? ")
        self.area = self.length * self.width
        self.unit = _unit
        self.converted_area = _unit == "feet" and self.area * CONVERSION_FACTOR or self.area / CONVERSION_FACTOR
        self.print_details()

    def print_details(self):
        print(f"You entered dimensions of {self.length} {self.unit} by {self.width} {self.unit}.")
        print("The area is: ")
        print(f"{self.area} square {self.unit}")
        if self.unit == "feet":
            print(f"{self.converted_area} square meters")
        else:
            print(f"{self.converted_area} square feet")


# Create a new version of the program that allows you to choose feet or meters for your inputs.
choice = ValidatedNumber("[1] Feet\n[2] Meters\nEnter your choice: ", 1, 2)
room = choice == 1 and RectangleRoom("feet") or RectangleRoom("meters")
