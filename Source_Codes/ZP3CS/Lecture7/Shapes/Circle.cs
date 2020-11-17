using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Lecture7.DataClasses;

namespace Lecture7.Shapes
{
    public class Circle : IShape
    {
        public int Size { get; set; }

        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
