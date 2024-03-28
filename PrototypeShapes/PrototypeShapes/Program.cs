using System;

public class Program
{
    public static void Main(string[] args)
    {
        ShapeCache.loadCache();

        Shape clonedShape1 = ShapeCache.getShape("1");
        Console.WriteLine("Shape cloned : " + clonedShape1.getType(), clonedShape1.getId());

        Shape clonedShape2 = ShapeCache.getShape("2");
        Console.WriteLine("Shape cloned : " + clonedShape2.getType(), clonedShape2.getId());

        Shape clonedShape3 = ShapeCache.getShape("3");
        Console.WriteLine("Shape cloned : " + clonedShape3.getType(), clonedShape3.getId());
    }
}

abstract class Shape
{
    private string id;

    protected string type;

    public string getId()
    {
        return id;
    }

    public void setId(string id)
    {
        this.id = id;
    }

    public string getType()
    {
        return type;
    }

    public abstract Shape clone();
}

class Rectangle : Shape
{
    public Rectangle()
    {
        type = "Rectangle";
    }

    public override Shape clone()
    {
        return new Rectangle();
    }
}

class Circle : Shape
{
    public Circle()
    {
        type = "Circle";
    }

    public override Shape clone()
    {
        return new Circle();
    }
}

class Square : Shape
{
    public Square()
    {
        type = "Square";
    }


    public override Shape clone()
    {
        return new Square();
    }
}

class ShapeCache
{
    private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

    public static Shape getShape(string shapeId)
    {
        Shape cachedShape = shapeMap[shapeId];
        return (Shape)cachedShape.clone();
    }

    public static void loadCache()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.setId("1");
        shapeMap.Add(rectangle.getId(), rectangle);

        Circle circle = new Circle();
        circle.setId("2");
        shapeMap.Add(circle.getId(), circle);

        Square square = new Square();
        square.setId("3");
        shapeMap.Add(square.getId(), square);
    }
}