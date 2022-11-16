static class Triangle
{
    public static string TypeOfTriangle(double side1, double side2, double side3)
    {
        //Angle checks are not needed. If all sides are equal then all angles are equal. If two sides are equal then the two angles opposite those sides are also equal.
        if (side1 == side2 && side1 == side3)
        {
            return "equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "isosceles";
        }
        else
        {
            return "scalene";
        }
    }
}