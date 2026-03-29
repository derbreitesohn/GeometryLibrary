namespace GeometryLibrary
{
    // Vertex struct to reuse across different classes
    public struct Vertex
    {
        public double X, Y, Z;

        public static bool operator ==(Vertex left, Vertex right)
        {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }

        public static bool operator !=(Vertex left, Vertex right)
        {
            return !(left == right);
        }
        public override string ToString()
        {
            return $"(X: {X:F2}, Y: {Y:F2}, Z: {Z:F2})";
        }
    }
}