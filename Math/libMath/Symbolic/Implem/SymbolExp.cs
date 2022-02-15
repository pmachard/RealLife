using Utopia.Math.Symbolic.Interface;

namespace Utopia.Math.Symbolic.Implem
{
    public class SymbolExp : ISymbolExp
    {
        public ISymbolExp Exp { get; set; }
        public ISymbolOperator Operator { get; set; }
        public IExpTerm Term { get; set; }

        public SymbolExp() => Init();   
        public SymbolExp(IExpTerm terminal) => Init(terminal);
        public SymbolExp(   ISymbolExp left, 
                            ISymbolOperator oper, 
                            IExpTerm right) 
            => Init(left, oper, right); 

        public void Init()
        {
            Exp = null;
            Term = null;
            Operator = null;
        }
        public void Init(IExpTerm terminal)
        {
            Exp = null;
            Operator = null;
            Term = terminal;
        }
        public void Init(ISymbolExp exp, ISymbolOperator oper, IExpTerm term)
        {
            Exp = exp;
            Operator = oper;
            Term = term;
        }

        public double Eval()
        {
            return 0.0;
        }
    }
}
