using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shapes
    {
        private Drawererer _drawererer;

        public Shapes()
        {
            _drawererer = new Drawererer();
        }

        public void DrawTriangle()
        {
            _drawererer.BeginDraw();
            _drawererer.DrawLine(1, 1);
            _drawererer.DrawLine(1, 1);
            _drawererer.DrawLine(1, 1);
            _drawererer.EndDraw();
        }
    }

    //This class is procedurally cohesive
    public class Drawererer
    {
        private InternalStuff _internalStuff;

        public InternalStuff BeginDraw()
        {
            _internalStuff = new InternalStuff();
            //Prepare graphics engine for drawing (if you draw without doing this funky things happen)
            return _internalStuff;
        }

        public InternalStuff DrawLine(int x, int y)
        {
            //Logic to draw line
            return _internalStuff;
        }

        public void EndDraw()
        {
            //Instruct graphics engine what drawing is complete(if you don't do this no game other game updates happen)
        }

        public class InternalStuff
        {
            public void EndDraw()
            {
                //Instruct graphics engine what drawing is complete(if you don't do this no game other game updates happen)
            }
        }
    }
}
