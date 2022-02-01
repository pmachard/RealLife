using System.IO;

namespace Utopia.Math.Geometry.Cartesien.Interface
{
    public interface IVector3D 
    {
        double this[int pos] { get ; set ; }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public bool Equals(IVector3D source);
        public void Load(BinaryReader binaryReader);
        public void Save(BinaryWriter binaryWriter);
    }
}