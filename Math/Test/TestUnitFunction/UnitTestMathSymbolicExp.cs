using NUnit.Framework;
using Utopia.Math.Symbolic.Interface;
using Utopia.Math.Symbolic.Implem;

namespace Utopia.Math.Symbolic.Test
{
    public class UnitTestMathSymbolicExp
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestExpCreateTerm()
        {
            ISymbolExp exp = new SymbolExp(new SymbolTerm());
            Assert.IsNotNull(exp);
            Assert.IsNull(exp.Exp);
            Assert.IsNull(exp.Operator);
            Assert.IsNotNull(exp.Term);
        }

        [Test]
        public void TestExpCreateTermAdd()
        {
            ISymbolExp exp = new SymbolExp( new SymbolExp(), 
                                            new SymbolOperator('+'), 
                                            new SymbolTerm());
            Assert.IsNotNull(exp);
            Assert.IsNotNull(exp.Exp);
            Assert.IsNotNull(exp.Operator);
            Assert.AreEqual(ISymbolOperator.EnumOperator.Add, exp.Operator.Operator);
            Assert.IsNotNull(exp.Term);
        }

        [Test]
        public void TestExpCreateAdd()
        {
            ISymbolExp exp = new SymbolExp( new SymbolExp(),
                                            new SymbolOperator('-'),
                                            new SymbolTerm());
            Assert.IsNotNull(exp);
            Assert.IsNotNull(exp.Exp);
            Assert.AreEqual(ISymbolOperator.EnumOperator.Remove, exp.Operator.Operator);
            Assert.IsNotNull(exp.Term);
        }

        [Test]
        public void TestExpCreateSubb()
        {
            ISymbolExp exp = new SymbolExp( new SymbolExp(),
                                            new SymbolOperator('+'),
                                            new SymbolTerm());
            Assert.IsNotNull(exp);
            Assert.IsNotNull(exp.Exp);
            Assert.AreEqual(ISymbolOperator.EnumOperator.Add, exp.Operator.Operator);
            Assert.IsNotNull(exp.Term);
        }

        [Test]
        public void TestExpCreateMult()
        {
            IExpTerm term = new SymbolTerm( new SymbolTerm(),
                                            new SymbolOperator('*'),
                                            new SymbolFactor());
            Assert.IsNotNull(term);
            Assert.IsNotNull(term.Term);
            Assert.AreEqual(ISymbolOperator.EnumOperator.Multiply, term.Operator.Operator);
            Assert.IsNotNull(term.Factor);
        }

        [Test]
        public void TestExpCreateDiv()
        {
            IExpTerm term = new SymbolTerm( new SymbolTerm(),
                                            new SymbolOperator('/'),
                                            new SymbolFactor());
            Assert.IsNotNull(term);
            Assert.IsNotNull(term.Term);
            Assert.AreEqual(ISymbolOperator.EnumOperator.Divide, term.Operator.Operator);
            Assert.IsNotNull(term.Factor);
        }
    }
}
