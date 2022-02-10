using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElDiv : ElAbsTwo
    {
        public ElDiv() : base() { }
        public ElDiv(IEl left, IEl right) : base(left, right) { }
        public ElDiv(double left, IEl right) : base(left, right) { }
        public ElDiv(IEl left, double right) : base(left, right) { }

        public override double Evaluate()
        {
            return Left.Evaluate() / Right.Evaluate();
        }
    }
}
