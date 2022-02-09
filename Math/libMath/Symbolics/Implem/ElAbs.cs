using System;
using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public abstract class ElAbs : IEl
    {
        abstract public double Unit();
        abstract public double Zero();

        abstract public IEl Add(IEl t2);
        abstract public IEl Div(IEl t2);
        abstract public IEl Mult(IEl t2);
        abstract public double NaN();
        abstract public IEl Supp(IEl t2);

        abstract public double Evaluate();
    }
}
