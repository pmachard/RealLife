using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Triangle : IArea, IPerimeter
    {
        public double A { get; set; }
        public double H { get; set; }

        public Triangle()
        {
            A = double.NaN;
            H = double.NaN;
        }

        public Triangle(double a, double h)
        {
            A = a;
            H = h;
        }

        public double ComputeArea()
        {
            return (A * H)/2.0;
        }

        public double ComputePerimeter()
        {
            return double.NaN;
        }
    }
}
