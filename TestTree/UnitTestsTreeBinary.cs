using NUnit.Framework;
using Utopia.Algo.Tree.Implem;
using Utopia.Algo.Tree.Interface;


namespace TestTree
{
    public class TestsTreeBinary
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreatEmpty()
        {
            ITreeBinaryNode<string> nodeHead = new TreeBinaryNode<string>();
            Assert.NotNull(nodeHead);
            Assert.Null(nodeHead.Left);
            Assert.Null(nodeHead.Right);
            Assert.AreEqual(null,nodeHead.Value);

            nodeHead.Value = "HeadNode";
            Assert.AreEqual("HeadNode",nodeHead.Value);
        }

        [Test]
        public void TestCreatSimpleLeftRight01()
        {
            ITreeBinaryNode<string> nodeHead = new TreeBinaryNode<string>("H");
            nodeHead.Left = new TreeBinaryNode<string>("L");
            nodeHead.Right = new TreeBinaryNode<string>("R");

            Assert.AreEqual("H", nodeHead.Value);
            Assert.AreEqual("L", nodeHead.Left.Value);
            Assert.AreEqual("R", nodeHead.Right.Value);
        }

        [Test]
        public void TestCreatSimpleLeftRight02()
        {
            ITreeBinaryNode<string> nodeHead = new TreeBinaryNode<string>("H", new TreeBinaryNode<string>("L"),new TreeBinaryNode<string>("R"));

            Assert.AreEqual("H", nodeHead.Value);
            Assert.AreEqual("L", nodeHead.Left.Value);
            Assert.AreEqual("R", nodeHead.Right.Value);
        }

        [Test]
        public void TestCreatSimpleLeftRight03()
        {
            ITreeBinaryNode<string> nodeHead = new TreeBinaryNode<string>(
                "H", 
                new TreeBinaryNode<string>("L", new TreeBinaryNode<string>("LL"), new TreeBinaryNode<string>("LR")), 
                new TreeBinaryNode<string>("R", new TreeBinaryNode<string>("RL"), new TreeBinaryNode<string>("RR")));

            Assert.AreEqual("H", nodeHead.Value);
            Assert.AreEqual("LL", nodeHead.Left.Left.Value);
            Assert.AreEqual("LR", nodeHead.Left.Right.Value);
            Assert.AreEqual("RL", nodeHead.Right.Left.Value);
            Assert.AreEqual("RR", nodeHead.Right.Right.Value);
        }

        [Test]
        public void TestCreatSimpleLeftRight04()
        {
            ITreeBinaryNode<string> nodeHead = new TreeBinaryNode<string>(
                "A",
                new TreeBinaryNode<string>("B", new TreeBinaryNode<string>("D"), new TreeBinaryNode<string>("E")),
                new TreeBinaryNode<string>("C", new TreeBinaryNode<string>("F"), new TreeBinaryNode<string>("G")));

            Assert.AreEqual("A", nodeHead.Value);
            Assert.AreEqual("B", nodeHead.Left.Value);
            Assert.AreEqual("D", nodeHead.Left.Left.Value);
            Assert.AreEqual("E", nodeHead.Left.Right.Value);
            Assert.AreEqual("C", nodeHead.Right.Value);
            Assert.AreEqual("F", nodeHead.Right.Left.Value);
            Assert.AreEqual("G", nodeHead.Right.Right.Value);
        }
    }
}
