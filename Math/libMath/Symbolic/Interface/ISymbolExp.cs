using System;

namespace Utopia.Math.Symbolic.Interface
{
    public interface ISymbolExp 
    {
        ISymbolExp Exp { get; set; }
        IExpTerm Term { get; set; }
        ISymbolOperator Operator { get; set; }

        void Init(ISymbolExp left, ISymbolOperator oper, IExpTerm right);
        void Init(IExpTerm terminal);

        string ToString();
    }
}
