using System.IO;
using Utopia.Math.Geometry.Cartesien.Interface;

namespace Utopia.Math.Geometry.Cartesien.Implem
{
    public struct Vector2D : IVector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector2D(IVector2D source)
        {
            X = source.X;
            Y = source.Y;
        }

        public Vector2D(Vector3D source)
        {
            X = source.X;
            Y = source.Y;
        }

        public Vector2D(double factor)
        {
            X = factor;
            Y = factor;
        }

        public void Save(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(X);
            binaryWriter.Write(Y);
        }

        public void Load(BinaryReader binaryReader)
        {
            X = binaryReader.ReadDouble();
            Y = binaryReader.ReadDouble();
        }

        public double this[int pos]
        {
            get
            {
                switch (pos)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    default:
                        return 0.0f;
                }
            }
            set
            {
                switch (pos)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                }
            }
        }

        // public IVector2D operator +( IVector2D b)
        //  {
        //      return new Vector2D(x + b.x, y + b.y);
        //  }
        // public IVector2D operator -(IVector2D a, IVector2D b)
        // {
        //     return new Vector2D(a.x - b.x, a.y - b.y);
        // }
        // public IVector2D operator -(IVector2D b)
        // {            
        //     return new Vector2D(x-b.x,y-b.y);
        // }
        // public static IVector2D operator *(double b)
        // {
        //     return new Vector2D(x * b, y * b);
        // }
        // public static IVector2D operator *(IVector2D b)
        // {
        //     return new Vector2D(x * b.x, y * b.y);
        // }
        // public static double operator *(IVector2D b)
        // {
        //     return x * b.x + y * b.y;
        // }

        // public IVector2D operator /(double b)
        //     => new Vector2D(x / b, y / b);

        // public double Length2()
        //     => this * this;

        // public double Length()
        //     => System.Math.Sqrt(Length2());

        public override int GetHashCode()
        {
            long h = (long)X ^ (long)Y;
            return (int)(h & 0xffffffff) ^ (int)(h >> 32);
        }

        public override bool Equals(object source)
        {
            return Equals(source);
        }

        public bool Equals(IVector2D source)
        {
            return X == source.X && Y == source.Y;
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
