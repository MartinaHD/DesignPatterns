public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw() => Console.WriteLine("Circle. Drawing...");
}

public class Square : IShape
{
    public void Draw() => Console.WriteLine("Square. Drawing...");
}

public class Triangle : IShape
{
    public void Draw() => Console.WriteLine("Triangle. Drawing...");
}

public abstract class ShapeFactory
{
    public abstract IShape CreateShape();
}

public class CircleFactory : ShapeFactory
{
    public override IShape CreateShape() => new Circle();
}

public class SquareFactory : ShapeFactory
{
    public override IShape CreateShape() => new Square();
}

public class TriangleFactory : ShapeFactory
{
    public override IShape CreateShape() => new Triangle();
}

public class Program
{
    static void Main(string[] args)
    {
        ShapeFactory circleFactory = new CircleFactory();
        IShape circle = circleFactory.CreateShape();
        circle.Draw();

        ShapeFactory squareFactory = new SquareFactory();
        IShape square = squareFactory.CreateShape();
        square.Draw();

        ShapeFactory triangleFactory = new TriangleFactory();
        IShape triangle = triangleFactory.CreateShape();
        triangle.Draw();

        ShapeFactory[] shapeFactories = new ShapeFactory[3];
        shapeFactories[0] = new CircleFactory();
        shapeFactories[1] = new SquareFactory();
        shapeFactories[2] = new TriangleFactory();

        Console.WriteLine(new string('-', 40));

        foreach (ShapeFactory shapeFactory in shapeFactories)
        {
            IShape shape = shapeFactory.CreateShape();
            Console.WriteLine($"Created: {shape.GetType().Name}");
            shape.Draw();
        }
    }
}