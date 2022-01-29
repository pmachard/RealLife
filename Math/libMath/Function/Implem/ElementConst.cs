using Math.Function.Interface;

namespace Math.Function.implem
{
    public class ElementConst<T> : IElement<T> 
    {
        public T Value { get; set; }

        public T Unit()
        {
            return new T;
        }

        public T Evaluate(T value)
        {
            return this.Value;
        }
    }
}
