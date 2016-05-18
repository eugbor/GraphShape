using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GraphShape
{
    // Class combines cleaning, create the pixel and drawing methods
    static class Engine                             
    {
        // Cleaning method
        public static void Clean()                 
        {
            Console.Clear();
        }

        // Create the pixel method
        public static void SetPixel(int x, int y,  
        ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write("█");
        }

       public static void SetPixel1(int x, int y,
        ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write("☼");
        }

        // Drawing method
        public static void Draw(List<Shape> shapes) 
        {
            Engine.Clean();
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Thread.Sleep(1000);
        }
    }
}
