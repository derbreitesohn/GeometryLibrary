using System.Reflection.Metadata;
using GeometryLibrary;

namespace Computation;

class Program
{
    static void Main(string[] args)
    {
        Cuboid cuboid1 = new Cuboid();
        Console.WriteLine($"The volume of Cuboid 1 is: {cuboid1.Volume()}");
        Console.WriteLine($"Surface Area: {cuboid1.SurfaceArea()}");
        Console.WriteLine($"Centroid: {cuboid1.Centroid()}");

        Tetrahedron tetrahedron1 = new Tetrahedron();
        Console.WriteLine($"The volume of Tetrahedron 1 is: {tetrahedron1.Volume()}");
        Console.WriteLine($"Surface Area: {tetrahedron1.SurfaceArea()}");
        Console.WriteLine($"Centroid: {tetrahedron1.Centroid()}");

        Cylinder cylinder1 = new Cylinder();
        Console.WriteLine($"The volume of Cylinder 1 is: {cylinder1.Volume()}");
        Console.WriteLine($"Surface Area: {cylinder1.SurfaceArea()}");
        Console.WriteLine($"Centroid: {cylinder1.Centroid()}");

        // Composite Shapes 
        CompositeShape myComposite1 = cylinder1 + cuboid1;
        Console.WriteLine($"The volume of myComposite 1 is: {myComposite1.Volume()}");
        Console.WriteLine($"Surface Area: {myComposite1.SurfaceArea()}");
        myComposite1.Sort();
        
        int cuboidIndex = myComposite1.IsIn(cuboid1);
        Console.WriteLine($"The sorted index of cuboid1 is: {cuboidIndex}");
        // Access the shape using the overloaded [] indexer
        Shape foundShape = myComposite1[cuboidIndex];

        // Make a copy using the Cuboid copy constructor (we cast it to Cuboid first)
        Cuboid copiedCuboid = new Cuboid((Cuboid)foundShape);

        Console.WriteLine($"Successfully made a copy of the cuboid! Copied volume: {copiedCuboid.Volume()}");

        CompositeShape myComposite2 = tetrahedron1 + cuboid1 + cylinder1;
        Console.WriteLine($"The volume of myComposite 2 is: {myComposite2.Volume()}");
        Console.WriteLine($"Surface Area: {myComposite2.SurfaceArea()}");
        myComposite2.Sort();
        
        



    }
}