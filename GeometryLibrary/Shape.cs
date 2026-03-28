using System;

namespace GeometryLibrary
{
    public abstract class Shape : IComparable<Shape>
    {
        public Shape() 
        { 
        }

        public Shape(Shape other) 
        { 
        }

        public abstract double Volume();
        public abstract double SurfaceArea(); 

        public int CompareTo(Shape other)
        {
            if (other == null)
            {
                return 1; 
            }
            return this.Volume().CompareTo(other.Volume());
        }

        public static CompositeShape operator +(Shape a, Shape b)
        {
            CompositeShape composite = new CompositeShape(0); 
            
            
            return composite;
        }
    }
}