using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Parallelograme : IArea
    {
        public float A { get; set; }
        public float H { get; set; }

        public Parallelograme()
        {
            A = float.NaN;
            H = float.NaN;
        }

        public Parallelograme(float a, float h)
        {
            A = a;
            H = h;
        }

        public float ComputeArea()
        {
            return A * H;
        }
    }
}
