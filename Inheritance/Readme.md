## The Inheritance Challenge

You are given a base class `Shape` and several derived classes representing different shapes. Your task is to implement the missing functionality in the derived classes and make them interact with each other based on their properties.

### Class: Shape

#### Properties:

1. `Area` (double): A virtual property that should be implemented by all derived classes to calculate and return the area of the shape.

2. `Perimeter` (double): A virtual property that should be implemented by all derived classes to calculate and return the perimeter of the shape.

### Derived Classes: Circle, Rectangle, and Square

#### Additional Properties:

1. `Radius` (double) [Circle]: The radius of the circle.
2. `Width` (double) [Rectangle]: The width of the rectangle.
3. `Height` (double) [Rectangle and Square]: The height of the rectangle or the side length of the square.

#### Methods:

1. `DisplayShapeInfo`: A method in each derived class that displays the information about the shape, including its type, area, and perimeter.

2. `Interact`: A method in each derived class that interacts with another shape. Implement this method differently for different shape combinations:
    - Circle interacting with Rectangle: The method should display whether the circle is completely inside the rectangle, completely outside, or intersecting with the rectangle.
    - Rectangle interacting with Square: The method should display whether the rectangle is completely inside the square, completely outside, or intersecting with the square.
    - Square interacting with Circle: The method should display whether the square is completely inside the circle, completely outside, or intersecting with the circle.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(10, 6);
        Square square = new Square(8);

        circle.DisplayShapeInfo();
        rectangle.DisplayShapeInfo();
        square.DisplayShapeInfo();

        circle.Interact(rectangle);
        rectangle.Interact(square);
        square.Interact(circle);
    }
}
