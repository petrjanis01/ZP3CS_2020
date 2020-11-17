using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture7.Shapes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
}
