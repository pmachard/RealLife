namespace Utopia.Math.Symbolic.Interface
{
    public interface ISymbolFactor
    {
        ISymbolVar Var { get; set; }
        ISymbolExp Exp { get; set; }
        ISymbolOperator Operator { get; set; }
        ISymbolFactor Factor { get; set; }
    }
}
