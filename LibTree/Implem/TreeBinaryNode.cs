using Utopia.Algo.Tree.Interface;

namespace Utopia.Algo.Tree.Implem
{
    public class TreeBinaryNode<T> : ITreeBinaryNode<T> where T : class
    {
        public TreeBinaryNode()
        {
            Value = null;
            Left = null;
            Right = null;
        }

        public TreeBinaryNode(T v)
        {
            Value = v;
            Left = null;
            Right = null;
        }

        public TreeBinaryNode(T v, ITreeBinaryNode<T> l, ITreeBinaryNode<T> r)
        {
            Value = v;
            Left = l;
            Right = r;
        }

        public ITreeBinaryNode<T> Left { get; set; }
        public ITreeBinaryNode<T> Right { get; set; }
        public T Value { get; set; }
    }
}