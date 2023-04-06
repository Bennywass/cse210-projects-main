using System;
using System.Threading;
public abstract class Excersize
{
    protected string startingMessage;

    string excersizeMessage;

    public void displayEndMessage()
    {
       Console.WriteLine("You're done. Good Job!");
    }
    string endingMessage = "You're done. Good Job!";

    void displayAnimation()
    {

    }

    protected int userCount;

    public int userSeconds()
    {

        Console.WriteLine("How many seconds?");

        userCount = Convert.ToInt32(Console.ReadLine());

        return userCount;
    }

    protected void countDown(int seconds)
    {
        while(seconds > 0)
        {
        Console.Write("\b\b" + seconds.ToString().PadLeft(2, ' '));
        seconds--;
        Thread.Sleep(1000);
        }
    }

    protected void timer(Action act)
    {  
        timer(act, userCount);
    }
    protected void timer(Action act, int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while(futureTime > DateTime.Now)
        {
            act();
        }
    }

    public abstract void doExcersize();

    List<int> randList = new List<int>();


    protected string randNum(string[] array)
    {

        if (randList.Count() >= array.Count())
        {
            return "all option have been used.";
        }
        Random rand = new Random();

        int idx;

        do
        {
            idx = rand.Next(array.Count());
        }
        while(randList.Contains(idx));

        randList.Add(idx);




        return array[idx];
    }

}
