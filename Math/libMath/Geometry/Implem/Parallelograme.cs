using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Parallelograme : IArea
    {
        public double A { get; set; }
        public double H { get; set; }

        public Parallelograme()
        {
            A = double.NaN;
            H = double.NaN;
        }

        public Parallelograme(double a, double h)
        {
            A = a;
            H = h;
        }

        public double ComputeArea()
        {
            return A * H;
        }
    }
}
