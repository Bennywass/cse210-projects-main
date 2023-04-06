
public class Format
{
    ConsoleColor _foreground;
    ConsoleColor _background;

    public Format(ConsoleColor foreground, ConsoleColor background)
    {
        _foreground = foreground;
        _background = background;
    }

    public ConsoleColor Foreground { get { return _foreground; } }
    public ConsoleColor Background { get { return _background; } }
}