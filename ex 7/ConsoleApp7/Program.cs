using System;

class Geometry
{


    static double areaRectangle(double a, double b)
    {
        double area = a * b;
        return area;
    }

    static double perimeterRectangle(double a, double b)
    {
        double perimeter = 2 * (a + b);
        return perimeter;
    }

   
    public static void Main()
    {

       double a = 5.5;
        double b = 8.5;

        Console.WriteLine("Area = "
                      + areaRectangle(a, b));
        Console.WriteLine("Perimeter = "
                 + perimeterRectangle(a, b));
    }
}