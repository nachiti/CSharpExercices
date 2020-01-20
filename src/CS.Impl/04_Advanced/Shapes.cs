using System;

namespace CS.Impl._04_Advanced
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    public class Circle : Shape
    {
         protected double radius;
         protected string Name = "Circle";
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return (int)(Math.PI* radius *radius);
        }

        public override double GetPerimeter()
        {
            return (int)(2 * Math.PI * radius);
        }
        /*public override string ToString()
        {
            return Name; ;
        }*/

    }

    public class Rectangle : Shape
    {
        protected double l;
        protected double w;
        protected string Name = "Rectangle";
        public Rectangle(double length, double width)
        {
            this.l = length;
            this.w = width;
        }

        public override double GetArea()
        {
            return this.l * this.w; 
        }

        public override double GetPerimeter()
        {
            return 2 * (l + w);
        }
       /* public override string ToString()
        {
            return Name; ;
        }*/
    }

    public class Square : Rectangle
    {
        private double sideLength;
       // private string Name = "Rectangle";

        public Square(double sideLength):base(sideLength,sideLength)
        {
            this.sideLength = sideLength;
        }

    }
}