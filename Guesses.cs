/*
    Guesses_Class:
        Will take a guess and add it to the previous guesses list
        Methods:
            guess:
                tells user what the previous guesses were and asks for a new one
                stores the new one as current guess
                returns the current guess for the game to use
*/


class Guesses
{
    
    List <string> guesses = new List <string> ();

    public string TakeGuess()
    {
        Console.Write($"Your previous guesses are: ");
        foreach (string item in guesses)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("What would you like to guess?");
        string current_guess = Console.ReadLine() ?? "";
        this.guesses.Add(current_guess);
        return current_guess;
    }





    
}