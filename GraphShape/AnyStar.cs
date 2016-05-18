using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphShape
{
    // Class heir gives access to members of the base class Star
    //and provides an overriding implementation drawing method
    class AnyStar : Star
    {
        // givis access to the members of the base class
        //and created the variable color1, color2
        public AnyStar(int x, int y, ConsoleColor color1, ConsoleColor color2)
            : base(x, y, color1)
        {
            this.color1 = color1;
            this.color2 = color2;
        }

        private int i = 0;
        private ConsoleColor color1;
        private ConsoleColor color2;

        // overrides implementation drawing method
        public override void Draw()
        {
            this.Color = (this.i++) % 2 == 0 ? this.color1 : this.color2;
            base.Draw();
            while (i < 0) i++;
            {
                Engine.SetPixel1(i + X, i + Y, this.Color);
                Engine.SetPixel(X, i + Y, this.Color);
                Engine.SetPixel(i + X,  Y, this.Color);
            }
           
        }
    }
}
