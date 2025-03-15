using System;

class Program
{
    static void Main(string[] args)
    {
        // Générer un nombre aléatoire entre 1 et 100
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int guess = 0;
        bool hasGuessed = false;

        Console.WriteLine("Guess a number between 1 and 100");

        while (!hasGuessed)
        {
            Console.Write("What is your guess? ");
            
            // Vérification de la validité de l'entrée utilisateur
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                // Comparaison avec le nombre magique
                if (guess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    hasGuessed = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
