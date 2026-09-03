using System;
class Rectangle : Shape
{
    public double Height;
    public double Width;
    public Rectangle(double width, double height) 
    {
        Width = width;
        Height = height;
    }
        public override double CalculateArea()
    {
        return Height*Width;
    }

}