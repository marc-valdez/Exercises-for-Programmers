# Revise the program to ensure that inputs are entered as numeric values.
# Don't allow the user to proceed if the value entered is not numeric.
from DataValidation import ValidatedNumber

# Create a program that calculates the area of a room.
# Prompt the user for the length and width of the room in feet.
# Then display the area in both square feet and square meters.

# Use a constant to hold the conversion factor.
CONVERSION_FACTOR = 0.09290304


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
