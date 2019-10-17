using System.Buffers.Text;

namespace Task_01
{
    public class Triangle : IFigure
    {
        private readonly double triangleBase;
        private readonly double triangleHeight;

        public Triangle(double triangleBase, double triangleHeight)
        {
            this.triangleBase = triangleBase;
            this.triangleHeight = triangleHeight;
        }


        public string Name { get; set; }

        public double CalculateSquare()
        {
            return triangleBase * triangleHeight / 2;
        }
    }
}