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

    public class Point
    {
        private int _x, _y;
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set => _x = Math.Clamp(value, 0, Console.WindowWidth);
        }
        public int Y
        {
            get { return _y; }
            set => _y = Math.Clamp(value, 0, Console.BufferHeight);
        }
    }


    public virtual void Draw(){}
    public virtual int Fill(char fillChar = ' ')
    {
        string s = new(fillChar, Width);
        for (int i = Start.Y; i <= End.Y; i++)
        {
            Console.SetCursorPosition(Start.X, i);
            Console.Write(s);
        }
        End.Y = Start.Y;
        return End.Y;
    }

    protected int Width
    {
        get { return End.X - Start.X; }
    }
    protected int Height
    {
        get { return End.Y - Start.Y; }
    }
}
