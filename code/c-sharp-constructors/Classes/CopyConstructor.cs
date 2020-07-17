using System;

namespace c_sharp_constructors
{
    public class Circle
    {
        protected int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        // Copy Constructor
        public Circle(Circle shape)
        {
            _radius = shape._radius;
        }
    }
}


