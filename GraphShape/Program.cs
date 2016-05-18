using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphShape
{
    using System.Threading;
    class Program
    {
        static void Main(string[] args)
        {           
            var shapes = new List<Shape>();
            shapes.Add(new AnyStar(0, 0, ConsoleColor.Black, ConsoleColor.White));
            shapes.Add(new AnyStar(0, 2, ConsoleColor.Black, ConsoleColor.White));
            shapes.Add(new AnyStar(2, 0, ConsoleColor.Black, ConsoleColor.White));
            shapes.Add(new AnyStar(2, 2, ConsoleColor.Black, ConsoleColor.White));
            shapes.Add(new AnyStar(4, 0, ConsoleColor.Black, ConsoleColor.White));
            shapes.Add(new AnyStar(4, 2, ConsoleColor.Black, ConsoleColor.White));
            shapes.Add(new AnyStar(0, 4, ConsoleColor.Black, ConsoleColor.White));
            shapes.Add(new AnyStar(2, 4, ConsoleColor.Black, ConsoleColor.White));
            shapes.Add(new AnyStar(4, 4, ConsoleColor.Black, ConsoleColor.White));

            shapes.Add(new AnyStar1(0, 0, ConsoleColor.White, ConsoleColor.Black));
            shapes.Add(new AnyStar1(0, 2, ConsoleColor.White, ConsoleColor.Black));
            shapes.Add(new AnyStar1(2, 0, ConsoleColor.White, ConsoleColor.Black));
            shapes.Add(new AnyStar1(2, 2, ConsoleColor.White, ConsoleColor.Black));
            shapes.Add(new AnyStar1(4, 0, ConsoleColor.White, ConsoleColor.Black));
            shapes.Add(new AnyStar1(4, 2, ConsoleColor.White, ConsoleColor.Black));
            shapes.Add(new AnyStar1(0, 4, ConsoleColor.White, ConsoleColor.Black));
            shapes.Add(new AnyStar1(2, 4, ConsoleColor.White, ConsoleColor.Black));
            shapes.Add(new AnyStar1(4, 4, ConsoleColor.White, ConsoleColor.Black));

            while (true)
            {
                Engine.Draw(shapes);
            }
        }
    }
}
