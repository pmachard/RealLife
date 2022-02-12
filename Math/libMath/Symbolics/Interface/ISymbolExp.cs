namespace Utopia.Math.Function.Interface
{
    public interface ISymbolExp
    {
        ISymbolExp Exp { get; set; }
        ISymbolTerm Term { get; set; }
        ISymbolOperator Operator { get; set; }

        void Init(ISymbolExp left, ISymbolOperator oper, ISymbolTerm right);
        void Init(ISymbolTerm terminal);
    }
}
