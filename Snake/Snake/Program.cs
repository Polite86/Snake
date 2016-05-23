using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorisontalLine Line = new HorisontalLine(5, 10, 8, '+'); 
            Line.Drow();

            VerticalLine VLine = new VerticalLine(12, 17, 8, '+');
            VLine.Drow();

            Console.ReadLine();
        }
    }
}
