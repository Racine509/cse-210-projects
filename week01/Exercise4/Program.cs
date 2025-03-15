using System;

class Program
{
    static void Main(string[] args)
    {
        list<int> numbers = new  list<int>();
        console.writeling(enter the list of numbers , type 0 when finished);
        while (true)
        {
            console.write("enter a number:");
            string input = console.readline();
            if (int.tryParse(input,out int number))
        }
        if(numbers = 0)
        {
            break;
        }
        nombres.add(numbers);
        else
        {
            console.writeling("invalid number");
        }
        if(numbers.count > 0)
        {
            int sum = numbers.sum();
            console.writeling($"the sum of the numbers is {sum}");
            double average = numbers.average();
            console.writeling($"the average of the numbers is {average}");
            int max = numbers.max();
            console.writeling($"the max of the numbers is {max}");
            int smallestpositive = numbers.where(n => n > 0).min ();
            console.writeling($"the smallest positive number is {smallestpositive}");
            numbers.sort();
            console.writeling("the numbers sorted are:");
            foreach(int number in numbers
            {
                console.writeling(number);
            }
            else
            {
                console.writeling("no numbers were entered");
            }
        }
    }
}
