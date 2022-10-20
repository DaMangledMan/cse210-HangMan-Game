/*
    Picture_Class:
        Will store what the hungman currently looks like
        Methods:
            setter
            getter
*/

class Picture
{

    int currentPicture = 0;
    
    
    string missed0 = @"
      ______
      |     |
      O     |
    / | \   |
     / \    |
    ________|__\_____
    ";

    string missed1 = @"
      ______
      |     |
      O     |
    / | \   |
     /      |
    ________|__\_____
    ";

    string missed2 = @"
      ______
      |     |
      O     |
    / | \   |
            |
    ________|__\_____
    ";

    string missed3 = @"
      ______
      |     |
      O     |
    / |     |
            |
    ________|__\_____
    ";

    string missed4 = @"
      ______
      |     |
      O     |
      |     |
            |
    ________|__\_____
    ";

    string missed5 = @"
      ______
      |     |
      O     |
            |
            |
    ________|__\_____
    ";

    string missed6 = @"
      ______
      |     |
            |
            |
            |
    _   ____|__/_____
         _             _   _   _
    \ / | | | |    |  | | |_  |_
     |  |_| |_|    |_ |_|  _| |_
    ";


    List <string> missed;
    
    public Picture()
    {
        missed = new List<string> {missed0, missed1, missed2, missed3, missed4, missed5, missed6};
    }

    public int setter()
    {
        this.currentPicture += 1;
        return currentPicture;
    }

    public string getter()
    {
        return missed[currentPicture];
    }
}