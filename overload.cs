using System;
public class Triangle
{

    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double a, double b, double c)
    {

        if (!Isvalid(a, b, c))
        {
            throw new ArgumentException("Invalid triangle sides");
        }
        sideA = a;
        sideB = b;
        sideC = c;
    }


    public double GetArea()
    {
        double s = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

    }
    public double GetPerimeter()
    {

        return sideA + sideB + sideC;
    }

    public static bool operator ==(Triangle a1,Triangle a2)
    {
        return a1.GetArea() == a2.GetArea();
    }
    
    public static bool operator !=(Triangle a1, Triangle a2)
    {
        return a1.GetArea() != a2.GetArea();
    }
    public override bool Equals(object? obj)
    {
        if (obj is Triangle otherTriangle)
        {
            return this.GetArea() == otherTriangle.GetArea();

        }
        return false;
            
    }

    public override int GetHashCode()
    {
        return GetArea().GetHashCode();
    }
    private static bool Isvalid(double a, double b, double c)
    {
        return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
    }

    public override string ToString()
    {
        return $"Triangle (Sides:{sideA},{sideB},{sideC})";
    }


    class Program
    {

static void Main(string[] args)
        {

            Console.WriteLine("Enter sides for a triangle:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Triangle customTriangle = new Triangle(a, b, c);

            Console.WriteLine("Custom Triangle:");
            Console.WriteLine($"Area:{customTriangle.GetArea()}");
            Console.WriteLine($"Perimeter:{customTriangle.GetPerimeter()}");







        }










    }




















}



