using System.Drawing;
using System.Drawing.Imaging;

class SymbolMaker
{
    List<string> _symbol = new();
    public List<string> GetSymbool()
    {
        return _symbol;
    }
    
    public SymbolMaker(Point bounds, char c)
    {
        Bitmap canvas = new(bounds.X, bounds.Y, PixelFormat.Format16bppRgb555);
        Graphics g = Graphics.FromImage(canvas);


        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor; //only used for scaling?
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;


        StringFormat format = new()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        string[] fontoptions = { "", "Arial", "Consolas", "Courier New", "Lucidia Console", "Lucidia Sans Typewriter", "MS Gothic", "SimSun-Ext B", "TI Uni", "Ti73pc", "Ti83pc", "Verdana", "Tahoma", "Calibri" };

        /* Good fonts
        * 0
        * 4
        * 7
        * 11
        */

        Font font = new(fontoptions[2], canvas.Height + 1, FontStyle.Regular);
        SolidBrush brush = new(Color.White);

        g.DrawString(c.ToString(), font, brush, canvas.Width / 2 + 1, canvas.Height / 2, format);
        canvas.Save(@"C:\Users\benny\OneDrive\Desktop\test.bmp");

        //write image to string
        for (int j = 0; j < canvas.Height; j++)
        {
            _symbol.Add("");
            for (int i = 0; i < canvas.Width; i++)
            {
                //Console.Write(canvas.GetPixel(i, j).Name);
                Color pixel = canvas.GetPixel(i, j);
                _symbol[^1] += (pixel.GetBrightness() > .5 ? "#" : " ");
            }
        }
    }





    
}