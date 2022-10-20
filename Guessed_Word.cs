/*
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
*/

class Guessed_Word
{

    List <string> guessed_word = new List <string> ();

    public void set_word(string word_)
    {
        char[] char_arr;
        char_arr = word_.ToCharArray();
        for (int i = 0; i >= char_arr.Length; i += 0)
        {
            guessed_word.Add("_");
            guessed_word.Add(char_arr[i].ToString());
        }
    }

    public void guess(string guess_)
    {
        
    }


}