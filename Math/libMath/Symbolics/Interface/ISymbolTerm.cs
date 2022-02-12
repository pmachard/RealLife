namespace Utopia.Math.Function.Interface
{
    public interface ISymbolTerm
    {
        ISymbolTerm Left { get; set; }
        ISymbolFactor Right { get; set; }
        ISymbolFactor Terminal { get; set; }
        ISymbolOperator Operator { get; set; }

        void Init(ISymbolTerm left, ISymbolOperator oper, ISymbolFactor right);
        void Init(ISymbolFactor terminal);
    }
}
