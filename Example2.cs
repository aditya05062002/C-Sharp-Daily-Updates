/*using System;

namespace ShapeProject
{
    // Base class
    class Shape
    {
        // Encapsulated field
        private string color;

        // Constructor
        public Shape(string color)
        {
            this.color = color;
        }

        // Public property for encapsulation
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Virtual method for polymorphism
        public virtual double CalculateArea()
        {
            return 0;
        }

        // Method to display shape details
        public void DisplayInfo()
        {
            Console.WriteLine($"Shape Color: {color}");
        }
    }

    // Derived class
    class Circle : Shape
    {
        private double radius;

        // Constructor
        public Circle(string color, double radius)
            : base(color)
        {
            this.radius = radius;
        }

        // Public property for encapsulation
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Overridden method for polymorphism
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Method to display circle details
        public void DisplayCircleInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }

    // Derived class
    class Rectangle : Shape
    {
        private double width;
        private double height;

        // Constructor
        public Rectangle(string color, double width, double height)
            : base(color)
        {
            this.width = width;
            this.height = height;
        }

        // Public properties for encapsulation
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Overridden method for polymorphism
        public override double CalculateArea()
        {
            return width * height;
        }

        // Method to display rectangle details
        public void DisplayRectangleInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle("Red", 5);
            Rectangle rectangle = new Rectangle("Blue", 4, 6);

            // Display details and calculate area of the shapes
            circle.DisplayCircleInfo();
            Console.WriteLine();

            rectangle.DisplayRectangleInfo();
        }
    }
}
*/