using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class SymbolExp : ISymbolExp
    {
        public ISymbolExp Exp { get; set; }
        public ISymbolTerm Term { get; set; }
        public ISymbolOperator Operator { get; set; }

        public void Init(ISymbolExp left, ISymbolOperator oper, ISymbolTerm right)
        {
            Exp = left;
            Term = null;
            Operator = oper;
        }

        public void Init(ISymbolTerm terminal)
        {
            Exp = null;
            Term = null;
            Operator = null;
        }
    }
}
