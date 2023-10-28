namespace Abstraact_CLass
{

    class program
    {
        static void Main(String [] args)
        {

            Console.WriteLine("Choose a shape");
            Console.WriteLine("Triangle");
            Console.WriteLine("Rectangle");
            Console.WriteLine("Circle");

            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the sides of Triangle (a , b, c");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    Triangle triangle = new Triangle(a, b, c);
                    Console.WriteLine("Area is:" + triangle.Area);
                    Console.WriteLine("Perimeter is :" + triangle.perimeter);
                    break;
                case 2:
                    Console.WriteLine("Enter the width end height of Rectangle");
                    double height = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(height, width);
                    Console.WriteLine("area is " + rectangle.Area);
                    Console.WriteLine("Perimeter is" + rectangle.perimeter);
                    break;
                case 3:
                    Console.WriteLine("Enter the radius");
                    double radius = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    Console.WriteLine("are is " + circle.Area);
                    Console.WriteLine("perimeter is " + circle.perimeter);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }







            }
           









        















    }

}