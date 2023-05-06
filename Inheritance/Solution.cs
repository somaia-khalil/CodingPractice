// Solution to The Inheritance Challenge

using System;

public class Shape
{
    public virtual double Area { get; }
    public virtual double Perimeter { get; }
}

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area => Math.PI * Radius * Radius;
    public override double Perimeter => 2 * Math.PI * Radius;

    public void DisplayShapeInfo()
    {
        Console.WriteLine("Circle");
        Console.WriteLine($"Area: {Area}");
        Console.WriteLine($"Perimeter: {Perimeter}");
    }

    public void Interact(Shape shape)
    {
        if (shape is Rectangle rectangle)
        {
            double centerX = Radius;
            double centerY = 0;

            double rectangleLeft = rectangle.Width / -2;
            double rectangleRight = rectangle.Width / 2;
            double rectangleTop = rectangle.Height / 2;
            double rectangleBottom = rectangle.Height / -2;

            if (centerX + Radius < rectangleLeft || centerX - Radius > rectangleRight ||
                centerY + Radius < rectangleBottom || centerY - Radius > rectangleTop)
            {
                Console.WriteLine("The circle is completely outside the rectangle.");
            }
            else if (centerX + Radius <= rectangleRight && centerX - Radius >= rectangleLeft &&
                     centerY + Radius <= rectangleTop && centerY - Radius >= rectangleBottom)
            {
                Console.WriteLine("The circle is completely inside the rectangle.");
            }
            else
            {
                Console.WriteLine("The circle intersects with the rectangle.");
            }
        }
    }
}

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area => Width * Height;
    public override double Perimeter => 2 * (Width + Height);

    public void DisplayShapeInfo()
    {
        Console.WriteLine("Rectangle");
        Console.WriteLine($"Area: {Area}");
        Console.WriteLine($"Perimeter: {Perimeter}");
    }

    public void Interact(Shape shape)
    {
        if (shape is Square square)
        {
            double halfWidth = Width / 2;
            double halfHeight = Height / 2;
            double squareHalfSide = square.Height / 2;

            double squareLeft = -squareHalfSide;
            double squareRight = squareHalfSide;
            double squareTop = squareHalfSide;
            double squareBottom = -squareHalfSide;

            if (halfWidth + squareHalfSide < squareLeft || halfWidth - squareHalfSide > squareRight ||
                halfHeight + squareHalfSide < squareBottom || halfHeight - squareHalfSide > squareTop)
            {
                Console.WriteLine("The rectangle is completely outside the square.");
            }
            else if (halfWidth + squareHalfSide <= squareRight && halfWidth - squareHalfSide >= squareLeft &&
                     halfHeight + squareHalfSide <= squareTop && halfHeight - squareHalfSide >= squareBottom)
            {
                Console.WriteLine("The rectangle is completely inside the square.");
            }
            else
            {
                Console.WriteLine("The rectangle intersects with the square.");
            }
        }
    }
}

public class Square : Rectangle
{
    public Square(double sideLength) : base(sideLength, sideLength)
    {
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine("Square");
        Console.WriteLine($"Area: {Area}");
        Console.WriteLine($"Perimeter: {Perimeter}");
    }

    public void Interact(Shape shape)
    {
        if (shape is Circle circle)
        {
            double halfSide = Height / 2;
            double circleCenterX = circle.Radius;
            double circleCenterY = 0;

            if (circleCenterX + circle.Radius < halfSide || circleCenterX - circle.Radius > -halfSide ||
                circleCenterY + circle.Radius < halfSide || circleCenterY - circle.Radius > -halfSide)
            {
                Console.WriteLine("The square is completely outside the circle.");
            }
            else if (circleCenterX + circle.Radius <= halfSide && circleCenterX - circle.Radius >= -halfSide &&
                     circleCenterY + circle.Radius <= halfSide && circleCenterY - circle.Radius >= -halfSide)
            {
                Console.WriteLine("The square is completely inside the circle.");
            }
            else
            {
                Console.WriteLine("The square intersects with the circle.");
            }
        }
    }
}
