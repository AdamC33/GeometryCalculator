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


Console.ReadKey();