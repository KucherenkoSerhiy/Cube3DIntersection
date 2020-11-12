namespace Geometry3D.Domain.Model.Shape
{
    public class Cube3D: Shape3D
    {
        public string ReferenceId { get; set; }
        public override string Id => $"{this.ReferenceId}{this.Vertices.Count}";
    }
}
