using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double doasd = new Random().NextDouble();
            Object[] array = new object[3];
            Triangle triangle = new Triangle(new Random().NextDouble(), new Random().NextDouble());
            triangle.Name = "triangle";
            array[0] = triangle;
            Square square = new Square(new Random().NextDouble());
            square.Name = "square";
            array[1] = square; 
            Circle circle = new Circle(new Random().NextDouble());
            circle.Name = "circle";
            array[2] = circle;
            foreach (var figure in array)
            {
                var tempFigure = (IFigure) figure;
                Console.WriteLine(tempFigure.Name + " square is: " + tempFigure.CalculateSquare());
            }
        }
    }
}
