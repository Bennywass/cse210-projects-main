using System;

class Program
{
    static void Main(string[] args)
    {
        // Slelect Excersize type.
        Excersize ex;

        Console.WriteLine("Welcome to a day of relaxation. Please select from the following excersizes.");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listening");
        Console.WriteLine();
        string userInput = Console.ReadLine();


        if (userInput == "1")
        {
            // breathing.userSeconds();
            // breathing.doExcersize();
            ex = new Breathing();
        }

        else if(userInput == "2")
        {
            ex = new Reflection();
        }

        else if(userInput == "3")
        {
            ex = new Listing();

        }
        
        else
        {
            Console.WriteLine("Invalid Input");
            return;
        }

    ex.userSeconds();
    ex.doExcersize();

    Console.WriteLine();
    ex.displayEndMessage();
    
    }
}