using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class TroncatedCone : IArea
    {
        public float A { get; set; }
        public float R1 { get; set; }
        public float R2 { get; set; }

        public TroncatedCone()
        {
            A = float.NaN;
            R1 = float.NaN;
            R2 = float.NaN;
        }

        public TroncatedCone(float a, float r1, float r2)
        {
            A = a;
            R1 = r1;
            R2 = r2;
        }

        public double Compute()
        {
            return (float) (System.Math.PI * A *(R1+R2));
        }

        public float ComputeArea()
        {
            throw new System.NotImplementedException();
        }
    }
}
