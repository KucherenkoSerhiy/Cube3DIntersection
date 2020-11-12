namespace Geometry3D.Domain.Model
{
    using Core;

    public class Vector3D : ValueObject
    {
        public Dot3D Origin { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
