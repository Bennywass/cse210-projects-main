using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayObject d = new DisplayObject();

        d.Start = new DisplayObject.Point(0, 0);
        d.End = new DisplayObject.Point(10, 10);


        DisplayObject grid = new Grid(12, 12);

        grid.Draw();

        Console.Read();
    }
}