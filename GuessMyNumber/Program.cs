int guess;
int min = 1;
int max = 100;
Random random = new Random();
int number = random.Next(min, max + 1);
int guesses = 0;

do
{
    Console.Write("Enter your guess between {0} and {1}: ", min, max);
    guess = Convert.ToInt32(Console.ReadLine());
    guesses++;

    if (guess == number)
    {
        Console.WriteLine("Congratulations! You guessed the number of {0} in {1} attempts.", number, guesses);
    }
    else if (guess < number)
    {
        Console.WriteLine("The number is greater than {0}.", guess);
    }
    else if (guess > number)
    {
        Console.WriteLine("The number is less than {0}.", guess);
    }

    Console.WriteLine();
}
while (guess != number);