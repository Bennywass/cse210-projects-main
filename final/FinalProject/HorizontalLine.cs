public class HorizontalLine : DisplayObject
{
    public HorizontalLine(DisplayObject parent, int row)
    {
        // Start.X = parent.Start.X;
        // End.X = parent.End.X;

        // End.Y = row;
        // Start.Y = row;
        Start = new(parent.Start.X, row);
        End = new(parent.End.X, row);
    }
    public override void Draw()
    {
        Fill('-');
    }
}