public class Grid : DisplayObject
{
    List<VerticalLine> _verticalboarder = new(); // List<VerticalLine>();
    List<HorizontalLine> _horizontalBoarder = new();
    List<List<Cell>> _cells = new();

    public Grid(int endX, int endY, Format selectedFormat)
    {
        Start = new(0, 0);
        End = new(endX, endY);

        for(int i = 0; i < 4; i++ )
        {
            _horizontalBoarder.Add(new HorizontalLine(this, Start.Y + i * (Height) / 3));
            _verticalboarder.Add(new VerticalLine(this, Start.X + i * (Height) / 3));
        }

        for(int i = 0; i < 3; i++){
            _cells.Add(new());
            for(int j = 0; j < 3; j++){
                int sx, sy, ex, ey;
                
                sx = _verticalboarder[i].Start.X + 1;
                sy = _horizontalBoarder[j].Start.Y + 1;
                ex = _verticalboarder[i + 1].Start.X;
                ey = _horizontalBoarder[j + 1].Start.Y - 1;

                _cells.Last().Add(new(sx, sy, ex, ey, selectedFormat));
            }
        }

    }
    public override void Draw()
    {
        foreach(DisplayObject o in _horizontalBoarder)
            o.Draw();
        foreach(DisplayObject o in _verticalboarder)
            o.Draw();
    }

    public Point getCellSize()
    {
        int w = _cells[0][0].Width;
        int h = _cells[0][0].Height;
        return new Point(w, h);
    }

    public void select(List<string> ASCII)
    {
        Point newCoords = new(0, 0);

        Point oldCoords = new(0, 0);

        ConsoleKey k;

        bool verifier = true;
        do
        {
            k = Console.ReadKey(true).Key;
            switch (k)
            {
                case(ConsoleKey.UpArrow):
                    newCoords.Y = Math.Clamp(oldCoords.Y - 1, 0, 2);
                break;

                case(ConsoleKey.DownArrow):
                    newCoords.Y = Math.Clamp(oldCoords.Y + 1, 0, 2);
                break;

                case(ConsoleKey.RightArrow):
                    newCoords.X = Math.Clamp(oldCoords.X + 1, 0, 2);
                break;
                    
                case(ConsoleKey.LeftArrow):
                    newCoords.X = Math.Clamp(oldCoords.X - 1, 0, 2);
                break;

                case(ConsoleKey.Enter):
                    if(_cells[oldCoords.X][oldCoords.Y].Filled == false)
                    {
                        _cells[oldCoords.X][oldCoords.Y].Filled = true;
                        verifier = false;
                    }
                break;
            }
            
            
            _cells[oldCoords.X][oldCoords.Y].Selected = false;
            _cells[oldCoords.X][oldCoords.Y].Fill();
            
            if(_cells[oldCoords.X][oldCoords.Y].Filled)
            {
                _cells[oldCoords.X][oldCoords.Y].Draw();
            }

            if(!_cells[newCoords.X][newCoords.Y].Filled)
            {
                _cells[newCoords.X][newCoords.Y].Contents = ASCII;
            }

            if(verifier)
            {
            _cells[newCoords.X][newCoords.Y].Selected = true;
            _cells[newCoords.X][newCoords.Y].Draw();
            }
            
            oldCoords.X = newCoords.X;
            oldCoords.Y = newCoords.Y;

        } while(verifier);
        
       

    }
    public bool checkWinner()
    {
        for( int i = 0; i < 3; i++)
        {
            if(_cells[i][0].Filled == _cells[i][1].Filled == _cells[i][2].Filled == true
                && _cells[i][0].Contents == _cells[i][1].Contents
                && _cells[i][0].Contents == _cells[i][2].Contents)
                {
                    return true;
                }
            
            if(_cells[0][i].Filled == _cells[1][i].Filled == _cells[2][i].Filled == true
                && _cells[0][i].Contents == _cells[1][i].Contents
                && _cells[0][i].Contents == _cells[2][i].Contents)
                {
                    return true;
                }
        
        }

        if(_cells[0][0].Filled == _cells[1][1].Filled == _cells[2][2].Filled == true
            && _cells[0][0].Contents == _cells[1][1].Contents
            && _cells[0][0].Contents == _cells[2][2].Contents)
            {
                return true;
            }
        
        if(_cells[0][2].Filled == _cells[1][1].Filled == _cells[2][0].Filled == true
            && _cells[1][1].Contents == _cells[0][2].Contents
            && _cells[1][1].Contents == _cells[2][0].Contents)
            {
                return true;
            }
        
        return false;
    }
}