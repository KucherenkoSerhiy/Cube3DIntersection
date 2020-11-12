namespace Geometry3D.Domain.Service.Impl
{
    using System;
    using Model;
    using Model.Shape;

    public class Cube3DFactoryDomainService: ICube3DFactoryDomainService
    {
        public Cube3D InstantiateFromOppositeVertices(Dot3D a, Dot3D b)
        {
            // TODO: if (a.Equals(b))
            if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
                throw new ArgumentException("Dots cannot be on the same spot");
            return new Cube3D();
        }

        public Cube3D InstantiateFromOppositeEdges(Vector3D a, Vector3D b)
        {
            throw new System.NotImplementedException();
        }

        public Cube3D InstantiateFromOppositePlanes(Plane3D a, Plane3D b)
        {
            throw new System.NotImplementedException();
        }
    }
}
