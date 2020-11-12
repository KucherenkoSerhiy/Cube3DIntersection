namespace Geometry3D.Domain.Model
{
    using Core;

    public class Dot3D : ValueObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Dot3D)) return false;
            Dot3D that = (Dot3D) obj;

            return this.X == that.X && this.Y == that.Y && this.Z == that.Z;
        }
    }
}
