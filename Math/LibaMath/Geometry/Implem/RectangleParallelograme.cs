using LibMath.Geometry.Interface;
using System;

namespace LibMath.Geometry.Implem
{
    class RectangleParallelograme : IArea
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public RectangleParallelograme()
        {
            A = float.NaN;
            B = float.NaN;
            C = float.NaN;
        }

        public RectangleParallelograme(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public float Compute()
        {
            return (float) Math.Sqrt(Math.Pow(A,2.0) + Math.Pow(B, 2.0) + Math.Pow(C, 2.0) );
        }

        public float ComputeArea()
        {
            throw new System.NotImplementedException();
        }
    }
}
