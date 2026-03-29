using System;

namespace GeometryLibrary.Shape;

public class Tetrahedron : Shape
{
    // Four vertices to store your tetrahedron
    private Vertex[] vertices = new Vertex[4];
    private static readonly Random random = new Random();

    public Tetrahedron()
    {
        for (int i = 0; i < 4; i++)
        {
            vertices[i] = new Vertex 
            { 
                X = random.NextDouble(), 
                Y = random.NextDouble(), 
                Z = random.NextDouble() 
            };
        }
    }

    // Operator overloads for comparing two Tetrahedrons
    public static bool operator ==(Tetrahedron left, Tetrahedron right)
    {
        // Handle null cases for equality
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;

        // Compare individual vertices
        for (int i = 0; i < 4; i++)
        {
            if (left.vertices[i] != right.vertices[i])
            {
                return false; 
            }
        }
        return true;
    }

    public static bool operator !=(Tetrahedron left, Tetrahedron right)
    {
        return !(left == right);
    }

    // Calculates the centroid (the geometric center)
    public Vertex Centroid()
    {
        double sumX = 0;
        double sumY = 0;
        double sumZ = 0;

        foreach (var vertex in vertices)
        {
            sumX += vertex.X;
            sumY += vertex.Y;
            sumZ += vertex.Z;
        }

        return new Vertex 
        { 
            X = sumX / 4, 
            Y = sumY / 4, 
            Z = sumZ / 4 
        };
    }

    // Helper function for cross product to keep the SurfaceArea() clean
    private double CalculateFaceArea(Vertex a, Vertex b, Vertex c)
    {
        Vertex vectorAB = new Vertex 
        { 
            X = b.X - a.X, 
            Y = b.Y - a.Y, 
            Z = b.Z - a.Z 
        };

        Vertex vectorAC = new Vertex
        {
            X = c.X - a.X, 
            Y = c.Y - a.Y, 
            Z = c.Z - a.Z
        };

        Vertex crossProduct = new Vertex
        {
            X = (vectorAB.Y * vectorAC.Z) - (vectorAB.Z * vectorAC.Y),
            Y = (vectorAB.Z * vectorAC.X) - (vectorAB.X * vectorAC.Z),
            Z = (vectorAB.X * vectorAC.Y) - (vectorAB.Y * vectorAC.X)
        };

        // Calc magnitude of cross product and divide by 2 for triangle area
        double magnitude = Math.Sqrt(
            (crossProduct.X * crossProduct.X) + 
            (crossProduct.Y * crossProduct.Y) + 
            (crossProduct.Z * crossProduct.Z)
        );

        return magnitude / 2;
    }

    // Calculates the total surface area of the four triangular faces
    public override double SurfaceArea()
    {
        double area1 = CalculateFaceArea(vertices[0], vertices[1], vertices[2]);
        double area2 = CalculateFaceArea(vertices[2], vertices[3], vertices[0]);
        double area3 = CalculateFaceArea(vertices[3], vertices[0], vertices[1]);
        double area4 = CalculateFaceArea(vertices[1], vertices[2], vertices[3]);

        return area1 + area2 + area3 + area4;
    }
}