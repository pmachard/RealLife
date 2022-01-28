using System.IO;

namespace libMath.Geometry.Cartesien.Interface
{
    public interface IVector3D : IVector2D
    {
        double Z { get; set; }
    }
}