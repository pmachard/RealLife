using Utopia.Math.Geometry.Cartesien.Interface;
using System.IO;
using System;

namespace Utopia.Math.Geometry.Cartesien.Implem
{
    public struct Vector3D : IVector3D
    {
        public double this[int pos] 
        { 
            get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); 
        }

        public double X { get ; set ; }
        public double Y { get ; set ; }
        public double Z { get ; set ; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;        
        }

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
