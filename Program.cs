using Kiss_Calculator;

// Complex approach usage
var complexCalc = new ComplexCalculator();
try
{
    var complexResult = complexCalc.Calculate("add", 5, 3);
    Console.WriteLine($"Complex Calculator Result: {complexResult}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error in complex calculator: {ex.Message}");
}

// Simple approach usage
var simpleCalc = new SimpleCalculator();
var simpleResult = simpleCalc.Add(5, 3);
Console.WriteLine($"Simple Calculator Result: {simpleResult}");

// Simple error handling example
try
{
    var divisionResult = simpleCalc.Divide(10, 2);
    Console.WriteLine($"Division Result: {divisionResult}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}