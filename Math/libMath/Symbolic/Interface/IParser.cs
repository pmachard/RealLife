namespace Utopia.Math.Symbolic.Interface
{
    public interface IParser
    {
        bool Check(string expression);
        ISymbolExp Parse(string expression);
    }
}
