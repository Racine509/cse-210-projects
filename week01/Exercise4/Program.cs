<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
=======

internal partial class Program
{
    private static void Main(string[] args)
    {
        {
            static void     using System;
(string[] args)
    {
        // Initialiser la liste des nombres
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter the list of numbers, type 0 when finished:");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Vérification de l'entrée utilisateur
            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                {
                    // Sortir de la boucle si l'utilisateur entre 0
                    break;
                }

                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
        }

        // Vérifier si des nombres ont été saisis
        if (numbers.Count > 0)
        {
            // Calculer la somme
            int sum = numbers.Sum();
            Console.WriteLine($"The sum of the numbers is: {sum}");

            // Calculer la moyenne
            double average = numbers.Average();
            Console.WriteLine($"The average of the numbers is: {average}");

            // Trouver le maximum
            int max = numbers.Max();
            Console.WriteLine($"The maximum of the numbers is: {max}");

            // Trouver le plus petit nombre positif
            int smallestPositive = numbers.Where(n => n > 0).Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            // Trier et afficher les nombres
            numbers.Sort();
            Console.WriteLine("The numbers sorted are:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
}
}
>>>>>>> 6b227fb (initiale commit or  update)

class Program
    {
<<<<<<< HEAD
        // Initialiser la liste des nombres
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter the list of numbers, type 0 when finished:");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Vérification de l'entrée utilisateur
            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                {
                    // Sortir de la boucle si l'utilisateur entre 0
                    break;
                }

                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
        }

        // Vérifier si des nombres ont été saisis
        if (numbers.Count > 0)
        {
            // Calculer la somme
            int sum = numbers.Sum();
            Console.WriteLine($"The sum of the numbers is: {sum}");

            // Calculer la moyenne
            double average = numbers.Average();
            Console.WriteLine($"The average of the numbers is: {average}");

            // Trouver le maximum
            int max = numbers.Max();
            Console.WriteLine($"The maximum of the numbers is: {max}");

            // Trouver le plus petit nombre positif
            int smallestPositive = numbers.Where(n => n > 0).Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            // Trier et afficher les nombres
            numbers.Sort();
            Console.WriteLine("The numbers sorted are:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
=======
        static void Main(string[] args)
    {
        // Your code here
        Console.WriteLine("Hello, World!");
        }
    }
>>>>>>> 6b227fb (initiale commit or  update)
