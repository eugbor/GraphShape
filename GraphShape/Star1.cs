using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphShape
{
    // Class heir gives access to members of the base class Shape
    //and provides an overriding implementation drawing method
    class Star1 : Shape
    {
        // givis access to the members of the base class
        //and created the variable color
        public Star1(int x, int y, ConsoleColor color)
            : base(x, y)
        {
            this.Color = color;
        }

        public ConsoleColor Color { get; set; }
       
        // redefined implementation drawing method
        public override void Draw()
        {
            Engine.SetPixel1(X + 0, Y + 0, this.Color);
            Engine.SetPixel1(X + 2, Y + 0, this.Color);
            Engine.SetPixel1(X + 0, Y + 2, this.Color);
            Engine.SetPixel1(X + 2, Y + 2, this.Color);
            Engine.SetPixel1(X + 1, Y + 1, this.Color);
        }
    }
}
