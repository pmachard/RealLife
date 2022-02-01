using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Circle : IArea, IPerimeter
    {
        public float R { get; set; }

        public Circle()
        {
            R = float.NaN;
        }

        public Circle(float r)
        {
            R = r;
        }

        public float ComputeArea()
        {
            return (float)(System.Math.PI * System.Math.Pow(R,2.0));
        }

        public float ComputePerimeter()
        {
            return (float)(2.0 * System.Math.PI* R);
        }
    }
}
