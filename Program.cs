namespace HelloWorld {

class parachute_game {

public static void Main(){

word word = new word();

guess guesses = new guess();

word.the_word = word.random_word();
word.separate(word.the_word);

word.hidden(word.separated_word);

word.new_revealed = word.revealed;

//Console.Write(word.the_word);



parachute parachute = new parachute();


while(guesses.game_over(guesses.guesses, word.revealed, word.separated_word) == true)
{

    word.new_revealed = new List<char>(word.revealed);
    Console.WriteLine("");
    foreach (char i in word.revealed){
        Console.Write(i);
    }
    Console.WriteLine("");
    Console.WriteLine("Guess a letter ");


    
    string guess = Console.ReadLine()?? "";
    char [] guess_char = guess.ToCharArray();
    //Console.WriteLine(guess);

    

    word.guess(guess_char[0]);
    
    
    


    if (word.correct_guess(word.revealed, word.new_revealed) == false){
        guesses.add_guess();
    }
    //Console.WriteLine(guesses.guesses);

    Console.WriteLine();
    parachute.print_parachute(guesses.guesses, guesses.game_over(guesses.guesses, word.revealed, word.separated_word));


}


}

}

}