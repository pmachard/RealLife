namespace Utopia.Math.Function.Interface
{
    public interface ICell<T> where T : new()
    {
        IElement<T> Evaluate(IElement<T> element);
    }
}
