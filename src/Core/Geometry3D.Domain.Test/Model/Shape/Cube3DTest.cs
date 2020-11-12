namespace Geometry3D.Domain.Test.Model.Shape
{
    using Domain.Model.Shape;
    using NUnit.Framework;

    [TestFixture]
    public class Cube3DTest
    {
        [Test]
        public void Id_Ok()
        {
            string referenceId = "a cube";
            int vertices = 0;
            string expected = $"{referenceId}{vertices}";
            Cube3D cube = new Cube3D {ReferenceId = referenceId};

            Assert.IsNotNull(cube);
            Assert.AreEqual(expected, cube.Id);
        }
    }
}