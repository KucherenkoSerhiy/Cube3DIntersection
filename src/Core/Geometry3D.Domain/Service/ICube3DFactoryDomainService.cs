namespace Geometry3D.Domain.Service
{
    using Model;
    using Model.Shape;

    public interface ICube3DFactoryDomainService
    {
        Cube3D InstantiateFromOppositeVertices(Dot3D a, Dot3D b);
        Cube3D InstantiateFromOppositeEdges(Vector3D a, Vector3D b);
        Cube3D InstantiateFromOppositePlanes(Plane3D a, Plane3D b);
    }
}