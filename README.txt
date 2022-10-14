Author(S):
    Jacob Hutchens

Desription:
    The common hangman game played in schools across the country.

Design:
    Word_Class:
        Will store the current word that needs to be guessed.
        Methods: 
            setter:
                to set the word to something random or a user input
            getter:
                to get the set word
    Guesses_Class:
        Will take a guess and add it to the previous guesses list
        Methods:
            guess:
                tells user what the previous guesses were and asks for a new one
                stores the new one as current guess
            getter:
                for current guess
    Guessed_Word:
        Will hold the word with what is currently filled out
        Methods:
            Discover:
                gets the word from words class and creates blank version of word
            Guess:
                takes a guess and checks it against the word
                if it is there it fills in the blanks of the word
            getter:
                to get the blanked/partially filled word
    Picture_Class:
        Will store what the hungman currently looks like
        Methods:
            setter
            getter
    Round_Class:
        Methods:
            Round:
                runs the gameplay of a single round in hangman
                returns a boolean for whether the game is over or not
    Game_Class:
        Runs the startup code
        Runs the round method
        Runs the finish code