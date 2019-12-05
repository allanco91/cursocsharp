using System;
using System.Collections.Generic;
using System.Text;
using Abstract1.Entities.Enums;

namespace Abstract1.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
