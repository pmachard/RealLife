using Utopia.Math.Symbolic.Interface;

namespace Utopia.Math.Symbolic.Implem
{
    public class SymbolTerm : IExpTerm
    {
        public IExpTerm Term { get; set; }
        public ISymbolOperator Operator { get ; set ; }
        public ISymbolFactor Factor { get ; set ; }

        public SymbolTerm() => Init();
        public SymbolTerm(IExpTerm exterm) => Init(exterm);
        public SymbolTerm(ISymbolFactor terminal) => Init(terminal);
        public SymbolTerm(IExpTerm term, ISymbolOperator oper, ISymbolFactor right) => Init(term, oper, right);

        public void Init()
        {
            Term = null;
            Operator = null;
            Factor = null;
        }
        public void Init(IExpTerm exterm)
        {
            Term = exterm;
            Operator = null;
            Factor = null;
        }        
        public void Init(ISymbolFactor terminal)
        {
            Term = null;
            Operator = null;
            Factor = terminal;
        }
        public void Init(IExpTerm term, ISymbolOperator oper, ISymbolFactor right)
        {
            Term = term;
            Operator = oper;
            Factor = right;
        }

    }
}
