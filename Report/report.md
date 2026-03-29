# Report
Course: C# Development SS2026 (4 ECTS, 3 SWS)

Student ID: CC241045

BCC Group: B

Name: Flo Madner

## Methodology:
To solve the problem of managing 3D geometric data, I implemented a hierarchical class structure based on Object-Oriented Programming (OOP) principles. 

1. Abstraction: I created an abstract Shape base class. This ensures that every specific shape (like a Cuboid) must provide its own logic for Volume() and SurfaceArea().
```bash
C#
public abstract class Shape : IComparable<Shape>
{
    // These methods must be implemented by any "real" shape
    public abstract double Volume();
    public abstract double SurfaceArea();
}
```
2. Polymorphism
This shows how a specific shape like the Cuboid fulfills the "contract" set by the base class.   
```bash
C#
public class Cuboid : Shape
{
    // Providing the specific math for this shape
    public override double Volume() 
    {
        return Length * Width * Height;
    }
}
```
3. Composition
This snippet explains how CompositeShape manages a collection of different objects using a generic list.
```bash
C#
public class CompositeShape : Shape
{
    // Storing multiple shapes in one container
    private List<Shape> shapes = new List<Shape>();

    public void Add(Shape shape) 
    {
        shapes.Add(shape);
    }
}
```

4. Encapsulation: Data is stored in private fields within the CompositeShape class, managed through a List<Shape>. 

5. Geometric Logic:

- Cuboid: Calculated using length, width, and height derived from vertices.

- Cylinder: Utilizes radius and height.

- Tetrahedron: Calculated using the 3D coordinates of four vertices.

4. Sorting Logic: I implemented the IComparable<Shape> interface in the base class. This allows the program to automatically sort any collection of shapes based on their volume with a simple .Sort() call. 

## Additional Features

- Operator Overloading (+): Instead of calling a "Merge" function, I overloaded the + operator so users can combine shapes naturally. 
```bash
C#
public static CompositeShape operator +(Shape a, Shape b)
{
    CompositeShape composite = new CompositeShape();
    composite.Add(a);
    composite.Add(b);
    return composite;
}
```
- Custom Indexer ([]): This allows a CompositeShape to be treated like an array. 
```bash
C#
public Shape this[int index]
{
    get { return shapes[index]; }
}
```
- Readable Output: Overrode the ToString() method in the Vertex struct to display clean coordinates like (X: 1.0, Y: 2.0, Z: 3.0). 

## Discussion/Conclusion
The main technical challenge was Namespace Management.  Initially, naming a namespace the same as a class (GeometryLibrary.Shape) caused a compiler error (CS0101). I solved this by flattening the namespace structure to namespace GeometryLibrary;. 

Another challenge was ensuring the Sort() method inside CompositeShape correctly triggered the IComparable logic. I learned that by defining the comparison rule in the base class, the built-in List.Sort() method handles the heavy lifting automatically.

## Work with:
I worked independently on this implementation.

## Reference:
[C# Programming](https://yun-vis.net/ustp-bcc-csharp/)

[Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)