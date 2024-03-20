# Create a program that prompts for an input string
# and displays output that shows the input string
# and the number of characters the string contains.

user_input = input("What is the input string? ")

# If the user enters nothing, state that the user must enter something into the program.
if user_input == "":
    print("Please enter something.")
    exit()

# Use a built-in function of the programming language to determine the length of the string
number_of_characters = len(user_input)

# Be sure the output contains the original string.
# Use a single output statement to construct the output.
print(f"{user_input} has {number_of_characters} characters.")
