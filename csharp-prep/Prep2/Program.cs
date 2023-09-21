using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        plus =  

        Console.WriteLine($"Your grade is: {grade}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! you passed! Great Job!");
        }
        else
        {
            Console.WriteLine("Oh no! Unfortunately, you did not pass.");
        }
    }
}

/*Console.Write("What is your percentage? ");
        string percentage = Console.ReadLine();
                
        int percent = int.Parse(percentage);

        if (percent >= 90)
        {
            Console.Write("Congratulations! You got an A. You passed with flying colors");
        }
        else if (percent >= 80)
        {
            Console.Write("Congratulations! You got a B. Great Job!");
        }
        else if (percent >= 70)
        {
            Console.Write("Congratulations! You got a C. You barely made it son.");
        }
        else if (percent >= 60)
        {
            Console.Write("Oh no! You got a D. Unfortunately, you did not pass. Please study more efficiently");
        }
        else
        {
            Console.Write("Oh no! You got an F. Try again next semester. Please study more efficiently");
        }
*/ 