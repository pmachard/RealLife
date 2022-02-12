using System.Collections.Generic;

namespace Utopia.Math.Function.Interface
{
    public enum EnumSymbolOp { Add, Supp, Mult, Div }

    public interface ISymbolOperator
    {
        static protected readonly Dictionary<EnumSymbolOp, int> Priority =
                new Dictionary<EnumSymbolOp, int> { 
                        {EnumSymbolOp.Add,4 },
                        {EnumSymbolOp.Supp,4 },
                        {EnumSymbolOp.Mult,2 },
                        {EnumSymbolOp.Div,2 } };

        EnumSymbolOp Op { get; set; }
    }
}
