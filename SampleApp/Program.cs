using SampleApp;

Console.WriteLine("Enhanced Calculator Application");
Console.WriteLine("===============================");

var calculator = new Calculator();

// Basic arithmetic operations
Console.WriteLine("=== Basic Operations ===");
Console.WriteLine($"5 + 3 = {calculator.Add(5, 3)}");
Console.WriteLine($"10 - 4 = {calculator.Subtract(10, 4)}");
Console.WriteLine($"6 * 7 = {calculator.Multiply(6, 7)}");
Console.WriteLine($"15 / 3 = {calculator.Divide(15, 3)}");

// Advanced mathematical operations
Console.WriteLine("\n=== Advanced Math ===");
Console.WriteLine($"2^8 = {calculator.Power(2, 8)}");
Console.WriteLine($"√25 = {calculator.SquareRoot(25)}");
Console.WriteLine($"5! = {calculator.Factorial(5)}");

// Number theory
Console.WriteLine("\n=== Number Theory ===");
Console.WriteLine($"GCD(48, 18) = {calculator.GreatestCommonDivisor(48, 18)}");
Console.WriteLine($"LCM(12, 8) = {calculator.LeastCommonMultiple(12, 8)}");
Console.WriteLine($"Is 17 prime? {calculator.IsPrime(17)}");
Console.WriteLine($"Is 15 even? {calculator.IsEven(15)}");

// Fibonacci sequence
Console.WriteLine("\n=== Fibonacci Sequence (first 8) ===");
var fibonacci = calculator.FibonacciSequence(8);
Console.WriteLine($"[{string.Join(", ", fibonacci)}]");

// Statistics
Console.WriteLine("\n=== Statistics ===");
var numbers = new double[] { 10, 20, 30, 40, 50 };
Console.WriteLine($"Numbers: [{string.Join(", ", numbers)}]");
Console.WriteLine($"Average: {calculator.Average(numbers):F2}");
Console.WriteLine($"Max: {calculator.Max(numbers)}");
Console.WriteLine($"Min: {calculator.Min(numbers)}");

// Percentage calculation
Console.WriteLine("\n=== Percentage ===");
Console.WriteLine($"25 out of 100 = {calculator.Percentage(25, 100)}%");

// Error handling demonstration
Console.WriteLine("\n=== Error Handling ===");
try
{
    Console.WriteLine($"10 / 0 = {calculator.Divide(10, 0)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    Console.WriteLine($"√(-4) = {calculator.SquareRoot(-4)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("\nApplication completed successfully!");
