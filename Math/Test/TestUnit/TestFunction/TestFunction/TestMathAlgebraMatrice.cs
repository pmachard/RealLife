using NUnit.Framework;
using Utopia.Math.Algebra.Implem;
using Utopia.Math.Algebra.Interface;

namespace Utopia.Math.Algebra.UnitTest
{
    public class TestMathAlgebraMatrice
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMatriceEmpty()
        {
            Assert.IsNotNull(new Matrice());
        }

        [Test]
        public void TestMatriceWithSise()
        {
            int n = 10;
            var matrice = new Matrice(n);
            Assert.IsNotNull(matrice);

            Assert.AreEqual(10, matrice.NbLine);
            Assert.AreEqual(10, matrice.NbColonne);
        }
        [Test]

        public void TestMatriceWithSiseNM()
        {
            int n = 10;
            int m = 20;
            var matrice = new Matrice(n,m);
            Assert.IsNotNull(matrice);

            Assert.AreEqual(10, matrice.NbLine);
            Assert.AreEqual(20, matrice.NbColonne);
        }

        public void TestMatriceWithTableau()
        {
            double[,] tabMatrtice = new double[2, 3];

            tabMatrtice[0, 0] = 0.0;
            tabMatrtice[0, 1] = 1.0;

            tabMatrtice[1, 0] = 2.0;
            tabMatrtice[1, 1] = 3.0;

            tabMatrtice[2, 0] = 4.0;
            tabMatrtice[2, 1] = 5.0;

            var matrice = new Matrice(tabMatrtice);
            Assert.IsNotNull(matrice);

            Assert.AreEqual(10, matrice.NbLine);
            Assert.AreEqual(20, matrice.NbColonne);
        }

    }
}