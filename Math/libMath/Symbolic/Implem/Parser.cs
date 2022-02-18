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

            var exprTrim = expr.Trim();
            var exprLower = exprTrim.ToLower();
            if (exprTrim != exprLower) return false;

            List<string> listExprCut = new List<string>();
            if (!CheckCutExpr(exprLower, listExprCut))
                return false;
            return true;
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
            listCutExpr = new List<string>();
            try
            {
                if (!CheckCutExprInternal(expr, listCutExpr))
                    return false;
            }
            catch (Exception ex)
            {
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
                if (CheckCheckConstValue(c, out isYetPoint) && currentType==0)
                {
                    if ((currentType == 0) || (currentType == 1))
                    {
                        currentType = 1;
                        current += c;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (currentType == 1)
                {
                    cutExpr.Add(current);
                    currentType = 0;
                    current = String.Empty;
                }
                else if (CheckCheckVar(c) && (currentType!=2))
                {
                    currentType = 2;
                    current += c;
                    if (cutExpr.Count > 0) return false;
                }
                else if (currentType == 2)
                {
                    return false;
                }
            }

            return true;
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
