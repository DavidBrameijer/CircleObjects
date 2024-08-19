using CircleObjects;

Console.WriteLine("Welcome to the circle calculator!");


Console.WriteLine("Please enter a radius.");
double radius;
bool runProgram = true;

while (runProgram)
{

while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
{
    Console.WriteLine("Invalid radius. try again");
}
Circle circle = new Circle(radius);
Console.WriteLine($"Diameter is {circle.CalculateDiameter(radius)} ");
Console.WriteLine($"Circumferrence is {circle.CalculateCircumference(radius)}");
Console.WriteLine($"Area is {circle.CalculateArea(radius)}");

Console.WriteLine("Should the circle grow? y/n");
string input = Console.ReadLine();
if (input == "y")
{
    circle.Grow();
    Console.WriteLine("The circle is magically growing!");
    Console.WriteLine($"Diameter is {circle.CalculateDiameter(radius)} ");
    Console.WriteLine($"Circumferrence is {circle.CalculateCircumference(radius)}");
    Console.WriteLine($"Area is {circle.CalculateArea(radius)}");
}
else if (input == "n")
    {
        runProgram = false;
        Console.WriteLine($"Goodbye. The Circle's final radius is {radius}");
    }
    else
    {
        Console.WriteLine( "Invalid response.");
    }
}
