public class VerticalLine : DisplayObject
{
    public VerticalLine(DisplayObject parent, int col)
    {
        Start = new(col, parent.Start.Y);
        End = new(col + 1, parent.End.Y);
    }
    public override void Draw()
    {
        Fill('|');
    }
}