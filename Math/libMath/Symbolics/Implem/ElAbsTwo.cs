using System;
using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public abstract class ElAbsTwo : ElAbs 
    {
        public IEl Left { get; set; }
        public IEl Right { get; set; }

        public ElAbsTwo()
        {
            Left = null;
            Right = null;
        }
        public ElAbsTwo(IEl left, IEl right)
        {
            Left = left;
            Right = right;
        }
        public ElAbsTwo(double left, IEl right)
        {
            Left = new ElConst(left);
            Right = right;
        }
        public ElAbsTwo(IEl left, double right)
        {
            Left = left;
            Right = new ElConst(right);
        }

        public override void Fix(double valueFix) { }
    }
}
