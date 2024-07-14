namespace GuessingGameConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the game
            GuessingGame game = new GuessingGame();
            game.Start();
        }
    }

    public class GuessingGame
    {
        private int targetNumber;
        private readonly Random random;

        public GuessingGame()
        {
            random = new Random();
        }

        public void Start()
        {
            // Generating a random number between 1 and 100
            targetNumber = random.Next(1, 101);
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("Try to guess the number between 1 and 100.");

            bool guessedCorrectly = false;
            while (!guessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                int guess;

                if (int.TryParse(input, out guess))
                {
                    // Checking the user's guess
                    guessedCorrectly = CheckGuess(guess);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        private bool CheckGuess(int guess)
        {
            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Guess must be between 1 and 100.");
                return false;
            }

            if (guess == targetNumber)
            {
                Console.WriteLine("Correct! You've guessed the number.");
                return true;
            }

            if (guess < targetNumber)
            {
                Console.WriteLine("The number you entered is smaller than the target number.");
            }
            else
            {
                Console.WriteLine("The number you entered is greater than the target number.");
            }

            return false;
        }
    }
}
