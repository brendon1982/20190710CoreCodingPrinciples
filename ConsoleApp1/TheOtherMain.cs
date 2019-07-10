using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ConsoleRendering;
using GameLogic;

namespace ConsoleApp1
{
    class TheOtherMain
    {
        public void Main()
        {
            var seedData = new List<Point>(); // would be read from args

            var renderer = new ConsoleGridRenderer();
            var gameOfLife = new GameOfLife(seedData, renderer);
            gameOfLife.Tick();
        }
    }
}
