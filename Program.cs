using Creational_Prototype2;

CircleBAD circle = new CircleBAD();
circle.Draw();

Console.WriteLine("User resizes the circle");
circle.Radius = 7;

Console.WriteLine("User adds new rectangle");
RectangleBAD rectangle = new RectangleBAD();
rectangle.Draw();

Console.WriteLine("User resizes the rectangle");
rectangle.Width = 8;
rectangle.Height = 9;

Console.WriteLine("The user clicks and duplicates the cirlce");
Console.WriteLine("The user clicks and duplicates the rectangle");
ShapeActionsBAD shape = new ShapeActionsBAD();
shape.Duplicate(circle);
shape.Duplicate(rectangle);

Console.WriteLine("**************Now use a Prototype object");

Circle circleP = new Circle();
circleP.Draw();

Console.WriteLine("User resizes the circle");
circleP.Radius = 7;

Console.WriteLine("User adds new rectangle");
Rectangle rectangleP = new Rectangle();
rectangleP.Draw();

Console.WriteLine("User resizes the rectangle");
rectangleP.Width = 8;
rectangleP.Height = 9;

Console.WriteLine("The user clicks and duplicates the cirlce");
Console.WriteLine("The user clicks and duplicates the rectangle");
/*now you have the possibility to duplicate shape, without modify the shape action class itself
 * because the logic of duplication is inside a each of shape class
 * you can add new type of shapes without modify exixting code
 */ 
ShapeActions shapeP = new ShapeActions();
Circle newCircle = shapeP.Duplicate(circleP) as Circle;
IShape newRectangle = shapeP.Duplicate(rectangleP);

Console.WriteLine("Now, the shapes have a dimension set in the last resize actions");
newCircle.Draw();
newRectangle.Draw();