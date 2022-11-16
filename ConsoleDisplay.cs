static class ConsoleDisplay
{
    public static int getSideInt(bool isWidth)
    {
        bool conversionCorrect = true;
        string sideString = "";
        int side = 0;
        if (isWidth)
        {
            sideString = "width";
        }
        else
        {
            sideString = "length";
        }
        do
        {
            conversionCorrect = true;
            Console.WriteLine("Please input the " + sideString + " of the rectangle. (Integer values only)");
            try
            {
                side = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                side = 0;
                conversionCorrect = false;
                Console.WriteLine("Please only enter integer values.");
            }
        }
        while (conversionCorrect == false);
        return side;
    }
    public static double getSideDouble(bool isWidth)
    {
        bool conversionCorrect = true;
        string sideString = "";
        double side = 0;
        if (isWidth)
        {
            sideString = "width";
        }
        else
        {
            sideString = "length";
        }
        do
        {
            conversionCorrect = true;
            Console.WriteLine("Please input the " + sideString + " of the rectangle. (Double values only)");
            try
            {
                side = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                side = 0;
                conversionCorrect = false;
                Console.WriteLine("Please only enter double values.");
            }
        }
        while (conversionCorrect == false);
        return side;
    }
    public static double getSideDoubleTriangle(int sideNumber)
    {
        bool conversionCorrect = true;
        double side = 0;
        do
        {
            conversionCorrect = true;
            Console.WriteLine("Please input side " + sideNumber + " of the triangle. (Double values only)");
            try
            {
                side = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                side = 0;
                conversionCorrect = false;
                Console.WriteLine("Please only enter double values.");
            }
        }
        while (conversionCorrect == false);
        return side;
    }
}