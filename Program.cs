int lengthInt = ConsoleDisplay.getSideInt(false);
int widthInt = ConsoleDisplay.getSideInt(true);

Console.WriteLine("The area of the rectangle is " + Rectangle.RectangleArea(lengthInt, widthInt));

double lengthDouble = ConsoleDisplay.getSideDouble(false);
double widthDouble = ConsoleDisplay.getSideDouble(true);

Console.WriteLine("The perimeter of the rectangle is " + Rectangle.RectanglePerimeter(lengthDouble, widthDouble));

lengthDouble = ConsoleDisplay.getSideDouble(false);
widthDouble = ConsoleDisplay.getSideDouble(true);

bool isSquare = Rectangle.IsSquare(lengthDouble, widthDouble);
if (isSquare)
{
    Console.WriteLine("The shape is a square");
}
else
{
    Console.WriteLine("The shape is a rectangle");
}

double side1 = ConsoleDisplay.getSideDoubleTriangle(1);
double side2 = ConsoleDisplay.getSideDoubleTriangle(2);
double side3 = ConsoleDisplay.getSideDoubleTriangle(3);
Console.WriteLine("The triangle is " + Triangle.TypeOfTriangle(side1, side2, side3));

Console.ReadKey();