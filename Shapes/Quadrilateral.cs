using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Quadrilateral 
    {
        const byte AMOUNT_OF_SIDES = 4;
        public Point _p1;
        public Point _p2;
        public Point _p3;
        public Point _p4;

        public void move(Direction direction, int point)
        {
            if (direction == Direction.Down)
            {
                _p1.Y -= point;
                _p2.Y -= point;
                _p3.Y -= point;
                _p4.Y -= point;
            }
            if (direction == Direction.Up)
            {
                _p1.Y += point;
                _p2.Y += point;
                _p3.Y += point;
                _p4.Y += point;
            }
            if (direction == Direction.Left)
            {
                _p1.X -= point;
                _p2.X -= point;
                _p3.X -= point;
                _p4.X -= point;
            }
            if (direction == Direction.Right)
            {
                _p1.X += point;
                _p2.X += point;
                _p3.X += point;
                _p4.X += point;
            }
            
        }
        public void DisplayShape(ConsoleColor consoleColor = ConsoleColor.White)
        {
            Console.ForegroundColor = consoleColor;
            Console.SetCursorPosition(_p1.X, _p1.Y);
            Console.Write("#");
            Console.SetCursorPosition(_p2.X, _p2.Y);
            Console.Write("#");
            Console.SetCursorPosition(_p3.X, _p3.Y);
            Console.Write("#");
            Console.SetCursorPosition(_p4.X, _p4.Y);
            Console.Write("#");
        }

        //public Quadrilateral(Point p1, Point p2, Point p3, Point p4)
        //{
        //    if (!(p1.Equals(p2) || p1.Equals(p3) || p1.Equals(p4)))
        //    {
        //        _p1 = p1;
        //        if (!(p2.Equals(p3) || p2.Equals(p4)))
        //        {
        //            _p2 = p2;
        //            if (!(p3.Equals(p4)))
        //            {
        //                _p3 = p3;
        //                _p4 = p4;
        //            }
        //        }
        //    }
        //}
    }
}
