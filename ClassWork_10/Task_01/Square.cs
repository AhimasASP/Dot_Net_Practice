using System;

namespace Task_01
{
    public class Square : IFigure
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public string Name { get; set; }

        public double CalculateSquare()
        {
            return side * side;
        }
    }
}