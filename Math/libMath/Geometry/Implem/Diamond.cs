using Utopia.Math.Geometry.Interface;

namespace Utopia.Math.Geometry.Implem
{
    class Diamond : IArea
    {
        public float D1 { get; set; }
        public float D2 { get; set; }

        public Diamond()
        {
            D1 = float.NaN;
            D2 = float.NaN;
        }

        public Diamond(float d1, float d2)
        {
            D1 = d1;
            D2 = d2;
        }

        public float ComputeArea()
        {
            return ((float)((float)(D1 * D2) / 2.0));
        }
    }
}
