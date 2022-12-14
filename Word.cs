/*
Will store the current word that needs to be guessed.
    Methods: 
        setter:
            to set the word to something random or a user input
        getter:
            to get the set word
*/


// Word_Class:
class Word{
    Random random = new Random ();


    // Will store the current word that needs to be guessed.
    List <string> word = new List <string> ();

    // Methods: 
    
    // setter:
        // to set the word to something random or a user input
    public void Setter()
    {
        string fullWord = "";
        do
        {
            Console.WriteLine("Would you like to (1)put in your own word or (2)get a random one?");
            string input = Console.ReadLine() ?? "";
            if (input == "1")
            {
                Console.WriteLine("What would you like your word to be?");
                fullWord = Console.ReadLine() ?? "";
                break;
            }
            else if (input == "2")
            {
                List <string> possibleWords = new List<string> {"climate", "dragon", "likely", "wriggle", "general", "total", "fibre", "credit", "laborer", "diagram", "slow", "reveal", "overeat", "salt", "horn", "glide", "grain", "inquiry", "rebel", "charm", "loot", "visible", "cope", "moving", "remark", "dictate", "sausage", "session", "family", "bike", "ballot"};
                fullWord = possibleWords[random.Next(possibleWords.Count)];
            }
        } while (true);
        var char_word = fullWord.ToCharArray();
        List<string> wordList = new List<string> ();
        for (int i = 0; i == char_word.Length; i += 1)
        {
            wordList.Add(char_word[i].ToString());
        }
        this.word = wordList;
    }

    // getter:
        // to get the set word
    public List<string> Getter()
    {
        return word;
    }
}