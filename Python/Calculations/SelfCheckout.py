# Revise the program to ensure that prices and quantities are entered as numeric values.
# Don't allow the user to proceed if the value entered is not numeric.
from DataValidation import ValidatedNumber

# Create a simple self-checkout system.
# Prompt for the prices and quantities of three items.
# Calculate the subtotal of the items.
# Then calculate the tax using a tax rate of 5.5%.
# Print out the line items with the quantity and total,
# and then print out the subtotal, tax amount, and total.
TAX_RATE = 0.055


# Keep the input, processing, and output parts of your program separate.
# Collect the input, then do the math operations and string building,
# and then print out the output.
class Item:
    def __init__(self, _i):
        self.price = ValidatedNumber(f"Enter the price of item {_i}: ", _sentinel="STOP")
        if self.price is None:
            raise ValueError
        self.quantity = ValidatedNumber(f"Enter the quantity of item {_i}: ", _sentinel="STOP")
        if self.quantity is None:
            raise ValueError
        self.subtotal = self.price * self.quantity


class Basket:
    def __init__(self, _items):
        self.items = _items
        self.subtotal = 0.0
        for each in self.items:
            self.subtotal += each.subtotal
        self.tax = self.subtotal * TAX_RATE
        self.total = self.subtotal + self.tax

    def display_totals(self):
        print(f"Subtotal: ${self.subtotal:.2f}")
        print(f"Tax: ${self.tax:.2f}")
        print(f"Total: ${self.total:.2f}")


items = []
i = 1
while True:
    try:
        items.append(Item(i))
    except ValueError:
        break
    i += 1

checkout = Basket(items)
checkout.display_totals()
