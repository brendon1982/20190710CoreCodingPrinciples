using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using RenderingBoundary;

namespace ConsoleRendering
{
    public class ConsoleGridRenderer : IGridPresenter
    {
        public void Draw(Point p)
        {
            Console.WriteLine($"This would be fancy if people weren't looking at me {p.X}, {p.Y}");
        }
    }
}
