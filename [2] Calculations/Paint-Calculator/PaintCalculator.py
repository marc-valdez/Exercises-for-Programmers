# Calculate gallons of paint needed to paint the ceiling of a room.
# Prompt for the length and width, and assume one gallon covers 350 square feet.
# Display the number of gallons needed to paint the ceiling as a whole number.
import math


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


# Use a constant to hold the conversion rate.
ONE_GALLON = 350  # square feet


class PaintGallons:
    def __init__(self, room_type=None):
        if room_type == "square":
            self.length = ValidatedNumber("Length: ")
            self.width = ValidatedNumber("Width: ")
            self.area = self.length * self.width
        # Implement support for a round room.
        elif room_type == "round":
            self.radius = ValidatedNumber("Radius: ")
            self.area = math.pi * (self.radius ** 2)
        # Implement support for an L-shaped room.
        elif room_type == "l-shaped":
            self.length1 = ValidatedNumber("Length of the first rectangle: ")
            self.width1 = ValidatedNumber("Width of the first rectangle: ")
            self.area1 = self.length1 * self.width1

            self.length2 = ValidatedNumber("Length of the second rectangle: ")
            self.width2 = ValidatedNumber("Width of the second rectangle: ")
            self.area2 = self.length2 * self.width2

            self.area = self.area1 + self.area2

        # Ensure that you round up to the next whole number.
        self.gallons = math.ceil(self.area / ONE_GALLON)

        if self.gallons <= 1:
            print(f"You will need to purchase 1 gallon of paint ")
        else:
            print(f"You will need to purchase {self.gallons} gallons of paint ")
        print(f"to cover {self.area} square feet.")


print("[1] Square/Rectangular")
print("[2] Round")
print("[3] L-Shaped")
choice = ValidatedNumber("Enter your room type: ", 1, 3)
if choice == 1:
    paint_buckets = PaintGallons("square")
elif choice == 2:
    paint_buckets = PaintGallons("round")
elif choice == 3:
    paint_buckets = PaintGallons("l-shaped")
