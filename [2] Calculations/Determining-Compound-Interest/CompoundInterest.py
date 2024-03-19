# Ensure that all the inputs are numeric
# and that the program will not let the user proceed without valid inputs.
def ValidatedNumber(prompt, _min=None, _max=None, _type=None, _sentinel=None):
    while True:
        if _sentinel is not None:
            user_input = input(prompt[:-2] + f" (or type \'{_sentinel}\' to end): ")
            if user_input.upper() == _sentinel:
                return None
        else:
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


# Write a program to compute the value of an investment compounded over time.
# The program should ask for the starting amount, the number of years to invest,
# the interest rate, and the number of periods per year to compound.
class CompoundInterest:
    def __init__(self):
        self.principal_amount = ValidatedNumber("What is the principal amount? ", _type="float")
        self.annual_rate = ValidatedNumber("What is the rate? ", _type="float")
        self.years_invested = ValidatedNumber("What is the number of years? ", _type="int")
        self.times_compounded = (ValidatedNumber(
            "What is the number of times the interest is compounded per year? ",
            _type="int"))

        # Prompt for the rate as a percentage (like 15, not .15).
        # Divide the input by 100 in your program.
        self.amount = (self.principal_amount *
                       (1 + (self.annual_rate / 100) / self.times_compounded)
                       ** (self.times_compounded * self.years_invested))

        # Ensure that fractions of a cent are rounded up to the next penny.
        # Ensure that the output is formatted as money
        print(f"${self.principal_amount:.2f} invested at {self.annual_rate}% for {self.years_invested} years"
              f" compounded {self.times_compounded} times per year is ${self.amount:.2f}.")


# Create a version of the program that works in reverse,
# so you can determine the initial amount you’d need to invest to reach a specific goal.
class InterestGoal:
    def __init__(self):
        # self.principal_amount = ValidatedNumber("What is the principal amount? ", _type="float")
        self.amount = ValidatedNumber("What is your goal amount? ", _type="float")
        self.annual_rate = ValidatedNumber("What is the rate? ", _type="float")
        self.years_invested = ValidatedNumber("What is the number of years? ", _type="int")
        self.times_compounded = (ValidatedNumber(
            "What is the number of times the interest is compounded per year? ",
            _type="int"))

        # Prompt for the rate as a percentage (like 15, not .15).
        # Divide the input by 100 in your program.
        self.principal_amount = (self.amount / (1 + (self.annual_rate / 100) / self.times_compounded)
                                 ** (self.times_compounded * self.years_invested))

        # Ensure that fractions of a cent are rounded up to the next penny.
        # Ensure that the output is formatted as money
        print(f"To get ${self.amount}, given the annual rate is {self.annual_rate}% for {self.years_invested} years"
              f" compounded {self.times_compounded} times per year."
              f"\nYou need to invest a principal amount of ${self.principal_amount:.2f}.")


print("[1] I want to know how much money I'll get after my investment period.")
print("[2] I want to know how much money I'll need to invest to reach a certain goal.")
choice = ValidatedNumber("Pick an option: ", _min=1, _max=2)
interest = choice == 1 and CompoundInterest() or InterestGoal()
