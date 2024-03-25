namespace AreaCalculation
{
    internal class Program
    {
        // Circle Area Function
        public static double CircleArea(double radius)
        {
            return double.Pi * radius * radius;
        }
        
        // Triangle Area Function
        public static double TriangleArea(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }
        
        // Rectangle Area Function
        public static double RectangleArea (double length, double width)
        {
            return length * width;
        }
        
        // Square Area Function
        public static double SquareArea (double side) 
        {
            return side * side;
        }
        static void Main(string[] args)
        {
            // User input
            Console.WriteLine("Area Calculation (type 1 for circle, 2 for triangle, 3 for rectangle, 4 for square):");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1) 
            { 
                Console.WriteLine("Option 1: Calculate the area of a circle");
                Console.WriteLine("Please enter the radius of the circle");
                double inputRadius = int.Parse(Console.ReadLine());
                double result = CircleArea(inputRadius);
                Console.WriteLine($"Answer: {result}");
            }
            else if (selection == 2)
            {
                Console.WriteLine("Option 2: Calculate the area of a triangle");
                Console.WriteLine("Please enter the base length");
                double inputBaseLength = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the height");
                double inputHeight = int.Parse(Console.ReadLine());
                double result = TriangleArea(inputBaseLength, inputHeight);
                Console.WriteLine($"Answer: {result}");
            }
            else if (selection == 3)
            {
                Console.WriteLine("Option 3: Calculate the area of a rectangle");
                Console.WriteLine("Please enter the length");
                double inputLength = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the width");
                double inputWidth = int.Parse(Console.ReadLine());
                double result = RectangleArea(inputLength, inputWidth);
                Console.WriteLine($"Answer: {result}");
            }
            else if (selection == 4)
            {
                Console.WriteLine("Option 4: Calculate the area of a square");
                Console.WriteLine("Please enter the side");
                double inputSide = int.Parse(Console.ReadLine());
                double result = SquareArea(inputSide);
                Console.WriteLine($"Answer: {result}");
            }
            else 
            { 
                // if user pick any number other than 1, 2, 3, or 4
                Console.WriteLine("INVALID INPUT");
            }
        }
    }
}
