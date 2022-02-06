using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Trapeze : IArea
    {
        public double D1 { get; set; }
        public double D2 { get; set; }

        public Trapeze()
        {
            D1 = double.NaN;
            D2 = double.NaN;
        }

        public Trapeze(double d1, double d2)
        {
            D1 = d1;
            D2 = d2;
        }

        public double ComputeArea()
        {
            return (D1 * D2) / 2.0;
        }
    }
}
