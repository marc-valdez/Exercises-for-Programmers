# Create a simple mad-lib program that prompts for a noun,
# a verb, an adverb, and an adjective and injects those into a
# story that you create.

class Madlib:
    def __init__(self):
        self.noun = input("Enter a noun: ")
        self.verb = input("Enter a verb: ")
        self.adjective = input("Enter an adjective: ")
        self.adverb = input("Enter an adverb: ")


madlib = Madlib()

# Use a single output statement for this program.
# If your language supports string interpolation or string substitution,
# use it to build up the output.

print(f"Do you {madlib.verb} your {madlib.adjective} {madlib.noun} {madlib.adverb}? That's hilarious!")
