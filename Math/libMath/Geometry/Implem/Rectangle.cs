using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Rectangle : IArea
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle()
        {
            A = 0.0;
            B = 0.0;
        }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public double ComputeArea()
        {
            return A * B;
        }
    }
}
