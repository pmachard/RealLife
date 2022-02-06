using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.d2.Implem
{
    public class Circle : IArea, IPerimeter
    {
        public double R { get; set; }

        public Circle()
        {
            R = 0.0;
        }

        public Circle(double r)
        {
            R = r;
        }

        public double ComputeArea()
        {
            return System.Math.PI * System.Math.Pow(R,2.0);
        }

        public double ComputePerimeter()
        {
            return 2.0 * System.Math.PI* R;
        }
    }
}
