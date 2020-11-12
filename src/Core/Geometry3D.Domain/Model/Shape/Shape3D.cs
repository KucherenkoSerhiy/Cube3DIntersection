namespace Geometry3D.Domain.Model.Shape
{
    using System.Collections.Generic;
    using Core;

    public abstract class Shape3D: AggregateRoot
    {
        public List<Dot3D> Vertices { get; set; }
        public List<Vector3D> Edges { get; set; }
        public List<Plane3D> Planes { get; set; }
    }
}
