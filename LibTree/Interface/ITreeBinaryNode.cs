namespace Utopia.Algo.Tree.Interface
{
    public interface ITreeBinaryNode<T>
    {
        ITreeBinaryNode<T> Left { get; set; } 
        ITreeBinaryNode<T> Right { get; set; }
        T Value { get; set; }
    }
}