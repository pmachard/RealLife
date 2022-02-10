using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElSupp : ElAbsTwo
    {
        public ElSupp() : base() { }
        public ElSupp(IEl left, IEl right) : base(left, right) { }
        public ElSupp(double left, IEl right) : base(left, right) { }
        public ElSupp(IEl left, double right) : base(left, right) { }

        public override double Evaluate()
        {
            return Left.Evaluate() - Right.Evaluate();
        }
    }
}
