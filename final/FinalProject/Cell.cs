public class Cell : DisplayObject
{
    Format _selectedFormat;

    public List<string> Contents;

    public bool Filled = false;
    public bool Selected = false;

    public Cell(int startX, int startY, int endX, int endY, Format selectedFormat)
    {
        Start = new(startX, startY);
        End = new(endX, endY);
        _selectedFormat = selectedFormat;
    }

    public override void Draw()
    {
        if(Selected)
        {
            Console.ForegroundColor = _selectedFormat.Foreground;
            Console.BackgroundColor = _selectedFormat.Background;
        }
        
        int i = 0;
        foreach(string s in Contents)
        {
            Console.SetCursorPosition(Start.X, Start.Y + i);
            Console.Write(Contents[i]);
            i++;
        }

        Console.ResetColor();
    }
}