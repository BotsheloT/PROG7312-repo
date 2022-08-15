using System;
namespace VirtualEffects
{
	public class Shape
	{
        double x, y;

        public Shape()
        {
            this.x = 7;
            this.y = 5;
        }

        public virtual double calcArea()
        {
            //Result
            return x * y;
        }

        public class Rectangle : Shape
        {

        }

        public class Circle
        {

        }
    }
}

