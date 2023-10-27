using System;
namespace StaticClassCalculator
{
	public class Math
	{
		public Math()
		{
		}

		public static void Add(int n, int n2)
		{
			int num1 = n;
			int num2 = n2;

			int result = num1 + num2;
			Console.WriteLine($"Result: {num1} + {num2} = {result}");
		}

		public static void Sub(double b ,double b2)
		{
			double num3 = b;
			double num4 = b2;
			double result = num3 - num4;
			Console.WriteLine($"Result:{num3} - {num4} = {result}");
		}

		public static void Mul(int c , int c2)
		{
			int num5 = c;
			int num6= c2;
			int result = num5 * num6;
			Console.WriteLine($"Result:{num5}*{num6}={result}");
		}
		public static void Div(double d,double d2)
		{
			double num7 = d;
			double num8 = d2;
			double result = num7 / num8;
			Console.WriteLine($"Result:{num7} / {num8} = {result}");
		}
	}
}