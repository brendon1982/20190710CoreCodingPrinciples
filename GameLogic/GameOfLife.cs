using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using RenderingBoundary;

namespace GameLogic
{
    public class GameOfLife
    {
        private readonly List<Point> _seedData;
        private readonly IGridPresenter _gridPresenter;

        public GameOfLife(List<Point> seedData, IGridPresenter gridPresenter)
        {
            _seedData = seedData;
            _gridPresenter = gridPresenter;
        }

        public GameOfLife Tick()
        {
            var nextGeneration = new List<Point>();
            //Some funky logic that calculates the next gen
            nextGeneration.ForEach(point => { _gridPresenter.Draw(point); });
            return new GameOfLife(nextGeneration, _gridPresenter);
        }
    }
}
