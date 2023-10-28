using System;
namespace Abstraact_CLass
{
	public abstract class shape
	{

		public abstract double Area();
		public abstract double perimeter();
	}


	public class Triangle : shape
	{
		private double a, b, c;

		public Triangle(double a, double b, double c)
		{
			if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
			{
				throw new ArgumentException("invalid data");
			}
			this.a = a;
			this.b = b;
			this.c = c;
		}

		public override double Area()
		{
			double s = (a + b + c) / 2.0;
			return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
		}

		public override double perimeter()
		{
			return a + b + c;
		}
	}
	public class Rectangle : shape
	{


		private double width, height;

		public Rectangle(double width, double height)
		{
			if (width <= 0 || height <= 0)
			{
				throw new ArgumentException("this height is not valid ");

			}
			this.width = width;
			this.height = height;
		}


		public override double Area()
		{
			return width * height;
		}
		public override double perimeter()
		{
			return 2 * (width + height);
		}

	}

	public class Circle : shape
	{

		private double radius;

		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentException("this is invalid circle radius");
			}

			this.radius = radius;
		}

		public override double Area()
		{
			return Math.PI * radius * radius;
		}
		public override double perimeter()
		{
			return 2 * Math.PI * radius * radius;
		}

	}
	
}