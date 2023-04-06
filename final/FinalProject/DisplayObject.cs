using System;
public class DisplayObject
{
    public Point Start  { get;  set; }
    public Point End    { get;  set; }

    // protected DisplayObject(int StartX, int StartY, int EndX = int.MaxValue)
    // {
    //     Start.X = StartX;
    //     Start.Y = StartY;

    //     End.X = EndX;
    //     End.Y = Start.Y;
    // }

    public virtual void Draw(){}
    public virtual int Fill(char fillChar = ' ')
    {
        string s = new(fillChar, Width);
        for (int i = Start.Y; i <= End.Y; i++)
        {
            Console.SetCursorPosition(Start.X, i);
            Console.Write(s);
        }
        return End.Y;
    }

    public int Width
    {
        get { return End.X - Start.X; }
    }
    public int Height
    {
        get { return End.Y - Start.Y; }
    }
}
