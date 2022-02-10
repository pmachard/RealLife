using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElAdd : ElAbsTwo
    {
        public ElAdd() : base() { }
        public ElAdd(IEl left, IEl right) : base(left, right) { }
        public ElAdd(double left, IEl right) : base(left, right) { }
        public ElAdd(IEl left, double right) : base(left, right) { }

        public override double Evaluate()
        {
            return Left.Evaluate() + Right.Evaluate();
        }

    }
}
