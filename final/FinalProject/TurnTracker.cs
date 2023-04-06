public class TurnTracker
{
    int turn = 0;

    List<string> _xASCII;
    List<string> _oASCII;

    public TurnTracker(Point size)
    {
        SymbolMaker s;

        s = new SymbolMaker(size, 'X');
        _xASCII = s.GetSymbool();

        s = new SymbolMaker(size, 'O');
        _oASCII = s.GetSymbool();
    }

    public List<string> Next()
    {
        turn++;
        return (turn % 2 == 1)? _xASCII : _oASCII;
    }
}