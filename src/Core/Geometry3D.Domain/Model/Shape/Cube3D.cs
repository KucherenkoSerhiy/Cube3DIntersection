namespace Geometry3D.Domain.Model.Shape
{
    using System.Collections.Generic;

    public class Cube3D: Shape3D
    {
        public string ReferenceId { get; set; }
        public override string Id => $"{this.ReferenceId}{this.Vertices.Count}";

        public Cube3D()
        {
            this.Vertices = new List<Dot3D>();
            this.Edges = new List<Vector3D>();
            this.Planes = new List<Plane3D>();
        }
    }
}
