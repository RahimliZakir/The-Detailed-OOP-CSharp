using System.Reflection.Metadata;

namespace Polymorphism.ConsoleApp._1.CompileTimePolymorphism.a.MethodOverloading
{
    // 1. a. Method Overloading
    // In a C# class, we can create methods with the same name in a class if they have:
    // • different numbers of parameter
    // • types of parameter
    class GeometryFiguresArea
    {
        // Method to calculate the area of a square
        public double CalculateArea(int sideLength)
        {
            return Math.Pow(sideLength, 2);
        }

        // Method to calculate the area of a rectangle
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        // Method to calculate the area of a circle
        public double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
