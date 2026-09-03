using System;
public class Circle : Shape
{
    public double Radius;
    public Circle(double radius) 
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return 3.14*Radius*Radius;
    }
}