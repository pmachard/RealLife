using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class TroncatedCone : IArea
    {
        public double A { get; set; }
        public double R1 { get; set; }
        public double R2 { get; set; }

        public TroncatedCone()
        {
            A = double.NaN;
            R1 = double.NaN;
            R2 = double.NaN;
        }

        public TroncatedCone(double a, double r1, double r2)
        {
            A = a;
            R1 = r1;
            R2 = r2;
        }

        public double ComputeArea()
        {
            return System.Math.PI * A *(R1+R2);
        }
    }
}
