# Write a program to evenly divide pizzas.
# Prompt for the number of people, the number of pizzas, and the number of slices per pizza.
# Ensure that the number of pieces comes out even.
# Display the number of pieces of pizza each person should get.
# If there are leftovers, show the number of leftover pieces.
import math


# Revise the program to ensure that inputs are entered as numeric values.
# Don't allow the user to proceed if the value entered is not numeric.
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


class PizzaSplitter:
    def __init__(self):
        self.people = ValidatedNumber("How many people? ")
        self.pizzas = ValidatedNumber("How many pizzas do you have? ")
        self.slices = ValidatedNumber("How many slices per pizza? ") * self.pizzas
        self.pieces = int(self.slices / self.people)
        self.leftovers = self.slices % self.people

        # Alter the output so it handles pluralization properly.
        print(f"{int(self.people)} people with {int(self.pizzas)} pizzas")
        if self.pieces == 1:
            print(f"Each person gets 1 piece of pizza.")
        else:
            print(f"Each person gets {int(self.pieces)} pieces of pizza.")

        # Handle the output for leftover pieces appropriately as well.
        if self.leftovers == 0:
            print("There are no leftovers.")
        else:
            print(f"There are {int(self.leftovers)} leftover pieces.")


# Create a variant of the program that prompts for the number of people
# and the number of pieces each person wants,
# and calculate how many full pizzas you need to purchase.
class PizzaBuyer:
    def __init__(self):
        self.people = ValidatedNumber("How many people? ")
        self.slices = ValidatedNumber("How many slices are there per pizza? ")
        self.pieces = ValidatedNumber("How many slices does each person want? ")
        total_slices = self.people * self.pieces
        self.pizzas = math.ceil(total_slices / self.slices)
        self.leftovers = (self.pizzas * self.slices) - total_slices

        # Alter the output so it handles pluralization properly.
        print(f"{int(self.people)} people with {int(self.pieces)} slices each")
        if self.pizzas <= 1:
            print(f"You need to buy 1 full pizza.")
        else:
            print(f"You need to buy {int(self.pizzas)} full pizzas.")

        # Handle the output for leftover pieces appropriately as well.
        if self.leftovers == 0:
            print("There will be no leftovers.")
        else:
            print(f"There will be {int(self.leftovers)} leftover pieces.")


print("[1] I want to know how many slices each person should get.")
print("[2] I want to know how many pizzas I have to buy.")
choice = ValidatedNumber("Choose an option: ", 1, 2)
party = choice == 1 and PizzaSplitter() or PizzaBuyer()
