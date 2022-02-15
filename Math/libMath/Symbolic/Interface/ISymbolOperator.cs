namespace Utopia.Math.Symbolic.Interface
{
    public interface ISymbolOperator
    {
        public enum EnumPriority
        {   
            Low = 1, 
            Hight = 2,
            Undefined = 0
        }
        public enum EnumOperator 
        {
            Add = '+',
            Remove = '-',
            Multiply = '*',
            Divide = '/',
            Undefined = ' '
        }

        EnumPriority Priority { get; }
        EnumOperator Operator { get; set; }
    }
}
