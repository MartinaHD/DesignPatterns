using System;

public abstract class Shape
{  
    public string Id { get; set; }

    protected string Type { get; set; }

    public abstract Shape Clone();
}

public class Rectangle : Shape
{
    public Rectangle()
    {
        Type = "Rectangle";
    }

    public override Shape Clone() => (Shape) MemberwiseClone();
}

public class Circle : Shape
{
    public Circle()
    {
        Type = "Circle";
    }

    public override Shape Clone() => (Shape) MemberwiseClone();
}

public class Square : Shape
{
    public Square()
    {
        Type = "Square";
    }

    public override Shape Clone() => (Shape) MemberwiseClone();
}

public class ShapeCache
{
    private static readonly Dictionary<string, Shape> shapesDictionary = new Dictionary<string, Shape>();

    public static Shape GetShape(string shapeId)
    {
        Shape cachedShape = shapesDictionary[shapeId];
        return cachedShape.Clone();
    }

    public static void LoadCache()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Id = "1";
        shapesDictionary.Add(rectangle.Id, rectangle);

        Circle circle = new Circle();
        circle.Id = "2";
        shapesDictionary.Add(circle.Id, circle);

        Square square = new Square();
        square.Id = "3";
        shapesDictionary.Add(square.Id, square);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ShapeCache.LoadCache();

        Shape firstClonedShape = ShapeCache.GetShape("1");
        Console.WriteLine("Shape cloned : " + firstClonedShape.GetType(), firstClonedShape.Id);

        Shape secondClonedShape = ShapeCache.GetShape("2");
        Console.WriteLine("Shape cloned : " + secondClonedShape.GetType(), secondClonedShape.Id);

        Shape thirdClonedShape = ShapeCache.GetShape("3");
        Console.WriteLine("Shape cloned : " + thirdClonedShape.GetType(), thirdClonedShape.Id);
    }
}