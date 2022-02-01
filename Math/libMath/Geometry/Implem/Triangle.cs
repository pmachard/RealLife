using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Triangle : IArea, IPerimeter
    {
        public float A { get; set; }
        public float H { get; set; }

        public Triangle()
        {
            A = float.NaN;
            H = float.NaN;
        }

        public Triangle(float a, float h)
        {
            A = a;
            H = h;
        }

        public float ComputeArea()
        {
            return ((float)((float)(A * H)/2.0));
        }

        public float ComputePerimeter()
        {
            return float.NaN;
        }
    }
}
