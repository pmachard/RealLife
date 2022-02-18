using Utopia.Math.Symbolic.Interface;

namespace Utopia.Math.Symbolic.Implem
{
    /*
    public class Parser : IParser
    {
        public ISymbolExp Parse(string expression)
        {
                // Clean simple format
            var trimExp = expression.Trim();
            var lowExp = trimExp.ToLower();

            return InternalParse(lowExp);
        }
        private ISymbolExp InternalParse(string expression)
        {
            switch (expression[0])
            {
                case '0': case '1': case '2': case '3': case '4': case '5': 
                case '6': case '7': case '8': case '9': case '.':
                    ISymbolExp symboleExp = new SymbolExp();
                    string next  = InternalParseNumeric(expression, symboleExp);
                    break;
            }

            return null;
        }
        private ISymbolExp InternalParseNumeric(string expression, ISymbolExp symboleExp)
        {
            switch (expression[0])
            {
                case '0': case '1': case '2': case '3':case '4': case '5':
                case '6': case '7': case '8': case '9': case '.':
                    var last = symboleExp.Last();
                    last.CompletWith(expression[0]);
                    return InternalParseNumeric(expression.Substring(1, expression.Length), symboleExp);
                    break;
            }
            return null;
        }

        private ISymbolExp ParseAfter(string expression, string subString)
        {
            switch (expression[0])
            {
                case '0': case '1': case '2': case '3':case '4':
                case '5': case '6': case '7': case '8':case '9':
                case '.':
                    return ParseAfter(expression, expression.Substring(1, expression.Length - 1));
                case 's':
                    return ParseAfterS(expression, expression.Substring(1, expression.Length - 1));
                case 'c':
                    return ParseAfterC(expression, expression.Substring(1, expression.Length - 1));

            }
            return null;
        }

        private ISymbolExp ParseAfterS(string expression, string subString)
        {
            switch (expression[0])
            {
                case 'i':
                    return ParseAfterSi(expression, expression.Substring(1, expression.Length - 1));

            }
            return null;
        }

        private ISymbolExp ParseAfterC(string expression, string subString)
        {
            switch (expression[0])
            {
                case 'o':
                    return ParseAfterCo(expression, expression.Substring(1, expression.Length - 1));

            }
            return null;
        }

        private ISymbolExp ParseAfterSi(string expression, string subString)
        {
            switch (expression[0])
            {
                case 'n':
                    return null;

                default  :
                    return null;
            }
        }

        private ISymbolExp ParseAfterCos(string expression, string subString)
        {
            switch (expression[0])
            {
                case 's':
                    return null;

                default:
                    return null;
            }
        }
    }
    */
}
