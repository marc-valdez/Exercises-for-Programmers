# Create a simple self-checkout system.
# Prompt for the prices and quantities of three items.
# Calculate the subtotal of the items.
# Then calculate the tax using a tax rate of 5.5%.
# Print out the line items with the quantity and total,
# and then print out the subtotal, tax amount, and total.


# Revise the program to ensure that prices and quantities are entered as numeric values.
# Don’t allow the user to proceed if the value entered is not numeric.
def ValidatedNumber(prompt, _min=None, _max=None, _type=None):
    while True:
        user_input = input(prompt)
        # Be sure you explicitly convert input to numerical data before doing any calculations.
        try:
            number = float(user_input)
            if (_min is None or _min <= number) and (_max is None or _max >= number):
                return _type == "float" and number or int(number)
            else:
                print(f"Input out of range. [{_min}-{_max}]")
        except ValueError:
            print("! Error: Input is NaN")


TAX = 0.055


# Keep the input, processing, and output parts of your program separate.
# Collect the input, then do the math operations and string building,
# and then print out the output.

class Item:
    def __init__(self, _i):
        self.price = ValidatedNumber(f"Enter the price of item {_i}: ")
        self.quantity = ValidatedNumber(f"Enter the quantity of item {_i}: ")
        self.subtotal = self.price * self.quantity


class Basket:
    def __init__(self, _items):
        self.items = _items
        self.subtotal = 0.0
        for each in self.items:
            self.subtotal += each.subtotal
        self.tax = self.subtotal * TAX
        self.total = self.subtotal + self.tax

    def display_totals(self):
        print(f"Subtotal: ${round(self.subtotal, 2)}")
        print(f"Tax: ${round(self.tax, 2)}")
        print(f"Total: ${round(self.total, 2)}")


items = []
i = 1
item_count = ValidatedNumber("How many items do you have? ", _type="int")
while i <= item_count:
    items.append(Item(i))
    i += 1
checkout = Basket(items)
checkout.display_totals()
