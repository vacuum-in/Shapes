using System;


namespace Shapes
{
    class Program
    {  
        static void Main(string[] args)
        {
            Rhombus rhombus = new Rhombus();
            rhombus._p1.X = 3;
            rhombus._p1.Y = 4;

            rhombus._p2.X = 12;
            rhombus._p2.Y = 4;

            rhombus._p3.X = 3;
            rhombus._p3.Y = 12;

            rhombus._p4.X = 12;
            rhombus._p4.Y = 12;
            rhombus.DisplayShape();
            rhombus.move(Direction.Left, 2);
            rhombus.DisplayShape(ConsoleColor.Red);
            Console.ReadKey();
        }
    }
}
