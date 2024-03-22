def ValidatedNumber(prompt, _min=None, _max=None, _sentinel=None):
    while True:
        if _sentinel is not None:
            user_input = input(prompt[:-2] + f" (or type \'{_sentinel}\' to end): ")
            if user_input.upper() == _sentinel:
                return None
        else:
            user_input = input(prompt)
        try:
            number = float(user_input)
            if (_min is None or _min <= number) and (_max is None or _max >= number):
                return number
            else:
                print(f"Input out of range. [{_min}-{_max}]")
        except OverflowError:
            print("! Error: Input is too large.")
        except ValueError:
            print("! Error: Input is Not-a-Number.")
