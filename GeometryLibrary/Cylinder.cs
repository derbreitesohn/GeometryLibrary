using System;
namespace GeometryLibrary.Shape;

public class Cylinder : Shape
{
    private static  Random random = new Random();
    private double radius;

    public Cylinder() : base(2) // 2 vertices for the two circular bases
    {
        this.radius = random.NextDouble() * 10; // Random radius
        double height = random.NextDouble() * 10; // Random height

        // Base center at (0,0,0) and top center at (0,0,height)
        vertices[0] = new Vertex { X = 0, Y = 0, Z = 0 }; // Bottom center
        vertices[1] = new Vertex { X = 0, Y = 0, Z = height }; // Top center
    }

        public Cylinder(Cylinder other) : base(2)
        {
            this.radius = other.radius;
            for (int i = 0; i < 2; i++)
            {
                this.vertices[i] = other.vertices[i];
            }
        }

    // Methods
    // Override the == operator 
    // A method named Height() to calculate the height 
    public double Height()
    {
        double heightX = Math.Pow((vertices[1].X - vertices[0].X), 2);
        double heightY = Math.Pow((vertices[1].Y - vertices[0].Y), 2);
        double heightZ = Math.Pow((vertices[1].Z - vertices[0].Z), 2);

        return Math.Sqrt(heightX + heightY + heightZ);
    }

    // A method named BottomArea() to calculate the area of the bottom circle 
    public double BottomArea()
    {
        return Math.PI * (radius * radius);
    }

    // A method name Volume() to calculate the volume of the cylinder 
    public override double Volume()
    {
        return BottomArea() * Height();
    }

    // A method named SurfaceArea() to calculate surface area of the cylinder
    public override double SurfaceArea()
    {
        double width = (2 * Math.PI * radius);
        return (2* BottomArea() + Height() * width);
    }

    // Equality operators
    public static bool operator ==(Cylinder left, Cylinder right)
    {
        // Handle null cases for equality
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;
        if (left.radius != right.radius) return false; 
        // Compare individual vertices
        for (int i = 0; i < 2; i++)
        {
            if (left.vertices[i] != right.vertices[i]) return false;
        }
        return true;
        
    }

    public static bool operator !=(Cylinder left, Cylinder right) => !(left == right);

}