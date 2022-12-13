namespace HelloWorld{



class guess {
    public int guesses = 0;
    public List<char> guessed = new List<char>();
    public void add_guess() {
        guesses += 1;
    }

    public void new_letter_guessed(List<char> letter, char the_guessed_letter){
        letter.Add(the_guessed_letter);
    }

    public bool game_over(int guesses, List<char> revealed, List<char> word){
        
            int number = revealed.Count()-1;
            int win = -1;
            for(int i = 0; i <= number; i++) 
            {
            if (revealed[i] == word[i]){
                win+=1;
            }
            }
            if (win == number){
                Console.WriteLine("You win!");
                return false;
            }
            
        
        if (guesses < 4) {
            return true;
        }
        Console.WriteLine("You Lose!");
        return false;
        
    }

}}