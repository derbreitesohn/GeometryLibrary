using System;

namespace GeometryLibrary
{
    public abstract class Shape : IComparable<Shape>
    {
        // Protected so children like Cuboid can see it
        protected Vertex[] vertices;
        // Constructor tells base class how many vertices to prep
        protected Shape(int vertexCount)
        {
            vertices = new Vertex[vertexCount];
        }
        public abstract double Volume();
        public abstract double SurfaceArea(); 

        // Shared Averaging all vertices
        public Vertex Centroid()
        {
            double sumX = 0, sumY = 0, sumZ = 0;
            foreach (var v in vertices)
            {
                sumX += v.X;
                sumY += v.Y;
                sumZ += v.Z;
            }
            return new Vertex { X = sumX / vertices.Length, Y = sumY / vertices.Length, Z = sumZ / vertices.Length };
        }

        public int CompareTo(Shape other)
        {
            if (other == null) return 1; 
            return this.Volume().CompareTo(other.Volume());
        }

        public static CompositeShape operator +(Shape a, Shape b)
        {
            CompositeShape composite = new CompositeShape(0); 
            
            
            return composite;
        }
    }
}