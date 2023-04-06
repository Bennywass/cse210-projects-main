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