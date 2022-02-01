using Utopia.Math.Geometry.Interface;
using System;

namespace Utopia.Math.Geometry.Implem
{
    class QuadrilatetalInscrited : IArea
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float D { get; set; }
        public float P { get; set; }

        public QuadrilatetalInscrited()
        {
            A = float.NaN;
            B = float.NaN;
            C = float.NaN;
            D = float.NaN;
            P = float.NaN;
        }

        public QuadrilatetalInscrited(float a, float b, float c, float d, float p)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            P = p;
        }

        public float ComputeArea()
        {
            return ((float)System.Math.Sqrt((P-A)*(P-B)*(P-C)*((P))));
        }
    }
}
