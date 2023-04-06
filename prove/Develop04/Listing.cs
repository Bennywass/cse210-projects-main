using System;

public class Listing : Excersize
{
    public Listing()
    {
        startingMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }

    string[] listingPrompts =  {"Who are people that you appreciate?", "What are personal strengths of yours?",
    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    List<string> userAnswers = new List<string>();

    public override void doExcersize()
    {
        string prompt = randNum(listingPrompts);

        Console.WriteLine(prompt);

        countDown(10);

        Console.WriteLine("List items until time runs out.");

        timer(listingExcersize);
        

        foreach(string item in userAnswers)
        {
            Console.WriteLine(item);
        }
    }

    void listingExcersize()
    {
        string userAnswer = Console.ReadLine();
        userAnswers.Add(userAnswer);
    }
    // Display user prompts
}