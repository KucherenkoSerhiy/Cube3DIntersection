namespace Geometry3D.Domain.Test.Model
{
    using Domain.Model;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Dot3DTest
    {
        [Test]
        public void Equals_ThatNull_False()
        {
            Dot3D a = new Dot3D();
            Dot3D b = null;
            Assert.IsFalse(a.Equals(b));
        }

        [Test]
        public void Equals_ThatIsNotDot3D_False()
        {
            Dot3D a = new Dot3D();
            var b = new object();
            Assert.IsFalse(a.Equals(b));
        }

        [Test]
        public void Equals_DifferentCoordinateX_False()
        {
            Dot3D a = new Dot3D{X = 1, Y = 1, Z = 1};
            Dot3D b = new Dot3D{X = 2, Y = 1, Z = 1};
            Assert.IsFalse(a.Equals(b));
        }

        [Test]
        public void Equals_DifferentCoordinateY_False()
        {
            Dot3D a = new Dot3D{X = 1, Y = 1, Z = 1};
            Dot3D b = new Dot3D{X = 1, Y = 2, Z = 1};
            Assert.IsFalse(a.Equals(b));
        }

        [Test]
        public void Equals_DifferentCoordinateZ_False()
        {
            Dot3D a = new Dot3D{X = 1, Y = 1, Z = 1};
            Dot3D b = new Dot3D{X = 1, Y = 1, Z = 2};
            Assert.IsFalse(a.Equals(b));
        }

        [Test]
        public void Equals_SameCoordinates_True()
        {
            Dot3D a = new Dot3D{X = 1, Y = 1, Z = 1};
            Dot3D b = new Dot3D{X = 1, Y = 1, Z = 1};
            Assert.IsTrue(a.Equals(b));
        }
    }
}