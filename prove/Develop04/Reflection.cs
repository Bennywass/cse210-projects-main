using System;

public class Reflection : Excersize
{

    public Reflection()
    {
        startingMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    string[] reflectionPromts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

    string[] reflectionQuestions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    string[] spinIcon = {"|", "/", "-", "\\"};
    int idx = 0;

    public override void doExcersize()
    {
        string prompt = randNum(reflectionPromts);

        //print first prompt
        Console.WriteLine(prompt);

        countDown(5);

        //enter timer1 print second promtp on repeat

        timer(reflectionExcersize);

    }

    void reflectionExcersize()
    {
        string question = randNum(reflectionQuestions);
        Console.WriteLine(question);
        timer(displaySpinner, 3);
        //countDown(5);
    }

    void displaySpinner()
    {
        Console.Write(spinIcon[idx % spinIcon.Count()]);
        idx++;
        Thread.Sleep(500);
        Console.Write("\b");
    }


        
    // void spinner()
    // {
    //     string[] spinIcon = {"|", "/", "-", "\\"};
    //     int idx = 0;
    //     while(true)
    //     {
    //         Console.Write(spinIcon[idx % spinIcon.Count()]);
    //         idx++;
    //         Thread.Sleep(500);
    //     }
    // }


}