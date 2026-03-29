using System;
using System.Collections.Generic;

namespace GeometryLibrary;

public class CompositeShape : Shape
{
    private List<Shape> shapes = new List<Shape>();
    private static  Random random = new Random();

    // Default constructor
    public CompositeShape() : base(0) { }

    // Constructor that initializes with n random shapes
    public CompositeShape(int n) : base(0)
    {
        for (int i = 0; i < n; i++)
        {
            int choice = random.Next(3); // random int (0, 1, 2) based on this create shape
            switch (choice)
            {
                case 0:
                    AddShape(new Tetrahedron());
                    break;
                case 1:
                    AddShape(new Cuboid());
                    break;
                default:
                    AddShape(new Cylinder());
                    break;
            }
        }
    }

    public void AddShape(Shape shape)
    {
        shapes.Add(shape); // adds object to List 
    }

    // Override the [] operator (Indexer)
    // This lets us use 'myComposite[i]' like an array
    public Shape this[int index]
    {
        get { return shapes[index]; }
        set { shapes[index] = value; }
    }

    // A method named IsIn(Shape s) that returns an int
    public int IsIn(Shape s)
    {
        // find where 's' is in our list
        return shapes.IndexOf(s);
        
    }

    public override double Volume()
    {
        double currentTotal = 0;
        foreach (Shape shape in shapes)
        {
            currentTotal += shape.Volume();
        }
        return currentTotal;
    }

    public override double SurfaceArea()
    {
        double totalArea = 0;
        foreach (Shape shape in shapes)
        {
            totalArea += shape.SurfaceArea();
        }
        return totalArea;
    }

    public void Sort()
        {
            shapes.Sort();
        }
}