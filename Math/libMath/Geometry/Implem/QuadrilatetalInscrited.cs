using Utopia.Math.Geometry.Interface;
using System;

namespace Utopia.Math.Geometry.Implem
{
    class QuadrilatetalInscrited : IArea
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double P { get; set; }

        public QuadrilatetalInscrited()
        {
            A = double.NaN;
            B = double.NaN;
            C = double.NaN;
            D = double.NaN;
            P = double.NaN;
        }

        public QuadrilatetalInscrited(double a, double b, double c, double d, double p)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            P = p;
        }

        public double ComputeArea()
        {
            return System.Math.Sqrt((P-A)*(P-B)*(P-C)*((P)));
        }
    }
}
