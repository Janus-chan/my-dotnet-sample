namespace SampleApp;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero");

        return (double)a / b;
    }

    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Factorial cannot be calculated for negative numbers");

        if (n == 0 || n == 1)
            return 1;

        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // New mathematical operations
    public double Power(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }

    public double SquareRoot(double number)
    {
        if (number < 0)
            throw new ArgumentException("Cannot calculate square root of negative number");

        return Math.Sqrt(number);
    }

    public int GreatestCommonDivisor(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public int LeastCommonMultiple(int a, int b)
    {
        if (a == 0 || b == 0)
            return 0;

        return Math.Abs(a * b) / GreatestCommonDivisor(a, b);
    }

    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
        return true;
    }

    public List<int> FibonacciSequence(int count)
    {
        if (count <= 0)
            throw new ArgumentException("Count must be positive");

        var sequence = new List<int>();

        if (count >= 1) sequence.Add(0);
        if (count >= 2) sequence.Add(1);

        for (int i = 2; i < count; i++)
        {
            sequence.Add(sequence[i - 1] + sequence[i - 2]);
        }

        return sequence;
    }

    public double Percentage(double value, double total)
    {
        if (total == 0)
            throw new DivideByZeroException("Total cannot be zero");

        return (value / total) * 100;
    }

    // Statistics methods
    public double Average(params double[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Cannot calculate average of empty array");

        return numbers.Average();
    }

    public double Median(params double[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Cannot calculate median of empty array");

        var sorted = numbers.OrderBy(x => x).ToArray();
        int count = sorted.Length;

        if (count % 2 == 0)
        {
            return (sorted[count / 2 - 1] + sorted[count / 2]) / 2.0;
        }
        else
        {
            return sorted[count / 2];
        }
    }

    public double Max(params double[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Cannot find max of empty array");

        return numbers.Max();
    }

    public double Min(params double[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Cannot find min of empty array");

        return numbers.Min();
    }

    // Temperature conversion methods (these will remain untested to avoid 100% coverage)
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9.0 / 5.0) + 32;
    }

    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5.0 / 9.0;
    }

    // Distance conversion methods (also untested)
    public double MilesToKilometers(double miles)
    {
        return miles * 1.60934;
    }

    public double KilometersToMiles(double kilometers)
    {
        return kilometers / 1.60934;
    }

    // Complex calculation method (partially tested)
    public double CalculateCompoundInterest(double principal, double rate, int timesCompounded, double years)
    {
        if (principal <= 0 || rate < 0 || timesCompounded <= 0 || years < 0)
            throw new ArgumentException("Invalid parameters for compound interest calculation");

        return principal * Math.Pow((1 + rate / timesCompounded), timesCompounded * years);
    }
}