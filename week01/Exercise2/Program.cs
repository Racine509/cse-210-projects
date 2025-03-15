using System;

class Program
{
    static void Main(string[] args)
    {
        // Demander à l'utilisateur son pourcentage de note
        Console.Write("What is your grade percentage? ");
        int gradePercentage;
        
        // Vérification pour garantir une entrée valide
        while (!int.TryParse(Console.ReadLine(), out gradePercentage) || gradePercentage < 0 || gradePercentage > 100)
        {
            Console.WriteLine("Please enter a valid grade percentage between 0 and 100.");
        }

        // Déterminer le dernier chiffre pour le symbole (+ ou -)
        int lastNumber = gradePercentage % 10;
        string symbol = "";

        if (lastNumber >= 7)
        {
            symbol = "+";
        }
        else if (lastNumber < 3)
        {
            symbol = "-";
        }

        // Déterminer la lettre correspondant à la note
        string letterGrade;
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D"; 
        }
        else
        {
            letterGrade = "F";
        }

        // Afficher le résultat final avec le symbole
        Console.WriteLine($"Your letter grade is: {letterGrade}{symbol}");

        // Vérifier si l'utilisateur a réussi ou non
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}
