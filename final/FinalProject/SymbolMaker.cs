using System.Drawing;
using System.Drawing.Imaging;
using System;

abstract class SymbolMaker
{

//     SymbolMaker(char c, DisplayObject cell)
//     {
//         Bitmap canvas = new(, PixelFormat.Format16bppRgb555);
//         Graphics g = Graphics.FromImage(canvas);
//         //Rectangle canvas = new(0, 0, b.Width, b.Height);


//         g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor; //only used for scaling?
//         g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
//         g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
//         g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;


//         StringFormat format = new()
//         {
//             Alignment = StringAlignment.Center,
//             LineAlignment = StringAlignment.Center
//         };

//         string[] fontoptions = { "", "Arial", "Consolas", "Courier New", "Lucidia Console", "Lucidia Sans Typewriter", "MS Gothic", "SimSun-Ext B", "TI Uni", "Ti73pc", "Ti83pc", "Verdana", "Tahoma", "Calibri" };

//         /* Good fonts
//         * 0
//         * 4
//         * 7
//         * 11
//         */

//         Font font = new(fontoptions[0], 16, FontStyle.Bold);
//         SolidBrush brush = new(Color.White);

//         g.DrawString(@"AGg", font, brush, canvas.Width / 2, canvas.Height / 2, format);
//         //g.Flush();

//         //write image to cosole
//         Console.WriteLine(Color.White.Name.ToString());
//         for (int j = 0; j < canvas.Height; j++)
//         {
//             for (int i = 0; i < canvas.Width; i++)
//             {
//                 //Console.Write(canvas.GetPixel(i, j).Name);
//                 Color pixel = canvas.GetPixel(i, j);
//                 Console.Write(pixel.GetBrightness() > .5 ? "[]" : "  ");
//             }
//             Console.WriteLine();
//         }
//     }





    
}