static class Rectangle
{
    public static int RectangleArea(int length, int width)
    {
        return (length*width);
    }
    public static double RectanglePerimeter(double length, double width)
    {
        return ((2*length) + (2*width));
    }
    public static bool IsSquare(double length, double width)
    {
        if (length == width)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}