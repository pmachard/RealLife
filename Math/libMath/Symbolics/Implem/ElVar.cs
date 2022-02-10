using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElVar : ElAbs
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public ElVar() 
        { 
        }
        public ElVar(double value)
        {
            Value = value;
        }
        public ElVar(string varName)
        {
            Name = varName;
        }


        public override double Evaluate()
        {
            return Value;
        }
        public override void Fix(double valueFix)
        {
            Value = valueFix;
        }

        public new IEl Add(IEl right)
        {
            return new ElConst(this.Evaluate() + right.Evaluate());
        }
        public new IEl Supp(IEl right)
        {
            return new ElConst(this.Evaluate() - right.Evaluate());
        }
        public new IEl Mult(IEl right)
        {
            return new ElConst( this.Evaluate() * right.Evaluate() );
        }
        public new IEl Div(IEl right)
        {
            return new ElConst(this.Evaluate() / right.Evaluate());
        }
    }
}
