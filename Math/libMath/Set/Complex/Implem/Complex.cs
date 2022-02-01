using Utopia.Math.Set.Complex.Interface;

namespace Utopia.Math.Set.Complex.Implem
{
    public class Complex : IComplex
    {
        public double Real { get; set; }
        public double Imag { get; set; }
        public double Imagin { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Complex()
        {
            Real = 0.0;
            Imag = 0.0;
        }

        public Complex(double r, double i)
        {
            Real = r;
            Imag = i;
        }

        public IComplex AutoAdd(IComplex s)
        {
            return new Complex(Real + s.Real, Imag + s.Imagin);
        }

        public IComplex AutoSupp(IComplex s)
        {
            return new Complex(Real - s.Real, Imag - s.Imagin);
        }

        public IComplex AutoMult(IComplex s)
        {
            return new Complex((Real*s.Real), ((Imag*s.Imagin)+(s.Imagin*Imag)+(Imag*s.Imagin)));
        }
    }
}
