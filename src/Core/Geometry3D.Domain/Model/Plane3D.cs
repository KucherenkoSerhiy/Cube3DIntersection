namespace Geometry3D.Domain.Model
{
    using Core;

    public class Plane3D : ValueObject
    {
        public Dot3D Origin { get; set; }
        public Vector3D Y { get; set; }
        public Vector3D Z { get; set; }
    }
}
