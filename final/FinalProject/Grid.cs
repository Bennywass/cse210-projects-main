public class Grid : DisplayObject
{
    List<VerticalLine> verticalboarder = new(); // List<VerticalLine>();
    List<HorizontalLine> HorizontalBoarder = new();
    List<List<Cell>> cells = new();

    public Grid(int endX, int endY)
    {
        Start = new(0, 0);
        End = new(endX, endY);

        for(int i = 0; i < 4; i++ )
        {
            HorizontalBoarder.Add(new HorizontalLine(this, Start.Y + i * (Height) / 3));
            verticalboarder.Add(new VerticalLine(this, Start.X + i * (Height) / 3));
        }

        
    }
    public override void Draw()
    {
        foreach(DisplayObject o in HorizontalBoarder)
            o.Draw();
        foreach(DisplayObject o in verticalboarder)
            o.Draw();
    }
}