namespace HelloWorld{





class word {
    
    //get random word, seperate into list
    public string random_word() {
        List<string> word_list = new List<string>() {"dog", "cat", "giraffe", "wolf", "turtle", "rabbit"};
        //How many elements in the list
        int elements = word_list.Count;
        Random generator = new Random();
        int random = generator.Next(elements);

        return word_list[random];
    }

    public string the_word = "";

    
    public List<char> separated_word = new List<char>();
    public List<char> revealed = new List<char>();
    public List<char> new_revealed = new List<char>();
    



    public void separate(string word){
        char [] characters = word.ToCharArray();
        foreach (char i in characters) {
            separated_word.Add(i);
        }
    }

    public void hidden(List<char> word){
        int i = 0;
        List<char> work = new List<char>();
        foreach (char letter in word){

            work.Add('_');
            i++;
        }
        revealed = work;
        foreach (char a in revealed) {
            //Console.Write(a);
        }
        Console.WriteLine("");
    }
    

    public void guess(char guess){
        int count = the_word.Count()-1;
        int counter = 0;
        foreach (char i in this.separated_word) {
            if (guess == this.separated_word[counter]){
                //Console.WriteLine(counter);
                this.revealed[counter] = this.separated_word[counter];
                
            }
            counter+=1;
        }
    }
    public bool correct_guess(List<char> revealed, List<char> word){
        int count = revealed.Count()-1;
        for (int i = 0; i <= count; i++){
            
            if (revealed[i] != word[i]){
                return true;
            }
        }
        
        
        return false;

    }
        //Is this possible to do?
         //Then we wouldn't need to return discovered but we could check it against the orginal to see if any new letters have been discovered
    
    //intake guess letter, for loop to run through the string, checking if any of them equal yes
    
    //reveal the numbers

}

class play {
    
}

}