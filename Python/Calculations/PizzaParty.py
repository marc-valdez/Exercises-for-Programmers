# Revise the program to ensure that inputs are entered as numeric values.
# Don't allow the user to proceed if the value entered is not numeric.
from DataValidation import ValidatedNumber
import math


# Write a program to evenly divide pizzas.
# Prompt for the number of people, the number of pizzas, and the number of slices per pizza.
# Ensure that the number of pieces comes out even.
# Display the number of pieces of pizza each person should get.
# If there are leftovers, show the number of leftover pieces.


class PizzaSplitter:
    def __init__(self):
        self.people = ValidatedNumber("How many people? ")
        self.pizzas = ValidatedNumber("How many pizzas do you have? ")
        self.slices = ValidatedNumber("How many slices per pizza? ") * self.pizzas
        self.pieces = math.floor(self.slices / self.people)
        self.leftovers = self.slices % self.people

        # Alter the output so it handles pluralization properly.
        plurality = int(self.pizzas) == 1 and "pizza" or "pizzas"
        print(f"{int(self.people)} people with {int(self.pizzas)} {plurality}")

        if self.pieces == 0:
            print("There aren't enough pizzas.")
        elif self.pieces == 1:
            print("Each person gets a piece of pizza.")
        else:
            print(f"Each person gets {int(self.pieces)} pieces of pizza.")

        # Handle the output for leftover pieces appropriately as well.
        if self.leftovers == 0:
            print("There are no leftovers.")
        elif self.leftovers == 1:
            print(f"There is one leftover piece.")
        else:
            print(f"There are {int(self.leftovers)} leftover pieces.")


# Create a variant of the program that prompts for the number of people
# and the number of pieces each person wants,
# and calculate how many full pizzas you need to purchase.
class PizzaBuyer:
    def __init__(self):
        self.people = ValidatedNumber("How many people? ")
        self.slices = ValidatedNumber("How many slices are there per pizza? ")
        self.pieces = ValidatedNumber("How many slices does each person want? ") * self.people
        self.pizzas = math.ceil(self.pieces / self.slices)
        self.leftovers = (self.pizzas * self.slices) - self.pieces

        # Alter the output so it handles pluralization properly.
        plurality = int(self.pieces / self.people) == 1 and "slice" or "slices"
        print(f"{int(self.people)} people with {int(self.pieces / self.people)} {plurality} each")

        plurality = int(self.pizzas) <= 1 and "pizza" or "pizzas"
        print(f"You need to buy {int(self.pizzas)} full {plurality}.")

        # Handle the output for leftover pieces appropriately as well.
        if self.leftovers == 0:
            print("There will be no leftovers.")
        elif self.leftovers == 1:
            print(f"There will be one leftover.")
        else:
            print(f"There will be {int(self.leftovers)} leftover pieces.")


print("[1] I want to know how many slices each person should get.")
print("[2] I want to know how many pizzas I have to buy.")
choice = ValidatedNumber("Choose an option: ", 1, 2)
party = choice == 1 and PizzaSplitter() or PizzaBuyer()
