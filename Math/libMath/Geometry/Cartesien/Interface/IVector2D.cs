using System.IO;

namespace Utopia.Math.Geometry.Cartesien.Interface
{
    public interface IVector2D
    {
        double X { get; set; }
        double Y { get; set; }

        void Save(BinaryWriter binaryWriter);
        void Load(BinaryReader binaryReader);
        double this[int pos] { get; set; }

        int GetHashCode();
        bool Equals(object source);
        bool Equals(IVector2D source);

        string ToString();
    }
}
