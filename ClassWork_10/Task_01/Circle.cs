using System;
using System.Net.NetworkInformation;

namespace Task_01
{
    public class Circle : IFigure
    {
        private double radius;
        private const double pi = Math.PI;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public string Name { get; set; }

        public double CalculateSquare()
        {
            return pi * radius * radius;
        }
    }
}