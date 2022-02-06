using Utopia.Math.Geometry.Interface;
using System;

namespace Utopia.Math.Geometry.Implem
{
    class RectangleParallelograme : IArea
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public RectangleParallelograme()
        {
            A = double.NaN;
            B = double.NaN;
            C = double.NaN;
        }

        public RectangleParallelograme(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Compute()
        {
            return System.Math.Sqrt(
                        System.Math.Pow(A, 2.0) + 
                        System.Math.Pow(B, 2.0) + 
                        System.Math.Pow(C, 2.0) 
                   );
        }

        public double ComputeArea()
        {
            throw new System.NotImplementedException();
        }
    }
}
