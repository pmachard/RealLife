using LibMath.Geometry.Interface;
using System;

namespace LibMath.Geometry.Implem
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
            return (float)(Math.PI * Math.Pow(R,2.0));
        }

        public float ComputePerimeter()
        {
            return (float)(2.0 * Math.PI* R);
        }
    }
}
