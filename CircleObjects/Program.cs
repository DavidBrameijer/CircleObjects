using CircleObjects;

Console.WriteLine("Welcome to the circle calculator!");


Console.WriteLine("Please enter a radius.");
int radius = Validation.GetPositiveRadius();
bool runProgram = true;

Circle circle = new Circle(radius);
while (runProgram)
{
    Console.WriteLine(Returns.ReturnValues(circle));
    runProgram = Validation.GetGrowAgain(circle, radius);
}