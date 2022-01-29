namespace Math.Function.Interface
{
    public interface ICell<T>
    {
        IElement<T> Evaluate(IElement<T> element);
    }
}
