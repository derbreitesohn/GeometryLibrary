using System;
namespace GeometryLibrary.Shape
{
    public class Tetrahedron : Shape
    {
        private static  Random random = new Random();
        public Tetrahedron() : base(4)
        {
            for (int i = 0; i < 4; i++)
            {
                vertices[i] = new Vertex 
                { 
                    X = random.NextDouble() * 10, // * 10 for better visibility when printing
                    Y = random.NextDouble() * 10, 
                    Z = random.NextDouble() * 10 
                };
            }
        }

        public Tetrahedron(Tetrahedron other) : base(4) // 4 vertices
        {
            for (int i = 0; i < 4; i++)
            {
                this.vertices[i] = other.vertices[i];
            }
        }

        // override because Shape defines it as abstract
        public override double Volume()
        {
            return 0; 
        }
        // Calculates the total surface area 
        public override double SurfaceArea()
        {
            double area1 = CalculateFaceArea(vertices[0], vertices[1], vertices[2]);
            double area2 = CalculateFaceArea(vertices[2], vertices[3], vertices[0]);
            double area3 = CalculateFaceArea(vertices[3], vertices[0], vertices[1]);
            double area4 = CalculateFaceArea(vertices[1], vertices[2], vertices[3]);

            return area1 + area2 + area3 + area4;
        }

        // Helper function for triangle area calculation
        private double CalculateFaceArea(Vertex a, Vertex b, Vertex c)
        {
            Vertex vectorAB = new Vertex { X = b.X - a.X, Y = b.Y - a.Y, Z = b.Z - a.Z };
            Vertex vectorAC = new Vertex { X = c.X - a.X, Y = c.Y - a.Y, Z = c.Z - a.Z };

            Vertex crossProduct = new Vertex
            {
                X = (vectorAB.Y * vectorAC.Z) - (vectorAB.Z * vectorAC.Y),
                Y = (vectorAB.Z * vectorAC.X) - (vectorAB.X * vectorAC.Z),
                Z = (vectorAB.X * vectorAC.Y) - (vectorAB.Y * vectorAC.X)
            };

            double magnitude = Math.Sqrt(
                (crossProduct.X * crossProduct.X) + 
                (crossProduct.Y * crossProduct.Y) + 
                (crossProduct.Z * crossProduct.Z)
            );

            return magnitude / 2;
        }

       
        public static bool operator ==(Tetrahedron left, Tetrahedron right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;

            for (int i = 0; i < 4; i++)
            {
                if (left.vertices[i] != right.vertices[i]) return false;
            }
            return true;
        }

        public static bool operator !=(Tetrahedron left, Tetrahedron right)
        {
            return !(left == right);
        }
    }
}