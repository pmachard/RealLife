namespace Utopia.Math.Set.Complex.Interface
{
    public interface IComplex 
    {
        double Real { get; set; }
        double Imagin { get; set; }

        IComplex AutoAdd(IComplex source);
        IComplex AutoSupp(IComplex source);
        IComplex AutoMult(IComplex source);
    }
}
