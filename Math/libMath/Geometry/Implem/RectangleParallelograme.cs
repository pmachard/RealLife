using Utopia.Math.Geometry.Interface;
using System;

namespace Utopia.Math.Geometry.Implem
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
            return (float) System.Math.Sqrt(System.Math.Pow(A,2.0) + System.Math.Pow(B, 2.0) + System.Math.Pow(C, 2.0) );
        }

        public float ComputeArea()
        {
            throw new System.NotImplementedException();
        }
    }
}
