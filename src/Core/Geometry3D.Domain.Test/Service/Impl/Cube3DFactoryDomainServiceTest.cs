namespace Geometry3D.Domain.Test.Service.Impl
{
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Cube3DFactoryDomainServiceTest
    {
        [Test]
        public void InstantiateFromOppositeVertices_SameCoordinates_Throws()
        {
            Assert.Fail();
        }

        [Test]
        public void InstantiateFromOppositeVertices_DifferentCoordinates_Ok()
        {
            Assert.Fail();
        }

        [Test]
        public void InstantiateFromOppositeEdges_SameOrigin_Throws()
        {
            Assert.Fail();
        }

        [Test]
        public void InstantiateFromOppositeEdges_DifferentDirection_Throws()
        {
            Assert.Fail();
        }

        [Test]
        public void InstantiateFromOppositePlanes_SameOrigin_Throws()
        {
            Assert.Fail();
        }

        [Test]
        public void InstantiateFromOppositePlanes_DifferentDirection_Throws()
        {
            Assert.Fail();
        }
    }
}