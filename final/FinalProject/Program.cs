using System;

class Program
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(40,40);

        Format format = new Format(ConsoleColor.Red, ConsoleColor.Cyan);

        Grid grid = new Grid(24, 24, format);
        TurnTracker tt = new(grid.getCellSize());

        grid.Draw();
        
        do
        {
            grid.select(tt.Next());
        }
        while(!grid.checkWinner());

        Console.SetCursorPosition(0, grid.End.Y + 2);
        Console.WriteLine("Good Job, winner! Press any key to end.");

        Console.Read();
    }
}