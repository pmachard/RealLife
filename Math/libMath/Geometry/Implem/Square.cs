using Utopia.Math.Geometry.Interface;
using System;

namespace Utopia.Math.Geometry.Implem
{
    class Scare : IArea
    {
        public double A { get; set; }

        public Scare()
        {
            A = double.NaN;
        }

        public Scare(double a)
        {
            A = a;
        }

        public double ComputeArea()
        {
            return System.Math.Pow(A,2.0);
        }
    }
}
