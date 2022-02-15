using System.Collections.Generic;
using Utopia.Math.Symbolic.Interface;


namespace Utopia.Math.Symbolic.Interface
{
    public class SymbolOperator : ISymbolOperator
    {
        public ISymbolOperator.EnumPriority Priority {
            get
            {
                switch (Operator)
                {
                    case ISymbolOperator.EnumOperator.Undefined:
                        return ISymbolOperator.EnumPriority.Undefined;
                    case ISymbolOperator.EnumOperator.Add:
                    case ISymbolOperator.EnumOperator.Remove:
                        return ISymbolOperator.EnumPriority.Low;
                    case ISymbolOperator.EnumOperator.Multiply:
                    case ISymbolOperator.EnumOperator.Divide:
                        return ISymbolOperator.EnumPriority.Hight;
                    default:
                        return ISymbolOperator.EnumPriority.Undefined;
                }
            }
        }
        public ISymbolOperator.EnumOperator Operator { get; set; }

        public SymbolOperator() { Operator = ISymbolOperator.EnumOperator.Undefined; }
        public SymbolOperator(char opChar) 
        {
            Operator = (ISymbolOperator.EnumOperator)opChar;

            switch (opChar)
            {
                case ' ':
                    Operator = ISymbolOperator.EnumOperator.Undefined;
                    break;
                case '+':
                    Operator = ISymbolOperator.EnumOperator.Add;
                    break;
                case '-':
                    Operator = ISymbolOperator.EnumOperator.Remove;
                    break;
                case '*':
                    Operator = ISymbolOperator.EnumOperator.Multiply;
                    break;
                case '/':
                    Operator = ISymbolOperator.EnumOperator.Divide;
                    break;
                default:
                    Operator = ISymbolOperator.EnumOperator.Undefined;
                    break;
            }
        }
    }
}
