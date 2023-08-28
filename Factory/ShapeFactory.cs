namespace Factory;

public class ShapeFactory
{
    public Shape CreateShape(ShapeTypeEnum type)
    {
        if (type == ShapeTypeEnum.Circle)
            return new Circle();
        if (type == ShapeTypeEnum.Triangle)
            return new Triangle();
        if (type == ShapeTypeEnum.Rectangle)
            return new Rectangle();
        throw new Exception($"Shape type {type} is missing");
    }
}