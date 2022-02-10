using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElMult : ElAbsTwo
    {
        public ElMult() : base() { }
        public ElMult(IEl left, IEl right) : base(left, right) { }
        public ElMult(double left, IEl right) : base(left, right) { }
        public ElMult(IEl left, double right) : base(left, right) { }

        public override double Evaluate()
        {
            return Left.Evaluate() * Right.Evaluate();
        }
    }
}
