using System;

class Program
{
    static void Main(string[] args)
    {
Console.Write("What is the magic number? ");
        int magicNum = int.Parse(Console.ReadLine());
        int guess = -1;

        
        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher! You gotta do better than that!");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower! Come on! TRY HARDER!!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}

  

         //Q&A with lifeline
          /*int lives = 5;
          string lucky = "69";
          string answer;

        while (lives > 0)
        {
            Console.WriteLine("Life: " + lives);
            Console.Write("What is the lucky number? ");
            Console.WriteLine();
            Console.Write("The lucky number is: ");
            answer = Console.ReadLine();

            if (answer.Equals(lucky))
            {
                Console.Write("Congrats");
                break;
            }
            else lives--;
            
            if (lives == 0) Console.Write("Idiot");
            Console.WriteLine();
            Console.WriteLine();

        } */