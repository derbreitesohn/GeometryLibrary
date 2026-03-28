using System;
using System.Runtime.CompilerServices;

namespace GeometryLibrary.Shape;

public class Tetrahedron : Shape
{
    // Four vertices to store your tetrahedron
    private Vertex[] vertices = new Vertex[4];
    Random random = new Random();
    public Tetrahedron()
    {
        for (int i = 0; i < 4; i++)
        {
            vertices[i] = new Vertex {X = random.NextDouble(), Y = random.NextDouble(), Z = random.NextDouble()};
        }
    }
    // A method named Centroid() to calculate the centroid of the tetrahedron
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
        // divide by 4 for avg
        return new Vertex {X = sumX / 4, Y = sumY / 4, Z = sumZ / 4};
    }

     // A method named SurfaceArea() to calculate surface area of the tetrahedron
    public SurfaceArea()
    {
        
    }

    // Constructor
}