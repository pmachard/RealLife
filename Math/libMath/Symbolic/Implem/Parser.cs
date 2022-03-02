using System;
using System.Collections.Generic;
using Utopia.Math.Symbolic.Interface;

namespace Utopia.Math.Symbolic.Implem
{
    public class Parser : IParser
    {
        bool IParser.Check(string expr)
        {

            if (CheckEmpty(expr) == false || CheckTrim(expr) == false)
                return false;

            String exprTrim = expr.Trim();
            String exprLower = exprTrim.ToLower();
            if (exprTrim != exprLower) return false;

            char[] separators = new char[] { '+', '-','*','/'};
            string[] result = MathSplit(exprLower, separators);

            /*
            if (!CheckCutExpr(exprLower, listExprCut))
                return false;
            */
            return true;
        }

        string[] MathSplit(String strVar,char[] separator)
        {
            List<String> lResult = new List<string>();
            String str = string.Empty;

            foreach (char c in strVar)
            {
                foreach (char s in separator)
                {
                    if (s == c)
                    {
                        str += c;
                    }
                    else 
                    {
                        lResult.Add(str);
                        str = String.Empty;
                        str += c;
                    }
                }
            }

            return lResult.ToArray();
        }


        bool CheckEmpty(string expr)
        {
            if (expr == null) return false;
            if (expr == string.Empty) return false;
            if (expr == "") return false;
            return true;
        }

        bool CheckTrim(string expr)
        {
            var exprTrim = expr.Trim();
            if (exprTrim != expr) return false;
            return true;
        }

        bool CheckCutExpr(string expr, List<string> listCutExpr)
        {
            try
            {
                if (!CheckCutExprInternal(expr, listCutExpr))
                    return false;
            }
            catch (Exception)
            {
                listCutExpr.Clear();
                return false;
            }
            return true;
        }

        bool CheckCutExprInternal(String expr, List<String> cutExpr)
        {
            bool isYetPoint = false;

            String current = String.Empty;
            int currentType = 0;
            foreach (Char c in expr)
            {
                switch (currentType)
                {
                    case 0:
                        if (CheckCheckConstValue(c, out isYetPoint))
                        {
                            currentType = 0;
                            current += c;
                        }
                        else if (CheckCheckVar(c))
                        {
                            currentType = 2;
                            current += c;
                            cutExpr.Add(current);
                        }
                        break;

                    case 1:
                        break;

                    case 2:
                        if (CheckCheckVar(c))
                        {
                            if (current.Length > 0)
                            {
                                cutExpr.Clear();
                                return false;
                            }
                            else
                            {
                                current += c;
                            }
                        }
                        else if (CheckCheckOperator(c))
                        {
                            current = string.Empty;
                            cutExpr.Add(c.ToString());
                        }
                        else return false;
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }

        bool CheckCheckOperator(char carValue)
        {
            switch (carValue)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    return true;
            }
            return false;
        }

        bool CheckCheckConstValue(char carConstValue, out bool isYetPoint)
        {
            isYetPoint = false;
            if (char.IsDigit(carConstValue))
                return true;

            if ((carConstValue == '.') && (isYetPoint == false))
                return true;

            return false;
        }

        bool CheckCheckVar(char carConstValue)
        {
            if (char.IsLetter(carConstValue))
                return true;
            return false;
        }

        public ISymbolExp Parse(string expression)
        {
            var trimExp = expression.Trim();
            var lowExp = trimExp.ToLower();

            return InternalParse(lowExp);
        }

        private ISymbolExp InternalParse(string expression)
        {
            return null;
        }
    }
}
