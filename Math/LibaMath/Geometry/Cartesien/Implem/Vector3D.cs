using libMath.Geometry.Cartesien.Interface;
using System.IO;

namespace libMath.Geometry.Cartesien.Implem
{
    public struct Vector3D : IVector3D
    {
        public double this[int pos] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public double X { get ; set ; }
        public double Y { get ; set ; }
        public double Z { get ; set ; }

        public bool Equals(IVector3D source)
        {
            return false;
        }

        public void Load(BinaryReader binaryReader)
        {
        }

        public void Save(BinaryWriter binaryWriter)
        {
        }
    }
}
