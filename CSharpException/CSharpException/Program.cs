using System.Diagnostics.Metrics;
using CSharpException;

Triangle myTriangle = new Triangle();

do
{
    try
    {
        myTriangle.InputSide();
    }

    catch (InvalidSideException ex)
    {
        Console.WriteLine(ex.Message);
    }

}
while (!myTriangle.IsFilled);

myTriangle.ValidateSides();

Console.WriteLine($"Your triangle has sides:{myTriangle.Side_A} dm,{myTriangle.Side_B} dm, and {myTriangle.Side_C} dm");

Console.ReadLine();
