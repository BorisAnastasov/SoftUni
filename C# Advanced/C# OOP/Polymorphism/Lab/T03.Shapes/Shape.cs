using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Shapes
{
    public abstract class Shape
    {



        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public virtual string Draw()
        {
            return $"Drawing {this.GetType().Name}";
        }
    }
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set { width = value; }
            
        }        
        public double Height
        {
            get { return this.height; }
            set { height = value; }
        }

        public override double CalculateArea()
        =>this.Width*this.Height;

        public override double CalculatePerimeter()
        => 2 * (this.Height+this.Width);
    }
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
       
        public override double CalculateArea()
        =>Math.PI*Math.Pow(this.Radius, 2);

        public override double CalculatePerimeter()
        =>2*Math.PI*this.Radius;
    }
}
