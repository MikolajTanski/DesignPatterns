// See https://aka.ms/new-console-template for more information

using Factory;

var shapeFactory = new ShapeFactory();

var circle = shapeFactory.CreateShape(ShapeTypeEnum.Circle);
var rectangle = shapeFactory.CreateShape(ShapeTypeEnum.Rectangle);
var triangle = shapeFactory.CreateShape(ShapeTypeEnum.Triangle);

circle.Render();
rectangle.Render();
triangle.Render();