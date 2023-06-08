using System;
using Abstract_method.Entities.Enums;

namespace Abstract_method.Entities
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
