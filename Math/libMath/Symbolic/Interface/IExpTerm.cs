namespace Utopia.Math.Symbolic.Interface
{
    public interface IExpTerm
    {
        IExpTerm Term { get; set; }
        ISymbolOperator Operator { get; set; }
        ISymbolFactor Factor { get; set; }

        void Init(IExpTerm left, ISymbolOperator oper, ISymbolFactor right);
        void Init(ISymbolFactor terminal);
    }
}
