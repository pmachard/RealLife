using System;
using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public abstract class ElAbs : IEl
    {
        public virtual double Unit() => 1.0;
        public virtual double Zero() => 0.0;
        public virtual double NaN() => double.NaN;

        public abstract double Evaluate();
        public virtual void Fix(double valueFix) { }

        public IEl Add(IEl t2) => null;
        public IEl Div(IEl t2) => null;
        public IEl Mult(IEl t2) => null;
        public IEl Supp(IEl t2) => null;
    }
}
