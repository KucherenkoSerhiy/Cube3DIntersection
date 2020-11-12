namespace Geometry3D.Domain.Test.Service.Impl
{
    using System;
    using Domain.Model;
    using Domain.Service.Impl;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Cube3DFactoryDomainServiceTest
    {
        [Test]
        public void InstantiateFromOppositeVertices_SameCoordinates_Throws()
        {
            Dot3D a = new Dot3D {X = 1, Y = 1, Z = 1};
            Dot3D b = new Dot3D {X = 1, Y = 1, Z = 1};
            var sut = new Cube3DFactoryDomainService();

            Assert.Throws<ArgumentException>(() => sut.InstantiateFromOppositeVertices(a, b));
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