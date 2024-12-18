using System;
using Day_8_Part02.Abstract;
using Day_8_Part02.Class;
using Day_8_Part02.Interface;

public class Program
{
    public static void PrintTenShapes(IShapeSeries series)
    {
        for (int i = 0; i < 10; i++)
        {
            series.GetNextArea();
            Console.WriteLine($"Shape {i + 1} Area: {series.CurrentShapeArea}");
        }
    }
    public static void Main()
    {
        #region Shape Series 
        //Console.WriteLine("Square Series:");
        //PrintTenShapes(new SquareSeries());

        //Console.WriteLine("Circle Series:");
        //PrintTenShapes(new CircleSeries());

        #endregion

        #region Sorting Shapes
        //Shape[] shapes = {
        //    new Shape { Name = "Square", Area = 25 },
        //    new Shape { Name = "Circle", Area = 78.5 },
        //    new Shape { Name = "Rectangle", Area = 50 }
        //};

        //Array.Sort(shapes);

        //foreach (var shape in shapes)
        //{
        //    Console.WriteLine($"{shape.Name}: {shape.Area}");
        //}
        #endregion

        #region Shape Hierarchy
        //GeometricShape triangle = new Triangle { Dimension1 = 3, Dimension2 = 4 };
        //GeometricShape rectangle = new Rectangle { Dimension1 = 5, Dimension2 = 6 };

        //Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.Perimeter}");
        //Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.Perimeter}");
        #endregion

        #region SelectionSort
        //int[] areas = { 25, 78, 50, 10, 36 };
        //SortingUtils.SelectionSort(areas);
        //Console.WriteLine("Sorted Areas:");
        //Console.WriteLine(string.Join(", ", areas));
        #endregion

        #region Factory Pattern Bonus
        //var factoryRectangle = ShapeFactory.CreateShape("rectangle", 4, 5);
        //var factoryTriangle = ShapeFactory.CreateShape("triangle", 3, 4);
        //Console.WriteLine($"Factory Rectangle: Area = {factoryRectangle.CalculateArea()}, Perimeter = {factoryRectangle.Perimeter}");
        //Console.WriteLine($"Factory Triangle: Area = {factoryTriangle.CalculateArea()}, Perimeter = {factoryTriangle.Perimeter}");
        #endregion
    }
}

   