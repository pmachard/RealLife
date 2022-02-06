using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.d3.Implem
{
    class Cone : IArea, IVolume
    {
        public double A { get; set; }
        public double H { get; set; }
        public double R { get; set; }

        public Cone()
        {
            A = double.NaN;
            H = double.NaN;
            R = double.NaN;
        }

        public Cone(double h, double a, double r)
        {
            H = h;
            A = a;
            R = r;
        }

        public double ComputeArea()
        {
            return System.Math.PI * R * A;

        }

        public double ComputeVolume()
        {
            return  ( 
                        System.Math.PI * 
                        System.Math.Pow(R,2.0) * H
                     ) / 3.0;
        }
    }
}
