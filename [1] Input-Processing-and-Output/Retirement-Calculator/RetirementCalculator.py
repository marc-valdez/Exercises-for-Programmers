# Create a program that determines how many years you have
# left until retirement and the year you can retire.
# It should prompt for your current age and the age you want to retire
# and display the output as shown in the example that follows.

# Don't hard-code the current year into your program.
# Get it from the system time via your programming language.
import datetime
today = datetime.date.today()
year = today.year

age = input("What is your current age? ")
retirement_age = input("At what age would you like to retire? ")

# Again, be sure to convert the input to numerical data before doing any math.
age = int(age)
retirement_age = int(retirement_age)

years_left = retirement_age - age

# Handle situations where the program returns a negative number
# by stating that the user can already retire.
if years_left <= 0:
    print("You can already retire.")
    exit()

print(f"You have {years_left} years left until you can retire.")
print(f"It's {year}, so you can retire in {year + years_left}.")
