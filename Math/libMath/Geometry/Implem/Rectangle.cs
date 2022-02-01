using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Rectangle : IArea
    {
        public float A { get; set; }
        public float B { get; set; }

        public Rectangle()
        {
            A = 0.0f;
            B = 0.0f;
        }

        public Rectangle(float a, float b)
        {
            A = a;
            B = b;
        }

        public float ComputeArea()
        {
            return A * B;
        }
    }
}
