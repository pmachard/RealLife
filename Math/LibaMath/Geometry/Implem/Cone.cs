﻿using LibMath.Geometry.Interface;
using System;

namespace LibMath.Geometry.d3.Implem
{
    class Cone : IArea, IVolume
    {
        public float A { get; set; }
        public float H { get; set; }
        public float R { get; set; }

        public Cone()
        {
            H = float.NaN;
            R = float.NaN;
        }

        public Cone(float h, float a, float r)
        {
            H = h;
            A = a;
            R = r;
        }

        public float ComputeArea()
        {
            return ((float) Math.PI * R * A);

        }

        public float ComputeVolume()
        {
            return ((float)Math.PI * (float)Math.Pow(R,2.0) * (float)H) / (float)3.0;
        }
    }
}
