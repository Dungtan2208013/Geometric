using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class GeometricObject
{
    protected string color;
    protected double weight;
    protected GeometricObject()
    {
        color = "white";
        weight = 1.0;
    }
    //Construct a GeometricObject object
    protected GeometricObject(string color, double weight)
    {
        this.color = color;
        this.weight = weight;
    }
    // properties
    public string Pcolor
    {
        get { return color; }
        set { color = value; }
    }
    public double PWeight
    {
        get { return weight; }
        set { weight = value; }
    }
    //Abstract method
    public abstract double findArea();
    public abstract double findPerimeter();
}

public class Circle : GeometricObject
{
    private double radius;
    public Circle(double x) 
    {
        this.radius = x;
    }
    public Circle(double x, string c,double w) :base (c,w)
    {
        this.radius = x;
    }
    public override string ToString()
    {
        return "Circle has: radius is" + radius + ", color is " + Pcolor + ", weight is" + PWeight;
    }
    public override double findArea()
    {
        return Math.PI*radius*radius;
    }
    public override double findPerimeter()
    {
        return 2 * Math.PI * radius;
    }


}

