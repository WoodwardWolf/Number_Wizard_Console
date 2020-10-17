
def start():

    global maxGuess, minGuess, guess
    maxGuess = 1000
    minGuess = 1
    guess = 500

    intro()
    minGuess = 0

    try:
        while True:
            print(f'Is Your Number {guess}?')
            response = input('Higher = h, Lower = l, Correct = c: ').lower()
            if response == 'h':
                minGuess = guess
                nextGuess()
            elif response == 'l':
                maxGuess = guess
                nextGuess()
            elif response == 'c':
                print(f'Your Number Must Be: {guess}!')
                start()
            else:
                print('Invalid Input')
    except:
        print('Something Went Wrong, Perhaps You Provided an Invalid Input')

def intro():
    print('Pick a Number')
    print(f'The Highest Possible Number is: {maxGuess}')
    print(f'The Lowest Possible Number is: {minGuess}')

def nextGuess():
    global maxGuess, minGuess, guess
    guess = round((maxGuess + minGuess) / 2)
    return

def main():
    start()

main()

