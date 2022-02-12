namespace Utopia.Math.Function.Interface
{
    public interface ISymbolFactor
    {
        ISymbolVar Var { get; set; }
        ISymbolExp Exp { get; set; }
        ISymbolFactor Factor { get; set; }
        ISymbolOperator Operator { get; set; }
    }
}
