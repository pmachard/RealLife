using Utopia.Math.Geometry.Interface;
using System;

namespace Utopia.Math.Geometry.Implem
{
    class Scare : IArea
    {
        public float A { get; set; }

        public Scare()
        {
            A = float.NaN;
        }

        public Scare(float a)
        {
            A = a;
        }

        public float ComputeArea()
        {
            return (float)System.Math.Pow(A,2.0);
        }
    }
}
