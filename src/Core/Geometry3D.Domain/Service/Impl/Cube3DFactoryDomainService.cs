namespace Geometry3D.Domain.Service.Impl
{
    using Model;
    using Model.Shape;

    public class Cube3DFactoryDomainService: ICube3DFactoryDomainService
    {
        public Cube3D InstantiateFromOppositeVertices(Dot3D a, Dot3D b)
        {
            throw new System.NotImplementedException();
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
