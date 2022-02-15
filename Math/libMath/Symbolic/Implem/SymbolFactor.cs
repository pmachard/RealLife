using Utopia.Math.Symbolic.Interface;

namespace Utopia.Math.Symbolic.Implem
{
    public class SymbolFactor : ISymbolFactor
    {
        public ISymbolExp Exp { get; set; }
        public ISymbolVar Var { get; set; }
        public ISymbolFactor Factor { get; set; }
        public ISymbolOperator Operator { get; set; }

        public SymbolFactor() => Init();
        public SymbolFactor(ISymbolVar var) => Init(var);
        public SymbolFactor(ISymbolFactor factor) => Init(factor);

         public void Init()
        {
            Var = null;
            Factor = null;
            Operator = null;
        }
        public void Init(ISymbolVar var)
        {
            Var = var;
            Factor = null;
            Operator = null;
        }
        public void Init(ISymbolFactor factor)
        {
            Var = null;
            Factor = factor;
            Operator = null;
        }
    }
}
