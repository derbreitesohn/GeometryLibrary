using System;
namespace GeometryLibrary.Shape;
public class Cuboid : Shape
{
  private static Random random = new Random();

  public Cuboid() : base(8)
    {
      // Pick a random starting corner and random dimensions
        double x = random.NextDouble() * 10;
        double y = random.NextDouble() * 10;
        double z = random.NextDouble() * 10;

        double l = random.NextDouble() * 10; // Length
        double w = random.NextDouble() * 10; // Width
        double h = random.NextDouble() * 10; // Height

        // Map the 8 vertices to form a box 
        vertices[0] = new Vertex { X = x,     Y = y,     Z = z };
        vertices[1] = new Vertex { X = x + l, Y = y,     Z = z };
        vertices[2] = new Vertex { X = x + l, Y = y + w, Z = z };
        vertices[3] = new Vertex { X = x,     Y = y + w, Z = z };
        vertices[4] = new Vertex { X = x,     Y = y,     Z = z + h };
        vertices[5] = new Vertex { X = x + l, Y = y,     Z = z + h };
        vertices[6] = new Vertex { X = x + l, Y = y + w, Z = z + h };
        vertices[7] = new Vertex { X = x,     Y = y + w, Z = z + h };
    }
  public Cuboid(Cuboid other) : base(8)
    {
        for (int i = 0; i < 8; i++)
        {
            this.vertices[i] = other.vertices[i];
        }
    }
  // The Centroid() Method automatically gets handled through the base in Shape.cs
  public override double Volume()
    {
      double l = Math.Abs(vertices[1].X - vertices[0].X);
      double w = Math.Abs(vertices[3].Y - vertices[0].Y);
      double h = Math.Abs(vertices[4].Z - vertices[0].Z);
      return l * w * h;  
    }

  public override double SurfaceArea()
    {
        double l = Math.Abs(vertices[1].X - vertices[0].X);
        double w = Math.Abs(vertices[3].Y - vertices[0].Y);
        double h = Math.Abs(vertices[4].Z - vertices[0].Z);
        return 2 * (l * w + l * h + w * h);
    }

   // Equality operators
    public static bool operator ==(Cuboid left, Cuboid right)
    {
        // Handle null cases for equality
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;
        // Compare individual vertices
        for (int i = 0; i < 8; i++)
        {
            if (left.vertices[i] != right.vertices[i]) return false; 
        }
        return true;
    }

    public static bool operator !=(Cuboid left, Cuboid right) => !(left == right);
}
