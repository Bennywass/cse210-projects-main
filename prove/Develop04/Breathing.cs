using System;
using System.Threading;

public class Breathing : Excersize
{
    public Breathing()
    {
        startingMessage = "This activity will help you relax by walking your through breathing in and out slowly.\n"
        + "Clear your mind and focus on your breathing.";
    }

    public override void doExcersize()
    {
        // while(true)
        // {
        //     Console.Write("\r Breathe in    ");
        //     countDown(5);
        //     //Thread.Sleep(1000);
        //     Console.Write("\r Breathe out   ");
        //     countDown(5);
        //     //Thread.Sleep(1000);
        // }


        timer(breathingExcersize);

    }

    void  breathingExcersize()
    {
        int delay = 5;
        breathDelay = 50;
        //*
        Console.Write("\r Breathe in    ");
        countDown(delay);
        Console.Write("\r Breathe out   ");
        countDown(delay);
        /*/
        int n = delay * 1000 / breathDelay;
        //Console.Write("\rBreathe... [" + new String('-', n) + "]" + new String('\b', n + 1));
        Console.Write("\rBreathe... [");
        timer(addBreath, delay);
        Console.Write("]\b");
        timer(subBreath, delay);
        //*/
    }
    int breathDelay;
    void addBreath() { Thread.Sleep(breathDelay); Console.Write("|"); }
    void subBreath() { Thread.Sleep(breathDelay); Console.Write("\b-\b"); }
    
    
}